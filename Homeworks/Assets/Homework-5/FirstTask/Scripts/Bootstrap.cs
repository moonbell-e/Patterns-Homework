using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Homework_5
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private List<Transform> _spawnPoints;
        private EnemySpawner _spawner;

        [Inject]
        private void Construct(EnemySpawner enemySpawner)
        {
            _spawner = enemySpawner;
            _spawner.SetSpawnPoints(_spawnPoints);
        }

        private void Awake()
        {
            _spawner.StartWork();
        }
    }
}