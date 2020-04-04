using MvvmCross.Core;
using MvvmCross.Platforms.Uap.Views;
using SoundChecker.Core;

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
            this.RegisterSetupType<Setup<CoreApp>>();
        }
    }
}