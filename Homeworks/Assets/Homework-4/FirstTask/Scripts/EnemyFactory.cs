using UnityEngine;

public abstract class EnemyFactory
{
    public abstract Paladin CreatePaladin(Transform spawnPoint);
    public abstract Mage CreateMage(Transform spawnPoint);
}
