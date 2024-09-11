using UnityEngine;

public class Player : MonoBehaviour, IPlayerReputation
{
    [field: SerializeField, Range(0, 50)] public int Reputation { get; private set; }
}
