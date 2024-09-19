using UnityEngine;

public class StandardCoinFactory : CoinFactory
{
    public override Coin CreateCoin(Transform spawnPoint)
    {
        var standardCoinPrefab = Resources.Load<GameObject>("StandardCoin");
        var standardCoinGo = Object.Instantiate(standardCoinPrefab, spawnPoint.position, Quaternion.identity);
        var standardCoin = standardCoinGo.GetComponent<EmptyCoin>();
        return standardCoin;
    }
}
