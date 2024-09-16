namespace Homework_3
{
    public class PlayerMediator
    {
        private readonly Player _player;
        private readonly PlayerHud _hud;
        
        public PlayerMediator(Player player, PlayerHud hud)
        {
            _player = player;
            _hud = hud;
        }

        public void OnHealthChanged(int health)
        {
            _hud.UpdateHealth(health);
        }
        
        public void OnLevelChanged(int level)
        {
            _hud.UpdateLevel(level);
        }
        
        public void Heal(int health)
        {
            _player.Heal(health);
        }
        
        public void TakeDamage(int damage)
        {
            _player.TakeDamage(damage);
        }
        
        public void AddLevel()
        {
            _player.LevelUp();
        }
        
        public void OnPlayerDied()
        {
            _hud.ShowDefeatPanel();
        }

        public void RestartGame()
        {
            _player.ResetPlayer();
            _hud.HideDefeatPanel();
        }
    }
}