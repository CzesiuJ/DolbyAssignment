using System;
using System.Threading.Tasks;

namespace SoundChecker.Uwp.Core.Services
{
    public class SettingsLauncher : ISoundSettingsLauncher
    {
        public async Task LaunchSoundSettingsAsync()
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("ms-settings:easeofaccess-audio"));
        }
    }
}