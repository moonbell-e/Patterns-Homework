using UnityEngine;

public class EmptyCoinFactory : CoinFactory
{
    public override Coin CreateCoin(Transform spawnPoint)
    {
        var emptyCoinPrefab = Resources.Load<GameObject>("EmptyCoin");
        var emptyCoinGo = Object.Instantiate(emptyCoinPrefab, spawnPoint.position, Quaternion.identity);
        var emptyCoin = emptyCoinGo.GetComponent<EmptyCoin>();
        return emptyCoin;
    }
}
