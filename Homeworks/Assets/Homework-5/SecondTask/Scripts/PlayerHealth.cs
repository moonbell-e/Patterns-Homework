using System.IO;
using UnityEngine;

namespace Homework_5.SecondTask
{
    public class PlayerHealth: IHealth
    {
        private const string StatsConfigPath = "PlayerStatsConfig";

        public int CurrentHealth { get; private set; }
        public int MaxHealth { get;  private set;}

        private readonly PlayerMediator _mediator;
        private PlayerStatsConfig _playerStatsConfig;
        public PlayerHealth(PlayerMediator mediator)
        {
            _mediator = mediator; 
            
            Load();
            SetConfigValues();
        }
        
        public void TakeDamage(int damage)
        {
            CurrentHealth -= damage;
            _mediator.OnHealthChanged(CurrentHealth);
            
            if (CurrentHealth <= 0)
            {
                _mediator.OnPlayerDied();
            }
        }

        public void Heal(int healAmount)
        {
            CurrentHealth += healAmount;
            _mediator.OnHealthChanged(CurrentHealth);
        }

        public void ResetHealth()
        {
            CurrentHealth = MaxHealth;
            _mediator.OnHealthChanged(CurrentHealth);
        }
        
        private void Load()
        {
            _playerStatsConfig = Resources.Load<PlayerStatsConfig>(Path.Combine(StatsConfigPath));
        }

        private void SetConfigValues()
        {
            MaxHealth = _playerStatsConfig.Health;
            CurrentHealth = MaxHealth;
            
            _mediator.OnHealthChanged(CurrentHealth);
        }
    }
}