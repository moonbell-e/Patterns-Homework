using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Homework_3
{
    public class PlayerHud: MonoBehaviour
    {
        [SerializeField] private DefeatPanel _defeatPanel;
        [SerializeField] private Button _addLevelButton;
        [SerializeField] private Button _healButton;
        [SerializeField] private Button _damageButton;
        [SerializeField] private TextMeshProUGUI _levelText;
        [SerializeField] private TextMeshProUGUI _hpText;

        private PlayerMediator _mediator;
        private int _healValue;
        private int _damageValue;
        
        private void OnEnable()
        {
            _addLevelButton.onClick.AddListener(OnAddLevelClick);
            _healButton.onClick.AddListener(OnHealClick);
            _damageButton.onClick.AddListener(OnDamageClick);
        }

        private void OnDisable()
        {
            _addLevelButton.onClick.RemoveListener(OnAddLevelClick);
            _healButton.onClick.RemoveListener(OnHealClick);
            _damageButton.onClick.RemoveListener(OnDamageClick);
        }
        
        public void Initialize(PlayerMediator mediator, int healValue, int damageValue)
        {
            _mediator = mediator;
            _healValue = healValue;
            _damageValue = damageValue;
            _defeatPanel.Initialize(mediator);
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
            _mediator.AddLevel();
        }
        
        private void OnHealClick()
        {
            _mediator.Heal(_healValue);
        }
        
        private void OnDamageClick()
        {
            _mediator.TakeDamage(_damageValue);
        }
    }
}