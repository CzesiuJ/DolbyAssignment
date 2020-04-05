using System.Threading.Tasks;
using SoundChecker.Core.Services;

namespace SoundChecker.Uwp.Core.Services
{
    public class SettingsLauncher : ISoundSettingsLauncher
    {
        public Task LaunchSoundSettingsAsync()
        {
            return Task.CompletedTask;
        }
    }
}