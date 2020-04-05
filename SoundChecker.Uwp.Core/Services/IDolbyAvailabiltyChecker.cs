using System;

namespace SoundChecker.Uwp.Core.Services
{
    public interface IDolbyAvailabiltyChecker
    {
        event EventHandler<bool> DolbyAtmosAvailabilityChanged;

        bool IsDolbyAtmosCurrentlySupported();
    }
}