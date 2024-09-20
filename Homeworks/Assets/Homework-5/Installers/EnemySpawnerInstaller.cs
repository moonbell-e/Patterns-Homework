using Zenject;

namespace Homework_5
{
    public class EnemySpawnerInstaller: MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<EnemyFactory>().AsSingle();
            Container.Bind<EnemySpawner>().AsSingle();
        }
    }
}