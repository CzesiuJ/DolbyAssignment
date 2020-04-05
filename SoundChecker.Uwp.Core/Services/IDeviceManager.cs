using System.Collections.Generic;
using System.Threading.Tasks;
using SoundChecker.Uwp.Core.Models;

namespace SoundChecker.Uwp.Core.Services
{
    public interface IDeviceManager
    {
        Task<IEnumerable<AudioDevice>> GetAvailableDevicesAsync();
    }
}