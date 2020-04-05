using Windows.Media.Audio;

namespace SoundChecker.Uwp.Core.Services.Speaker
{
    public class SpeakerConfiguration : ConfigurationBase, ISpeakerConfiguration
    {
        public SpeakerConfiguration(IAudioDeviceManager deviceManager) : base(deviceManager)
        {
        }

        protected override string SpatialSoundSystemId => SpatialAudioFormatSubtype.DolbyAtmosForHomeTheater;
    }
}