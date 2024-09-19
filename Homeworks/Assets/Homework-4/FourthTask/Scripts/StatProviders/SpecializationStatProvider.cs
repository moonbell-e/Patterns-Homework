namespace Homework_4
{
    public class SpecializationStatProvider: IStatProvider
    {
        private readonly IStatProvider _baseStatProvider;
        private readonly SpecializationType _specializationType;

        public SpecializationStatProvider(IStatProvider baseStatProvider, SpecializationType specializationType)
        {
            _baseStatProvider = baseStatProvider;
            _specializationType = specializationType;
        }

        public Stats GetStats()
        {
            var stats = _baseStatProvider.GetStats();

            switch (_specializationType)
            {
                case SpecializationType.Rogue:
                    stats.AddStats(new Stats(0, 0, 5));
                    break;
                case SpecializationType.Mage:
                    stats.MultiplyStats(new Stats(1, 2, 1));
                    break;
                case SpecializationType.Barbarian:
                    stats.AddStats(new Stats(7, -1, 0));
                    break;
            }

            return stats;
        }
    }
}
