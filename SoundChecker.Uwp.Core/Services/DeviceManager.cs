using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Windows.Devices.Enumeration;
using Windows.Media.Devices;
using SoundChecker.Uwp.Core.Models;

namespace SoundChecker.Uwp.Core.Services
{
    public class DeviceManager : IDeviceManager
    {
        public async Task<IEnumerable<AudioDevice>> GetAvailableDevicesAsync()
        {
            string audioSelector = MediaDevice.GetAudioRenderSelector();
            var outputDevices = await DeviceInformation.FindAllAsync(audioSelector);
            var devices = MapDevices(outputDevices);
            return devices;
        }

        private IEnumerable<AudioDevice> MapDevices(DeviceInformationCollection outputDevices)
        {
            var deviceList = new List<AudioDevice>();

            foreach (var outputDevice in outputDevices)
            {
                var device = new AudioDevice();
                device.DeviceId = outputDevice.Id;
                device.DeviceName = outputDevice.Name;
                deviceList.Add(device);
            }

            return deviceList;
        }
    }
}