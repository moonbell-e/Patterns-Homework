using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Homework4
{
    public class Spawner : MonoBehaviour, IEnemyDeathNotifier
    {
        public event Action<Enemy> Notified;

        [SerializeField] private float _spawnCooldown;
        [SerializeField] private List<Transform> _spawnPoints;
        [SerializeField] private EnemyFactory _enemyFactory;
        [SerializeField] private float _weightLimit; 

        private readonly List<Enemy> _spawnedEnemies = new();

        private Coroutine _spawn;

        private void Start()
        {
            StartWork();
        }

        private void StartWork()
        {
            StopWork();

            _spawn = StartCoroutine(Spawn());
        }

        private void StopWork()
        {
            if (_spawn != null)
                StopCoroutine(_spawn);
        }

        public void KillRandomEnemy()
        {
            if (_spawnedEnemies.Count == 0)
                return;

            _spawnedEnemies[Random.Range(0, _spawnedEnemies.Count)].Kill();
        }

        private IEnumerator Spawn()
        {
            while (true)
            {
                EnemyWeightVisitor weightVisitor = new EnemyWeightVisitor();
                
                foreach (var spawnedEnemy in _spawnedEnemies)
                {
                    spawnedEnemy.Accept(weightVisitor);
                }
                
                if (weightVisitor.TotalWeight >= _weightLimit)
                {
                    Debug.Log("Weight limit reached! Stop spawn");
                    StopWork();
                    yield break;
                }
                
                Enemy enemy =
                    _enemyFactory.GetEnemy((EnemyType)Random.Range(0, Enum.GetValues(typeof(EnemyType)).Length));
                enemy.MoveTo(_spawnPoints[Random.Range(0, _spawnPoints.Count)].position);
                enemy.Died += OnEnemyDied;
                _spawnedEnemies.Add(enemy);
                yield return new WaitForSeconds(_spawnCooldown);
            }
        }

        private void OnEnemyDied(Enemy enemy)
        {
            Notified?.Invoke(enemy);
            enemy.Died -= OnEnemyDied;
            _spawnedEnemies.Remove(enemy);
        }
    }
}