namespace Homework_4
{
    public class RaceStatProvider : IStatProvider
    {
        private readonly IStatProvider _baseStatProvider;
        private readonly RaceType _raceType;

        public RaceStatProvider(IStatProvider baseStatProvider, RaceType raceType)
        {
            _baseStatProvider = baseStatProvider;
            _raceType = raceType;
        }

        public Stats GetStats()
        {
            var stats = _baseStatProvider.GetStats();

            switch (_raceType)
            {
                case RaceType.Orc:
                    stats.AddStats(new Stats(5, 0, -2));
                    break;
                case RaceType.Elf:
                    stats.AddStats(new Stats(0, 2, 3));
                    break;
                case RaceType.Human:
                    stats.AddStats(new Stats(1, 1, 1));
                    break;
            }

            return stats;
        }
    }
}