using UnityEngine.AI;
using UnityEngine;

public interface IMovable
{
    public NavMeshAgent NavMeshAgent { get; }
    public Vector3 CurrentDestination { get; }
}
