using UnityEngine;

public class RandomCoinFactory : CoinFactory
{
    public override Coin CreateCoin(Transform spawnPoint)
    {
        var randomCoinPrefab = Resources.Load<GameObject>("RandomCoin");
        var  randomCoinGo = Object.Instantiate(randomCoinPrefab, spawnPoint.position, Quaternion.identity);
        var  randomCoin =  randomCoinGo.GetComponent<EmptyCoin>();
        return  randomCoin;
    }
}
