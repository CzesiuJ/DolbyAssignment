using SoundChecker.Core.Services;
using SoundChecker.Core.Services.Speaker;

namespace SoundChecker.Core.ViewModels
{
    public class SpeakerConfigViewModel : ConfigViewModelBase
    {
        private readonly ISpeakerConfiguration _speakerConfiguration;

        public SpeakerConfigViewModel(ISpeakerConfiguration speakerConfiguration, ISoundSettingsLauncher soundSettingsLauncher) : base(soundSettingsLauncher)
        {
            _speakerConfiguration = speakerConfiguration;
        }
    }
}