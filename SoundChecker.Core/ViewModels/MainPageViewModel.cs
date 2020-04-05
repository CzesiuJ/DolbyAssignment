using MvvmCross.ViewModels;

namespace SoundChecker.Core.ViewModels
{
    public class MainPageViewModel : MvxViewModel
    {
        private bool _isHeadsetButtonChecked;
        private bool _isSpeakerButtonChecked;

        public MainPageViewModel()
        {
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