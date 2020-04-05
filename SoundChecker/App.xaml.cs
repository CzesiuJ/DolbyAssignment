using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;
using Microsoft.Practices.Unity;
using Prism.Unity.Windows;
using SoundChecker.Uwp.Core.Services;
using SoundChecker.Uwp.Core.Services.Headset;
using SoundChecker.Uwp.Core.Services.Speaker;

namespace SoundChecker
{
    public sealed partial class App : PrismUnityApplication
    {
        public App()
        {
            InitializeComponent();
        }

        protected override void ConfigureContainer()
        {
            Container.RegisterType<IHeadsetConfiguration, HeadsetConfiguration>();
            Container.RegisterType<ISpeakerConfiguration, SpeakerConfiguration>();
            Container.RegisterType<ISoundSettingsLauncher, SettingsLauncher>();
            Container.RegisterType<IAudioDeviceManager, AudioDeviceManager>(new ContainerControlledLifetimeManager());
            base.ConfigureContainer();
        }

        protected override async Task OnLaunchApplicationAsync(LaunchActivatedEventArgs args)
        {
            await IntializeAudioDevicesAsync();

            NavigationService.Navigate("Main", null);
        }

        private async Task IntializeAudioDevicesAsync()
        {
            var audioDeviceManager = Container.Resolve<IAudioDeviceManager>();
            await audioDeviceManager.InitializeAudioDeviceAsync();
        }
    }
}