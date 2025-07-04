using System;

namespace Gladiators.Gameplay
{
    public interface ITimeService
    {
        float DeltaTime { get; }
        float FixedDeltaTime { get; }
        DateTime UtcNow { get; }
        void StopTime();
        void StartTime();
    }
}