using Windows.UI.Xaml.Controls;
using SoundChecker.ViewModels;

namespace SoundChecker.Views
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public MainPageViewModel ViewModel => DataContext as MainPageViewModel;
    }
}