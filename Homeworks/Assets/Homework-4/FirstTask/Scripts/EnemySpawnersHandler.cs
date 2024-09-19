using UnityEngine;
using UnityEngine.UI;

public class EnemySpawnersHandler : MonoBehaviour
{
    [SerializeField] private EnemySpawner _firstFactory;
    [SerializeField] private EnemySpawner _secondFactory;
    [SerializeField] private Button _changeFactoriesButton;

    private void Awake()
    {
        _changeFactoriesButton.onClick.AddListener(ChangeFactories);
    }

    private void OnDestroy()
    {
        _changeFactoriesButton.onClick.RemoveListener(ChangeFactories);
    }

    private void Start()
    {
        _firstFactory.SetFactory(new OrcFactory());
        _secondFactory.SetFactory(new ElfFactory());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _firstFactory.SpawnRandomEnemy();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _secondFactory.SpawnRandomEnemy();
        }
    }

    private void ChangeFactories()
    {
        var tempFactory = _firstFactory.GetFactory();
        _firstFactory.SetFactory(_secondFactory.GetFactory());
        _secondFactory.SetFactory(tempFactory);
    }
}