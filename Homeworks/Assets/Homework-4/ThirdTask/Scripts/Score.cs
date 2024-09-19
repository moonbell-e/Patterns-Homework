using UnityEngine;

namespace Homework4
{
    public class Score
    {
        public int Value => _enemyVisitor.Score;

        private readonly EnemyVisitor _enemyVisitor;

        public Score(IEnemyDeathNotifier deathNotifier)
        {
            deathNotifier.Notified += OnEnemyKilled;

            _enemyVisitor = new EnemyVisitor();
        }

        public void OnEnemyKilled(Enemy enemy)
        {
            enemy.Accept(_enemyVisitor);
            Debug.Log($"Счет: {Value}");
        }

        private class EnemyVisitor : IEnemyVisitor
        {
            public int Score { get; private set; }

            public void Visit(Orc ork) => Score += 20;

            public void Visit(Human human) => Score += 5;

            public void Visit(Elf elf) => Score += 10;

            public void Visit(Robot robot) => Score += 25;
        }
    }
}