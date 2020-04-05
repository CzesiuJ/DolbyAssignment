using Windows.UI.Xaml.Controls;
using SoundChecker.Core.ViewModels;
using SoundChecker.ViewModels;

namespace SoundChecker.Views
{
    public sealed partial class HeadsetConfigView : UserControl
    {
        public HeadsetConfigView()
        {
            InitializeComponent();
        }

        public HeadsetConfigViewModel ViewModel => DataContext as HeadsetConfigViewModel;
    }
}