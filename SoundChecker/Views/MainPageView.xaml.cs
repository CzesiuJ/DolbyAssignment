using System;
using Windows.Devices.Enumeration;
using Windows.Media.Devices;
using MvvmCross.Platforms.Uap.Views;
using MvvmCross.ViewModels;
using SoundChecker.Core.ViewModels;

namespace SoundChecker.Views
{
    [MvxViewFor(typeof(MainPageViewModel))]
    public sealed partial class MainPageView : MvxWindowsPage
    {
        public MainPageView()
        {
            InitializeComponent();
            Dupa();
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