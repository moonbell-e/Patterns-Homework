using System;
using UnityEngine;
using Zenject;

namespace Homework_5.SecondTask
{
    public class Player: MonoBehaviour, IPlayerEvents, IPlayerStatsChanger
    {
        public event Action<int> HealthChanged;
        public event Action<int> LevelChanged;
        
        private PlayerHealth _health;
        private PlayerLevel _level;

        [Inject]
        private void Construct(PlayerHealth health, PlayerLevel level)
        {
            _health = health;
            _level = level;
        }
        
        public void TakeDamage(int damage)
        {
            _health.TakeDamage(damage);
            
            HealthChanged?.Invoke(_health.CurrentHealth);
        }
        
        public void Heal(int healAmount)
        {
            _health.Heal(healAmount);
            
            HealthChanged?.Invoke(_health.CurrentHealth);
        }
        
        public void AddLevel()
        {
            _level.AddLevel();
            
            LevelChanged?.Invoke(_level.CurrentLevel);
        }

        public void ResetPlayer()
        {
            _health.ResetHealth();
            _level.ResetLevel();
        }
    }
}
