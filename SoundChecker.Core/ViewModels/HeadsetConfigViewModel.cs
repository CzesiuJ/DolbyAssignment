using MvvmCross.ViewModels;

namespace SoundChecker.Core.ViewModels
{
    public class HeadsetConfigViewModel : MvxViewModel
    {
        private bool _isAtmosReadyToUse;

        public HeadsetConfigViewModel()
        { }

        public bool IsAtmosReadyToUse
        {
            get => _isAtmosReadyToUse;
            set => SetProperty(ref _isAtmosReadyToUse, value);
        }
    }
}