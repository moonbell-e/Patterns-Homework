using UnityEngine;
using UnityEngine.AI;

public class Npc : MonoBehaviour, IMovable
{
    [SerializeField] private float _workDuration;
    [SerializeField] private float _restDuration;
    [SerializeField] private Transform _workplace;
    [SerializeField] private Transform _home;

    private NpcStateMachine _npcStateMachine;

    public NavMeshAgent NavMeshAgent { get; private set; }
    public Vector3 CurrentDestination { get; private set; }

    public float WorkDuration => _workDuration;
    public float RestDuration => _restDuration;
    public Vector3 Workplace => _workplace.position;
    public Vector3 Home => _home.position;

    private void Awake()
    {
        NavMeshAgent = GetComponent<NavMeshAgent>();
        CurrentDestination = Workplace;
        _npcStateMachine = new NpcStateMachine(this);
    }


    private void Update()
    {
        _npcStateMachine.Update();
    }

    public void SetDestination(Vector3 destination)
    {
        CurrentDestination = destination;
    }

    public bool HasReachedDestination()
    {
        var distanceToDestination = Vector3.Distance(transform.position, CurrentDestination);
        return !NavMeshAgent.pathPending && (NavMeshAgent.remainingDistance <= NavMeshAgent.stoppingDistance ||
                                             distanceToDestination <= NavMeshAgent.stoppingDistance);
    }
}