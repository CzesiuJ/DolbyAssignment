using Windows.UI.Xaml.Controls;
using MvvmCross;
using SoundChecker.Core.ViewModels;

namespace SoundChecker.Views
{
    public sealed partial class HeadsetConfigView : UserControl
    {
        public HeadsetConfigView()
        {
            InitializeComponent();
            DataContext = Mvx.IoCProvider.IoCConstruct<HeadsetConfigViewModel>();
        }

        public HeadsetConfigViewModel ViewModel => DataContext as HeadsetConfigViewModel;
    }
}