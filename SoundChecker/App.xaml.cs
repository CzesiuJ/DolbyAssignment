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
            Container.RegisterType<IDeviceManager, DeviceManager>(new ContainerControlledLifetimeManager());
            base.ConfigureContainer();
        }

        protected override async Task OnLaunchApplicationAsync(LaunchActivatedEventArgs args)
        {
            var deviceManager = Container.Resolve<IDeviceManager>();
            var devices = await deviceManager.GetAvailableDevicesAsync();
            NavigationService.Navigate("Main", null);
        }
    }
}