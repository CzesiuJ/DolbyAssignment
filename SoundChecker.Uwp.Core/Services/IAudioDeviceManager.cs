using System.Collections.Generic;
using System.Threading.Tasks;
using Windows.Media.Audio;

namespace SoundChecker.Uwp.Core.Services
{
    public interface IAudioDeviceManager
    {
        SpatialAudioDeviceConfiguration CurrentDevice { get; }

        Task InitializeAudioDeviceAsync();
    }
}