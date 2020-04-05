using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Windows.Devices.Enumeration;
using Windows.Media.Audio;
using Windows.Media.Devices;

namespace SoundChecker.Uwp.Core.Services
{
    public class AudioDeviceManager : IAudioDeviceManager
    {
        private SpatialAudioDeviceConfiguration _currentDevice = null;

        public SpatialAudioDeviceConfiguration CurrentDevice => _currentDevice;

        public async Task InitializeAudioDeviceAsync()
        {
            var audioSelector = MediaDevice.GetAudioRenderSelector();
            var outputDevices = await DeviceInformation.FindAllAsync(audioSelector);

            var spatialAudioInformation = new List<SpatialAudioDeviceConfiguration>();
            foreach (var outputDevice in outputDevices)
            {
                var spatialAudioDevice = SpatialAudioDeviceConfiguration.GetForDeviceId(outputDevice.Id);
                spatialAudioInformation.Add(spatialAudioDevice);
            }

            var dupa = spatialAudioInformation;
            _currentDevice = SpatialAudioDeviceConfiguration.GetForDeviceId(outputDevices.First().Id);
        }
    }
}