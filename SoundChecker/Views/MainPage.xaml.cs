using System;
using Windows.Devices.Enumeration;
using Windows.Media.Devices;
using Windows.UI.Xaml.Controls;
using SoundChecker.ViewModels;

namespace SoundChecker.Views
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public new MainPageViewModel ViewModel => DataContext as MainPageViewModel;

        private async void Dupa()
        {
            var audioSelector = MediaDevice.GetAudioRenderSelector();
            var outputDevices = await DeviceInformation.FindAllAsync(audioSelector);
            var dupa = outputDevices;
        }
    }
}