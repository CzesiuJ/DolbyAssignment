using MvvmCross;
using MvvmCross.Platforms.Uap.Core;
using MvvmCross.ViewModels;
using SoundChecker.Core;
using SoundChecker.Core.Services.Speaker;
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
            base.InitializeLastChance();
        }
    }
}