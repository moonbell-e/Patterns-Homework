using System;
using UnityEngine;

namespace Homework4
{
    [CreateAssetMenu(fileName = "EnemyFactory", menuName = "EnemyFactory")]
    public class EnemyFactory : ScriptableObject
    {
        [SerializeField] private Human _humanPrefab;
        [SerializeField] private Orc _orcPrefab;
        [SerializeField] private Elf _elfPrefab;
        [SerializeField] private Robot _robotPrefab;

        public Enemy GetEnemy(EnemyType type)
        {
            switch (type)
            {
                case EnemyType.Elf:
                    return Instantiate(_elfPrefab);

                case EnemyType.Human:
                    return Instantiate(_humanPrefab);

                case EnemyType.Orc:
                    return Instantiate(_orcPrefab);

                case EnemyType.Robot:
                    return Instantiate(_robotPrefab);
            }

            throw new InvalidOperationException();
        }
    }
}