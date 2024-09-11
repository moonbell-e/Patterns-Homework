using System.Collections.Generic;
using System.Linq;

public class ColoredBalloonsPoppedVictoryCondition : IVictoryCondition
{
    public bool CheckVictoryCondition(List<Balloon> balloons, Dictionary<EColor, int> poppedBalloonsCountByColor, int totalPoppedBalloons)
    {
        var colorGroups = balloons.GroupBy(balloon => balloon.Color);
        return colorGroups.Any(group => poppedBalloonsCountByColor.ContainsKey(group.Key) && poppedBalloonsCountByColor[group.Key] == group.Count());    }
}