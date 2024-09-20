using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Homework_5.SecondTask
{
    public class PlayerHud : MonoBehaviour
    {
        private const string StatsConfigPath = "PlayerStatsConfig";
        
        [SerializeField] private DefeatPanel _defeatPanel;
        [SerializeField] private Button _addLevelButton;
        [SerializeField] private Button _healButton;
        [SerializeField] private Button _damageButton;
        [SerializeField] private TextMeshProUGUI _levelText;
        [SerializeField] private TextMeshProUGUI _hpText;

        private IPlayerEvents _playerEvents;
        private IPlayerStatsChanger _playerStatsChanger;
        private int _healValue;
        private int _damageValue;
        
        private PlayerStatsConfig _playerStatsConfig;

        private void OnEnable()
        {
            _addLevelButton.onClick.AddListener(OnAddLevelClick);
            _healButton.onClick.AddListener(OnHealClick);
            _damageButton.onClick.AddListener(OnDamageClick);
            
            _playerEvents.HealthChanged += UpdateHealth;
            _playerEvents.LevelChanged += UpdateLevel;
        }

        private void OnDisable()
        {
            _addLevelButton.onClick.RemoveListener(OnAddLevelClick);
            _healButton.onClick.RemoveListener(OnHealClick);
            _damageButton.onClick.RemoveListener(OnDamageClick);
            
            _playerEvents.HealthChanged -= UpdateHealth;
            _playerEvents.LevelChanged -= UpdateLevel;
        }

        [Inject]
        private void Construct(IPlayerEvents playerEvents, IPlayerStatsChanger playerStatsChanger)
        {
            _playerEvents = playerEvents;
            _playerStatsChanger = playerStatsChanger;

            Load();
            SetConfigValues();
        }

        public void UpdateHealth(int health)
        {
            _hpText.text = health.ToString();
        }

        public void UpdateLevel(int level)
        {
            _levelText.text = level.ToString();
        }

        public void ShowDefeatPanel()
        {
            _defeatPanel.Show();
        }

        public void HideDefeatPanel()
        {
            _defeatPanel.Hide();
        }

        private void OnAddLevelClick()
        {
            _playerStatsChanger.AddLevel();
        }

        private void OnHealClick()
        {
            _playerStatsChanger.Heal(_healValue);
        }

        private void OnDamageClick()
        {
            _playerStatsChanger.TakeDamage(_damageValue);
        }

        private void Load()
        {
            _playerStatsConfig = Resources.Load<PlayerStatsConfig>(Path.Combine(StatsConfigPath));
        }

        private void SetConfigValues()
        {
            _healValue = _playerStatsConfig.HealValue;
            _damageValue = _playerStatsConfig.DamageValue;
        }
    }
}