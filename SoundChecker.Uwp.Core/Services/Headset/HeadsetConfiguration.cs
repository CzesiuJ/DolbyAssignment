using Windows.Media.Audio;

namespace SoundChecker.Uwp.Core.Services.Headset
{
    public class HeadsetConfiguration : ConfigurationBase, IHeadsetConfiguration
    {
        public HeadsetConfiguration(IAudioDeviceManager deviceManager) : base(deviceManager)
        {
        }

        protected override string SpatialSoundSystemId => SpatialAudioFormatSubtype.DolbyAtmosForHeadphones;
    }
}