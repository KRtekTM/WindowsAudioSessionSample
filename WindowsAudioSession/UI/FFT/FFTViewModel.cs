﻿
using WPFUtilities.ComponentModel;

namespace WindowsAudioSession.UI.FFT
{
    /// <summary>
    /// fft view model
    /// </summary>
    public class FFTViewModel : ModelBase, IFFTViewModel
    {
        int _barCount = 512;

        /// <summary>
        /// bar count
        /// </summary>
        [BarsCountInAllowableRange]
        public int BarCount
        {
            get => _barCount;

            set
            {
                _barCount = value;
                NotifyPropertyChanged();
            }
        }

        int _showingBarCount = 512;
        public int ShowingBarCount
        {
            get => _showingBarCount;
            set
            {
                _showingBarCount = value;
            }
        }

        int _barWidthPercent = 100;

        /// <summary>
        /// bar width percent
        /// </summary>
        public int BarWidthPercent
        {
            get => _barWidthPercent;
            set
            {
                _barWidthPercent = value;
                NotifyPropertyChanged();
            }
        }

        bool _isStarted = false;

        /// <summary>
        /// is started
        /// </summary>
        public bool IsStarted
        {
            get => _isStarted;

            protected set
            {
                _isStarted = value;
                NotifyPropertyChanged();
            }
        }

        /// <inheritdoc/>
        public void HandleTick() { }

        /// <inheritdoc/>
        public void Start()
        {
            if (IsStarted) return;
            Validate();
            if (!IsValid) return;
            IsStarted = true;
        }

        /// <inheritdoc/>
        public void Stop()
        {
            if (!IsStarted) return;
            IsStarted = false;
        }

    }
}
