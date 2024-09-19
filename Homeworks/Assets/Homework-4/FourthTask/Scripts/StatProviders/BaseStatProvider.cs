namespace Homework_4
{
    public class BaseStatProvider : IStatProvider
    {
        private readonly Stats _baseStats;

        public BaseStatProvider(Stats baseStats)
        {
            _baseStats = baseStats;
        }

        public Stats GetStats()
        {
            return _baseStats;
        }
    }
}