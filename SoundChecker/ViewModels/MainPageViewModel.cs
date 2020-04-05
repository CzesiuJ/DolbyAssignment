using Prism.Windows.Mvvm;
using SoundChecker.Uwp.Core.Services.Headset;

namespace SoundChecker.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly IHeadsetConfiguration _headsetConfiguration;
        private bool _isHeadsetButtonChecked;
        private bool _isSpeakerButtonChecked;

        public MainPageViewModel(IHeadsetConfiguration headsetConfiguration)
        {
            _headsetConfiguration = headsetConfiguration;
            IsHeadsetButtonChecked = true;
        }

        public bool IsHeadsetButtonChecked
        {
            get => _isHeadsetButtonChecked;
            set => SetProperty(ref _isHeadsetButtonChecked, value);
        }

        public bool IsSpeakerButtonChecked
        {
            get => _isSpeakerButtonChecked;
            set => SetProperty(ref _isSpeakerButtonChecked, value);
        }
    }
}