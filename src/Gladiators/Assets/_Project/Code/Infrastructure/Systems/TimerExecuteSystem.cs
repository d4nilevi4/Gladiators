using Entitas;
using Gladiators.Gameplay;

namespace Gladiators.Infrastructure
{
    public abstract class TimerExecuteSystem : IExecuteSystem
    {
        private readonly float _executeIntervalSeconds;
        private readonly ITimeService _time;
        private float _timeToExecute;

        protected TimerExecuteSystem(float executeIntervalSeconds, ITimeService time)
        {
            _executeIntervalSeconds = executeIntervalSeconds;
            _time = time;
        }

        protected abstract void Execute();

        void IExecuteSystem.Execute()
        {
            _timeToExecute -= _time.DeltaTime;
            if (_timeToExecute > 0)
                return;

            _timeToExecute = _executeIntervalSeconds;

            Execute();
        }
    }
}