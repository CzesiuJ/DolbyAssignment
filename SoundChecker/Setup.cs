using MvvmCross;
using MvvmCross.Platforms.Uap.Core;
using MvvmCross.ViewModels;
using SoundChecker.Core;
using SoundChecker.Core.Services;
using SoundChecker.Core.Services.Headset;
using SoundChecker.Core.Services.Speaker;
using SoundChecker.Uwp.Core.Services;
using SoundChecker.Uwp.Core.Services.Headset;
using SoundChecker.Uwp.Core.Services.Speaker;

namespace SoundChecker
{
    public class Setup<TApplication> : MvxWindowsSetup<TApplication> where TApplication : class, IMvxApplication, new()
    {
        protected override IMvxApplication CreateApp()
        {
            return new CoreApp();
        }

        protected override void InitializeLastChance()
        {
            Mvx.IoCProvider.RegisterType<ISoundSettingsLauncher, SettingsLauncher>();
            Mvx.IoCProvider.RegisterType<ISpeakerConfiguration, SpeakerConfiguration>();
            Mvx.IoCProvider.RegisterType<IHeadsetConfiguration, HeadsetConfiguration>();
            base.InitializeLastChance();
        }
    }
}