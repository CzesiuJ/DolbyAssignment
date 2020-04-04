using MvvmCross.Commands;
using MvvmCross.ViewModels;
using SoundChecker.Core.Services.Speaker;

namespace SoundChecker.Core.ViewModels
{
    public class SpeakerConfigViewModel : MvxViewModel
    {
        private readonly ISoundSettingsLauncher _soundSettingsLauncher;

        public SpeakerConfigViewModel(ISoundSettingsLauncher soundSettingsLauncher)
        {
            _soundSettingsLauncher = soundSettingsLauncher;
        }

        public IMvxCommand LaunchSettingsCommand => new MvxCommand(LaunchSettings);

        private void LaunchSettings()
        {
        }
    }
}