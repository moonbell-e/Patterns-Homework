using System;

namespace Homework_5.SecondTask
{
    public interface IPlayerEvents
    {
        public event Action<int> HealthChanged;
        public event Action<int> LevelChanged;
    }
}