using UnityEngine;

namespace Homework_3
{
    public class Player: MonoBehaviour
    {
        [SerializeField] private int _healthAmount;

        public int Health => _healthAmount;
        
        private PlayerHealth _health;
        private PlayerLevel _level;

        public void Initialize(PlayerHealth health, PlayerLevel level)
        {
            _health = health;
            _level = level;
        }
        
        public void TakeDamage(int damage)
        {
            _health.TakeDamage(damage);
        }
        
        public void Heal(int healAmount)
        {
            _health.Heal(healAmount);
        }
        
        public void LevelUp()
        {
            _level.AddLevel();
        }

        public void ResetPlayer()
        {
            _health.ResetHealth();
            _level.ResetLevel();
        }
    }
}
