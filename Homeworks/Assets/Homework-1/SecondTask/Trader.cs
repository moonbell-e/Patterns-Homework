using UnityEngine;

public class Trader : MonoBehaviour
{
    [SerializeField, Range(0, 50)] private int _requiredReputationArmor;
    [SerializeField, Range(0, 50)] private int _requiredReputationFruit;

    private ITradeStrategy _tradeStrategy;

    private void Awake()
    {
        _tradeStrategy = new NoTradeStrategy();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out IPlayerReputation reputation))
        {
            UpdateTradeStrategy(reputation.Reputation);
            _tradeStrategy.Trade();
        }
    }

    private void UpdateTradeStrategy(int playerReputation)
    {
        if (playerReputation >= _requiredReputationArmor)
        {
            _tradeStrategy = new ArmorTradeStrategy();
        }
        else if (playerReputation >= _requiredReputationFruit)
        {
            _tradeStrategy = new FruitTradeStrategy();
        }
        else
        {
            _tradeStrategy = new NoTradeStrategy();
        }
    }
}