using MvvmCross.Core;
using MvvmCross.Platforms.Uap.Core;
using MvvmCross.Platforms.Uap.Views;

namespace SoundChecker
{
    partial class App : MvxApplication
    {
        public App()
        {
            InitializeComponent();
        }

        protected override void RegisterSetup()
        {
            this.RegisterSetupType<MvxWindowsSetup<Core.CoreApp>>();
        }
    }
}