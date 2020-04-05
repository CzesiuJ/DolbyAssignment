using System.Threading.Tasks;
using SoundChecker.Core.Services;
using SoundChecker.Core.Services.Headset;

namespace SoundChecker.Core.ViewModels
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