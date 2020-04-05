using System.Windows.Input;
using Prism.Commands;
using Prism.Windows.Mvvm;
using SoundChecker.Uwp.Core.Services;

namespace SoundChecker.ViewModels
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

        public ICommand LaunchSettingsCommand => new DelegateCommand(LaunchSettings);

        private async void LaunchSettings()
        {
            await SoundSettingsLauncher.LaunchSoundSettingsAsync();
        }
    }
}