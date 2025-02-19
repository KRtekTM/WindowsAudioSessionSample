﻿using System;

using WASApiBassNet.Components.AudioCapture;

namespace WASApiBassNet.Components.FFT
{
    /// <summary>
    /// fft analyzer
    /// </summary>
    public class FFTAnalyzer : IFFTAnalyzer, IAudioPlugin
    {
        int _barsCount;
        /// <inheritdoc/>
        public int BarsCount
        {
            get => _barsCount;
            set
            {
                _barsCount = value;
                SpectrumData = new double[_barsCount];
            }
        }
        public int ShowingBarsCount { get; set; }

        /// <inheritdoc/>
        public IFFTProvider FFTProvider { get; set; }

        /// <inheritdoc/>
        public double[] SpectrumData { get; protected set; }

        /// <inheritdoc/>
        public void HandleTick()
        {
            if (!FFTProvider.IsFFTAvailable) return;

            var b0 = 0;
            var _bufferLastIndex = FFTProvider.FFTLength.ToBufferSize() - 1;

            for (var x = 0; x < BarsCount; x++)
            {
                double peak = 0;
                var b1 = (int)Math.Pow(2, x * 10.0 / (BarsCount - 1));
                if (b1 > _bufferLastIndex) b1 = _bufferLastIndex;
                if (b1 <= b0) b1 = b0 + 1;
                for (; b0 < b1; b0++)
                {
                    if (peak < FFTProvider.FFTData[1 + b0])
                        peak = FFTProvider.FFTData[1 + b0];
                }
                var y = (Math.Sqrt(peak) * 3 * 255) - 4;
                if (y > 255) y = 255;
                if (y < 0) y = 0;

                SpectrumData[x] = y;
            }
        }

        /// <inheritdoc/>
        void Reset()
        {
            if (SpectrumData != null)
                for (var x = 0; x < BarsCount; x++) SpectrumData[x] = 0;
        }

        /// <inheritdoc/>
        public void Start()
        {
            Reset();
        }

        /// <inheritdoc/>
        public void Stop()
        {
            Reset();
        }
    }
}
