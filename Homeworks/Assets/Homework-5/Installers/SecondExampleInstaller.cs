using UnityEngine;
using Zenject;

namespace Homework_5.SecondTask
{
    public class SecondExampleInstaller : MonoInstaller
    {
        private const string PlayerPrefabPath = "Player";

        [SerializeField] private PlayerHud _playerHud;
        
        public override void InstallBindings()
        {
            BindMediator();
            BindHealth();
            BindLevel();
            
            BindInstance();
            BindHUD();
        }

        private void BindHUD()
        {
            Container.Bind<PlayerHud>().FromInstance(_playerHud).AsSingle();
        }
        
        private void BindInstance()
        {
            Container.BindInterfacesAndSelfTo<Player>().FromComponentInNewPrefabResource(PlayerPrefabPath).AsSingle().NonLazy();
        }

        private void BindMediator()
        {
            Container.Bind<PlayerMediator>().AsSingle();
        }

        private void BindHealth()
        {
            Container.Bind<PlayerHealth>().AsSingle();
        }

        private void BindLevel()
        {
            Container.Bind<PlayerLevel>().AsSingle();
        }
    }
}
