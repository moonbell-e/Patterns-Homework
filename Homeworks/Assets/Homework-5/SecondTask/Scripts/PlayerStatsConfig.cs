using UnityEngine;

[CreateAssetMenu(fileName = "PlayerStatsConfig", menuName = "PlayerStats/PlayerStatsConfig")]
public class PlayerStatsConfig : ScriptableObject
{
    [SerializeField] private int _health;
    [SerializeField] private int _healValue;
    [SerializeField] private int _damageValue;

    public int Health => _health;
    public int HealValue => _healValue;
    public int DamageValue => _damageValue;
}
