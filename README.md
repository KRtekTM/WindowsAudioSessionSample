# Audio Spectrum Visualizer for Windows

A sample of usage of Windows Audio Session WASAPI using BASS.NET - WPF C# .NET Framework 4.8

- colored bars (vu-meters) showing captured device sound FFT , Sound Level and sound wave

<p align="center">
<img src="https://github.com/KRtekTM/WindowsAudioSessionSample/blob/main/Doc/softronics.gif?raw=true" align="center" alt="a FFT having 512 bars + FFT with 16 bars and peak bars + stereo sound level">
<br>
<i>a FFT having 512 bars + FFT with 16 bars and peak bars + stereo sound level + sound wave</i>
</p>

Run the project, select your audio device, and this tool will listen to the device internal output and animates some of the sound properties. The library BASS.NET is used to interface C# with the WASAPI Windows library.

Currently made for 1280x400 pixels: <a href="https://www.waveshare.com/7.9inch-hdmi-lcd.htm">https://www.waveshare.com/7.9inch-hdmi-lcd.htm</a>

## Key bindings:
- F11 - toggle fullscreen
  
## Touch gestures:
- swipe left - volume down
- swipe right - volume up
- triple touch - in normal view switches to fullscreen, in fullscreen closes application

## Font dependencies
- Parsi (can't provide link due to license)
- VFD Display (can't provide link due to license)

## Original text from franck-gaspoz
Clean architecture approach: complete discoupling between data,data providers,data transformers,ui controls,drawers,view models,application logic. 
Relying on the patterns MVVM, Command, Chain of responsability, Dependency injection, Mediator.

Implements several importants aspects of WPF programming:
- User Controls, Resources/Styles, Converters, View Models, Data annotations, Data validators, Data binding, Commands, Visual Drawings

## Components dependencies:

<a href="https://app.diagrams.net/?mode=github#Hfranck-gaspoz%2FWindowsAudioSessionSample%2Fmain%2FDoc%2Fcomponents1.drawio.svg">
<img src="/Doc/components1.drawio.svg">
</a>

