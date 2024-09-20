using UnityEngine;

namespace Homework_5
{
    [CreateAssetMenu(fileName = "EnemySpawnerConfig", menuName = "EnemyConfigs/EnemySpawnerConfig")]
    public class EnemySpawnerConfig : ScriptableObject
    {
        [SerializeField] private float _spawnCooldown;
        public float SpawnCooldown  => _spawnCooldown;
    }
}