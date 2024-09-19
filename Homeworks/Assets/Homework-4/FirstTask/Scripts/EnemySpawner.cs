using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints;

    private EnemyFactory _enemyFactory;
    private Func<Transform, Enemy>[] _enemyCreators = { };

    public void SetFactory(EnemyFactory enemyFactory)
    {
        _enemyFactory = enemyFactory;

        _enemyCreators = new Func<Transform, Enemy>[]
        {
            _enemyFactory.CreatePaladin,
            _enemyFactory.CreateMage,
        };
    }

    public void SpawnRandomEnemy()
    {
        var spawnPointIndex = Random.Range(0, _spawnPoints.Length);
        var spawnPoint = _spawnPoints[spawnPointIndex];

        var createEnemy = _enemyCreators[Random.Range(0, _enemyCreators.Length)];
        var enemy = createEnemy(spawnPoint);

        EnemyAttack(enemy);
    }

    public EnemyFactory GetFactory()
    {
        return _enemyFactory;
    }

    private void EnemyAttack(Enemy enemy)
    {
        switch (enemy)
        {
            case Paladin paladin:
                paladin.Attack();
                break;
            case Mage mage:
                mage.CastSpell();
                break;
        }
    }
}