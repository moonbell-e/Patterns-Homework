using UnityEngine;

namespace Homework_4
{
    public class CharacterConfigurator : MonoBehaviour
    {
        [SerializeField] private Character _character;
        
        private IStatProvider _stateProvider;
        
        private void Awake()
        {
            _stateProvider = new BaseStatProvider(new Stats(2, 2, 2));

            _stateProvider = new RaceStatProvider(_stateProvider, RaceType.Elf);
            _stateProvider = new SpecializationStatProvider(_stateProvider, SpecializationType.Mage);
            _stateProvider = new PassiveAbilityStatProvider(_stateProvider, PassiveAbilityType.Vampirism);

            _character.Initialize(_stateProvider);

            var stats = _character.GetStats();
            Debug.Log(stats);
        }
    }
}
