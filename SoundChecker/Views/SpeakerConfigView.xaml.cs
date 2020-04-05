using Windows.UI.Xaml.Controls;
using SoundChecker.ViewModels;

namespace SoundChecker.Views
{
    public sealed partial class SpeakerConfigView : UserControl
    {
        public SpeakerConfigView()
        {
            InitializeComponent();
        }

        public SpeakerConfigViewModel ViewModel => DataContext as SpeakerConfigViewModel;
    }
}