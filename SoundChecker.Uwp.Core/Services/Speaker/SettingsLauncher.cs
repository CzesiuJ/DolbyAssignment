using System.Threading.Tasks;
using SoundChecker.Core.Services.Speaker;

namespace SoundChecker.Uwp.Core.Services.Speaker
{
    public class SettingsLauncher : ISoundSettingsLauncher
    {
        public Task LanuchSoundSettingsAsync()
        {
            return Task.CompletedTask;
        }
    }
}