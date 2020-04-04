using Windows.UI.Xaml.Controls;
using MvvmCross;
using SoundChecker.Core.ViewModels;

namespace SoundChecker.Views
{
    public sealed partial class SpeakerConfigView : UserControl
    {
        public SpeakerConfigView()
        {
            InitializeComponent();
            DataContext = Mvx.IoCProvider.IoCConstruct<SpeakerConfigViewModel>();
        }

        public SpeakerConfigViewModel ViewModel => DataContext as SpeakerConfigViewModel;
    }
}