using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints;
    
    private readonly HashSet<int> _occupiedSpawnPoints = new();
    private CoinFactory _coinFactory;
    
    public void SetFactory(CoinFactory coinFactory)
    {
        _coinFactory = coinFactory;
    }
    
    public void SpawnCoin()
    {
        if (_coinFactory == null)
        {
            Debug.LogError("Coin factory is not set");
            return;
        }
        
        if (_occupiedSpawnPoints.Count == _spawnPoints.Length)
        {
            Debug.LogWarning("No free spawn points available!");
            return;
        }
        
        int spawnPointIndex = GetRandomSpawnPointIndex();
        _coinFactory.CreateCoin(_spawnPoints[spawnPointIndex]);
        _occupiedSpawnPoints.Add(spawnPointIndex);
    }

    private int GetRandomSpawnPointIndex()
    {
        int attempts = 0;
        while (attempts < 100)
        {
            var randomIndex = Random.Range(0, _spawnPoints.Length);

            if (!_occupiedSpawnPoints.Contains(randomIndex))
            {
                return randomIndex;
            }

            attempts++;
        }

        return -1;
    }
}
