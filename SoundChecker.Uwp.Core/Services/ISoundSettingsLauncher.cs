using System.Threading.Tasks;

namespace SoundChecker.Uwp.Core.Services
{
    public interface ISoundSettingsLauncher
    {
        Task LaunchSoundSettingsAsync();
    }
}