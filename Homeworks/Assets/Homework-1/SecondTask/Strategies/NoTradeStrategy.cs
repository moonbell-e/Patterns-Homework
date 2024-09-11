using UnityEngine;

public class NoTradeStrategy : ITradeStrategy
{
    public void Trade()
    {
        Debug.Log("Trader offers nothing.");
    }
}
