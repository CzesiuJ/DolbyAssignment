using MvvmCross.Platforms.Uap.Views;
using MvvmCross.ViewModels;
using SoundChecker.Core.ViewModels;

namespace SoundChecker.Views
{
    [MvxViewFor(typeof(MainPageViewModel))]
    public sealed partial class MainPageView : MvxWindowsPage
    {
        public MainPageView()
        {
            InitializeComponent();
        }

        public new MainPageViewModel ViewModel => DataContext as MainPageViewModel;
    }
}