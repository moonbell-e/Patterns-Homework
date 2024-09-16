namespace Homework_3.Interfaces
{
    public interface IHealth
    {
        public int CurrentHealth { get; }
        public int MaxHealth { get; }
        
        public void TakeDamage(int damage);
        public void Heal(int healAmount);
    }
}