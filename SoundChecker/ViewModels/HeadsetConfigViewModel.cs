using SoundChecker.Core.ViewModels;
using SoundChecker.Uwp.Core.Services;
using SoundChecker.Uwp.Core.Services.Headset;

namespace SoundChecker.ViewModels
{
    public class HeadsetConfigViewModel : ConfigViewModelBase
    {
        private readonly IHeadsetConfiguration _headsetConfiguration;

        public HeadsetConfigViewModel(IHeadsetConfiguration headsetConfiguration, ISoundSettingsLauncher soundSettingsLauncher) : base(soundSettingsLauncher)
        {
            _headsetConfiguration = headsetConfiguration;
        }
    }
}