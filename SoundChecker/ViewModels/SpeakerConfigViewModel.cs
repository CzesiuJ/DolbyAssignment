using SoundChecker.Uwp.Core.Services;
using SoundChecker.Uwp.Core.Services.Speaker;

namespace SoundChecker.ViewModels
{
    public class SpeakerConfigViewModel : ConfigViewModelBase
    {
        public SpeakerConfigViewModel(ISpeakerConfiguration speakerConfiguration, ISoundSettingsLauncher soundSettingsLauncher) : base(soundSettingsLauncher)
        {
            IsAtmosReadyToUse = speakerConfiguration.IsDolbyAtmosCurrentlySupported();
            speakerConfiguration.DolbyAtmosAvailabilityChanged += OnSpeakerAtmosAvailabilityChanged;
        }

        private void OnSpeakerAtmosAvailabilityChanged(object sender, bool e)
        {
            IsAtmosReadyToUse = e;
        }
    }
}