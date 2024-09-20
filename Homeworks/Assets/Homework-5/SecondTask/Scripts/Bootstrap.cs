using UnityEngine;

namespace Homework_5.SecondTask
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private int _healValue;
        [SerializeField] private int _damageValue;
        [SerializeField] private PlayerHud _playerHud;
        [SerializeField] private Player _player;

        private PlayerMediator _playerMediator;
        private PlayerHealth _playerHealth;
        private PlayerLevel _playerLevel;

        private void Start()
        {
            _playerMediator = new PlayerMediator(_player, _playerHud);
            
            _playerHealth = new PlayerHealth(_playerMediator);
            _playerLevel = new PlayerLevel(_playerMediator);
            
            // _player.Initialize(_playerHealth, _playerLevel);
            // _playerHud.Initialize(_playerMediator, _healValue, _damageValue);
        }
    }
}