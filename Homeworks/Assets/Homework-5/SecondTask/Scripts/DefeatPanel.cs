using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Homework_5.SecondTask
{
    [RequireComponent(typeof(Button))]
    public class DefeatPanel : MonoBehaviour
    {
        [SerializeField] private Button _restart;

        private PlayerMediator _mediator;

        private void OnEnable()
        {
            _restart.onClick.AddListener(OnRestartClick);
        }

        private void OnDisable()
        {
            _restart.onClick.RemoveListener(OnRestartClick);
        }

        [Inject]
        private void Construct(PlayerMediator mediator)
        {
            _mediator = mediator;
        }
        
        public void Show() => gameObject.SetActive(true);
        public void Hide() => gameObject.SetActive(false);

        private void OnRestartClick() => _mediator.RestartGame();
    }
}