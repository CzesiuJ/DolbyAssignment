using MvvmCross.ViewModels;
using SoundChecker.Core.ViewModels;

namespace SoundChecker.Core
{
    public class CoreApp : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<MainPageViewModel>();
        }
    }
}