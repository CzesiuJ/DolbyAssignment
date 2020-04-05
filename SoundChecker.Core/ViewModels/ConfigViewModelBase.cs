using MvvmCross.Commands;
using MvvmCross.ViewModels;
using SoundChecker.Core.Services;

namespace SoundChecker.Core.ViewModels
{
    public abstract class ConfigViewModelBase : MvxViewModel
    {
        protected readonly ISoundSettingsLauncher SoundSettingsLauncher;
        private bool _isAtmosReadyToUse;

        public ConfigViewModelBase(ISoundSettingsLauncher soundSettingsLauncher)
        {
            SoundSettingsLauncher = soundSettingsLauncher;
        }

        public bool IsAtmosReadyToUse
        {
            get => _isAtmosReadyToUse;
            set => SetProperty(ref _isAtmosReadyToUse, value);
        }

        public IMvxCommand LaunchSettingsCommand => new MvxCommand(LaunchSettings);

        private void LaunchSettings()
        {
        }
    }
}