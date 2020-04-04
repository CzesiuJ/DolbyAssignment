using Windows.UI.Xaml.Controls;
using MvvmCross.Platforms.Uap.Views;
using MvvmCross.ViewModels;
using MvvmCross.Views;
using SoundChecker.Core.ViewModels;

namespace SoundChecker.Views
{
    public sealed partial class MainPageView : Page, IMvxWindowsView<MainPageViewModel>
    {
        public MainPageView()
        {
            InitializeComponent();
        }

        IMvxViewModel IMvxView.ViewModel
        {
            get => ViewModel;
            set => ViewModel = value as MainPageViewModel;
        }

        public MainPageViewModel ViewModel { get; set; }

        public void ClearBackStack()
        {
        }
    }
}