using SoundChecker.Uwp.Core.Services;
using SoundChecker.Uwp.Core.Services.Headset;

namespace SoundChecker.ViewModels
{
    public class HeadsetConfigViewModel : ConfigViewModelBase
    {
        public HeadsetConfigViewModel(IHeadsetConfiguration headsetConfiguration, ISoundSettingsLauncher soundSettingsLauncher) : base(soundSettingsLauncher)
        {
            IsAtmosReadyToUse = headsetConfiguration.IsDolbyAtmosCurrentlySupported();
            headsetConfiguration.DolbyAtmosAvailabilityChanged += OnHeadsetAtmosAvailabilityChanged;
        }

        private void OnHeadsetAtmosAvailabilityChanged(object sender, bool e)
        {
            IsAtmosReadyToUse = e;
        }
    }
}