using UnityEngine;

[CreateAssetMenu(menuName = "Configs/CharacterConfig", fileName = "CharacterConfig")]
public class CharacterConfig : ScriptableObject
{
    [field: SerializeField] public MovingStateConfig MovingStateConfig { get; private set; }
    [field: SerializeField] public AirbornStateConfig AirbornStateConfig { get; private set; }
}
