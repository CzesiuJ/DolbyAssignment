using System;
using Windows.Media.Audio;

namespace SoundChecker.Uwp.Core.Services
{
    public abstract class ConfigurationBase : IDolbyAvailabiltyChecker
    {
        private readonly IAudioDeviceManager _deviceManager;
        private SpatialAudioDeviceConfiguration _currentDevice;

        public ConfigurationBase(IAudioDeviceManager deviceManager)
        {
            _deviceManager = deviceManager;
            _currentDevice = _deviceManager.CurrentDevice;
            SubscribeToAudioEvents();
        }

        public event EventHandler<bool> DolbyAtmosAvailabilityChanged = delegate { };

        protected abstract string SpatialSoundSystemId { get; }

        public bool IsDolbyAtmosCurrentlySupported()
        {
            _currentDevice = _deviceManager.CurrentDevice;
            var isHeadphoneDolbyAtmosSupported = VerifyAtmosSupport(_currentDevice);
            return isHeadphoneDolbyAtmosSupported;
        }

        private void CurrentDeviceOnConfigurationChanged(SpatialAudioDeviceConfiguration sender, object args)
        {
            _currentDevice = sender;
            var atmosSupport = VerifyAtmosSupport(_currentDevice);
            DolbyAtmosAvailabilityChanged.Invoke(this, atmosSupport);
        }

        private void SubscribeToAudioEvents()
        {
            _currentDevice.ConfigurationChanged += CurrentDeviceOnConfigurationChanged;
        }

        private bool VerifyAtmosSupport(SpatialAudioDeviceConfiguration device)
        {
            return device.ActiveSpatialAudioFormat.Equals(SpatialSoundSystemId);
        }
    }
}