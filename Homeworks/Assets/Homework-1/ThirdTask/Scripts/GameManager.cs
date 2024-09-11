using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private VictoryConditionHandler _victoryConditionHandler;
    [SerializeField] private Button _allBalloonsPoppedButton;
    [SerializeField] private Button _coloredBalloonsPoppedButton;
    
    private void Start()
    {
        _allBalloonsPoppedButton.onClick.AddListener(SetAllBalloonsPopped);
        _coloredBalloonsPoppedButton.onClick.AddListener(SetColoredBalloonsPopped);
    }
    
    private void SetAllBalloonsPopped()
    {
        _victoryConditionHandler.SetVictoryCondition(new AllBalloonsPoppedVictoryCondition());
    }
    
    private void SetColoredBalloonsPopped()
    {
        _victoryConditionHandler.SetVictoryCondition(new ColoredBalloonsPoppedVictoryCondition());
    }
}
