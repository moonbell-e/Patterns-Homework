using Homework_3.Interfaces;

namespace Homework_3
{
    public class PlayerHealth: IHealth
    {
        public int CurrentHealth { get; private set; }
        public int MaxHealth { get; }

        private readonly PlayerMediator _mediator;
        
        public PlayerHealth(int maxHealth, PlayerMediator mediator)
        {
            MaxHealth = maxHealth;
            CurrentHealth = MaxHealth;
            _mediator = mediator;
            
            _mediator.OnHealthChanged(CurrentHealth);
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
    }
}