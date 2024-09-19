namespace Homework_4
{
    public class PassiveAbilityStatProvider : IStatProvider
    {
        private readonly IStatProvider _baseStatProvider;
        private readonly PassiveAbilityType _passiveAbilityType;

        public PassiveAbilityStatProvider(IStatProvider baseStatProvider, PassiveAbilityType passiveAbilityType)
        {
            _baseStatProvider = baseStatProvider;
            _passiveAbilityType = passiveAbilityType;
        }

        public Stats GetStats()
        {
            var stats = _baseStatProvider.GetStats();

            switch (_passiveAbilityType)
            {
                case PassiveAbilityType.Vampirism:
                    stats.MultiplyStats(new Stats(3, 1, 1));
                    break;
                case PassiveAbilityType.CriticalStrike:
                    stats.AddStats(new Stats(0, 0, 4));
                    break;
                case PassiveAbilityType.DamageReduction:
                    stats.AddStats(new Stats(0, 3, 0));
                    break;
            }

            return stats;
        }
    }
}