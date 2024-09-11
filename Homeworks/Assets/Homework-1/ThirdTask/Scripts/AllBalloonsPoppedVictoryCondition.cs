using System.Collections.Generic;

public class AllBalloonsPoppedVictoryCondition : IVictoryCondition
{
    public bool CheckVictoryCondition(List<Balloon> balloons, Dictionary<EColor, int> poppedBalloonsCountByColor, int totalPoppedBalloons)
    {
        return totalPoppedBalloons == balloons.Count;
    }
}
