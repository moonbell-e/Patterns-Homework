using UnityEngine;

public abstract class CoinFactory
{
    public abstract Coin CreateCoin(Transform spawnPoint);
}
