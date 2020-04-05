using SoundChecker.Core.ViewModels;
using SoundChecker.Uwp.Core.Services;
using SoundChecker.Uwp.Core.Services.Speaker;

namespace SoundChecker.ViewModels
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