using UnityEngine;
using UnityEngine.AI;

namespace Homework_2.FirstTask.Scripts.States
{
    public class WalkingState : NpcState
    {
        private readonly NavMeshAgent _navMeshAgent;

        public WalkingState(Npc npc, NpcStateMachine npcStateMachine) : base(npc, npcStateMachine)
        {
            _navMeshAgent = npc.NavMeshAgent;
        }

        public override void EnterState()
        {
            Debug.Log("Npc started their walk");
            _navMeshAgent.SetDestination(npc.CurrentDestination);
        }

        public override void ExitState()
        {
            Debug.Log("Npc has reached their destination");
        }

        public override void UpdateState()
        {
            if (npc.HasReachedDestination())
            {
                if (npc.CurrentDestination == npc.Workplace)
                {
                    npcStateMachine.SwitchState<WorkingState>();
                }
                else
                {
                    npcStateMachine.SwitchState<RestingState>();
                }
            }
        }
    }
}
