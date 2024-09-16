using UnityEngine;

namespace Homework_2.FirstTask.Scripts.States
{
    public class WorkingState : NpcState
    {
        private float _workDuration;

        public WorkingState(Npc npc, NpcStateMachine npcStateMachine) : base(npc, npcStateMachine)
        {
        }

        public override void EnterState()
        {
            Debug.Log("Npc started working");
            _workDuration = npc.WorkDuration;
        }

        public override void ExitState()
        {
            Debug.Log("Npc has finished working");
        }

        public override void UpdateState()
        {
            _workDuration -= Time.deltaTime;

            if (_workDuration <= 0)
            {
                npc.SetDestination(npc.Home);
                npcStateMachine.SwitchState<WalkingState>();
            }
        }
    }
}