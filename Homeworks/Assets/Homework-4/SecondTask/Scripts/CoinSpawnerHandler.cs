using UnityEngine;

public class CoinSpawnerHandler : MonoBehaviour
{
    [SerializeField] private CoinSpawner _spawner;
    
    private void Start()
    {
        _spawner.SetFactory(new StandardCoinFactory());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _spawner.SpawnCoin();
        }
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            _spawner.SetFactory(new EmptyCoinFactory());
        }
        
        if (Input.GetKeyDown(KeyCode.R))
        {
            _spawner.SetFactory(new RandomCoinFactory());
        }
        
        if (Input.GetKeyDown(KeyCode.S))
        {
            _spawner.SetFactory(new StandardCoinFactory());
        }
    }
}
