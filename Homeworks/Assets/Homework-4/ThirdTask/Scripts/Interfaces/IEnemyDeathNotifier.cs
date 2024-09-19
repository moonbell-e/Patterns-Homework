using System;

namespace Homework4
{
    public interface IEnemyDeathNotifier
    {
        event Action<Enemy> Notified;
    }
}
