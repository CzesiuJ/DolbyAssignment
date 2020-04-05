using System.Threading.Tasks;

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