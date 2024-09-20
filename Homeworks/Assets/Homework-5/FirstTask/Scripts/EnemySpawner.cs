using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using Zenject;

namespace Homework_5
{
    public class EnemySpawner
    {
        private const string EnemySpawnerConfig = "EnemySpawnerConfig";
        private EnemySpawnerConfig _enemySpawnerConfig;

        private float _spawnCooldown;

        private List<Transform> _spawnPoints;

        private EnemyFactory _enemyFactory;

        private ICoroutinePerformer _coroutinePerformer;

        private Coroutine _spawn;


        public EnemySpawner(EnemyFactory enemyFactory, ICoroutinePerformer coroutinePerformer)
        {
            _enemyFactory = enemyFactory;
            _coroutinePerformer = coroutinePerformer;
            
            Load();
            SetConfig(_enemySpawnerConfig);
        }

        public void StartWork()
        {
            StopWork();

            _spawn = _coroutinePerformer.StartPerform(Spawn());
        }

        public void StopWork()
        {
            if (_spawn != null)
                _coroutinePerformer.StopPerform(_spawn);
        }
        
        public void SetSpawnPoints(List<Transform> spawnPoints)
        {
            _spawnPoints = spawnPoints;
        }

        private IEnumerator Spawn()
        {
            float time = 0;

            while (true)
            {
                while (time < _spawnCooldown)
                {

                    time += Time.deltaTime;

                    yield return null;
                }

                Enemy enemy =
                    _enemyFactory.Get((EnemyType)UnityEngine.Random.Range(0, Enum.GetValues(typeof(EnemyType)).Length));
                enemy.MoveTo(_spawnPoints[UnityEngine.Random.Range(0, _spawnPoints.Count)].position);
                time = 0;
            }
        }
        
        private void Load()
        {
            _enemySpawnerConfig = Resources.Load<EnemySpawnerConfig>(Path.Combine(EnemySpawnerConfig));
        }
        
        private void SetConfig(EnemySpawnerConfig enemySpawnerConfig)
        {
            _spawnCooldown = enemySpawnerConfig.SpawnCooldown;
        }
    }
}
