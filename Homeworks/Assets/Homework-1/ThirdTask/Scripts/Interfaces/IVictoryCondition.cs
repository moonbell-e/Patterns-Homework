using System.Collections.Generic;

public interface IVictoryCondition
{
    public bool CheckVictoryCondition(List<Balloon> balloons, Dictionary<EColor, int> poppedBalloonsCountByColor, int totalPoppedBalloons);
}
