using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class VictoryConditionHandler : MonoBehaviour
{
    [SerializeField] private List<Balloon> _balloons;
    private IEnumerable<IGrouping<EColor,Balloon>> _coloredBalloons;

    private IVictoryCondition _victoryCondition;
    private int _totalPoppedBalloons = 0;

    private readonly Dictionary<EColor, int> _poppedBalloonsCountByColor = new();

    private void OnEnable()
    {
        foreach (var balloon in _balloons)
        {
            balloon.OnBalloonPopped += CheckVictory;
        }
    }

    private void OnDisable()
    {
        foreach (var balloon in _balloons)
        {
            balloon.OnBalloonPopped -= CheckVictory;
        }
    }

    public void SetVictoryCondition(IVictoryCondition condition)
    {
        _victoryCondition = condition;
    }

    private void CheckVictory(Balloon balloon)
    {
        if (_victoryCondition == null)
            Debug.LogError("No victory condition set!");
        else
        {
            _poppedBalloonsCountByColor.TryAdd(balloon.Color, 0);
            _poppedBalloonsCountByColor[balloon.Color]++;
            _totalPoppedBalloons++;
            
            if (_victoryCondition != null && _victoryCondition.CheckVictoryCondition(_balloons, _poppedBalloonsCountByColor, _totalPoppedBalloons))
            {
                Debug.Log("Victory!");
                _poppedBalloonsCountByColor[balloon.Color] = 0;
            }
            
            Destroy(balloon.gameObject);
        }
    }
}