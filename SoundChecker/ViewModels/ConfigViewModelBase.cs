using Prism.Windows.Mvvm;
using SoundChecker.Uwp.Core.Services;

namespace SoundChecker.Core.ViewModels
{
    public abstract class ConfigViewModelBase : ViewModelBase
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

        // public IMvxCommand LaunchSettingsCommand => new MvxCommand(LaunchSettings);

        private void LaunchSettings()
        {
        }
    }
}