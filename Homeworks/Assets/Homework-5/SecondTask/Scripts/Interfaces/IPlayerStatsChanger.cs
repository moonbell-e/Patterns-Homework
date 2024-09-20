namespace Homework_5.SecondTask
{
    public interface IPlayerStatsChanger
    {
        public void Heal(int health);
        public void TakeDamage(int damage);
        public void AddLevel();
    }
}