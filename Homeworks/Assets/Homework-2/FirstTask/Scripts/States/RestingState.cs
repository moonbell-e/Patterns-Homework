using UnityEngine;

namespace Homework_2.FirstTask.Scripts.States
{
    public class RestingState : NpcState
    {
        private float _restDuration;

        public RestingState(Npc npc, NpcStateMachine npcStateMachine) : base(npc, npcStateMachine)
        {
        }

        public override void EnterState()
        {
            Debug.Log("Npc started resting");
            _restDuration = npc.RestDuration;
        }

        public override void ExitState()
        {
            Debug.Log("Npc has finished resting");
        }

        public override void UpdateState()
        {
            _restDuration -= Time.deltaTime;

            if (_restDuration <= 0)
            {
                npc.SetDestination(npc.Workplace);
                npcStateMachine.SwitchState<WalkingState>();
            }
        }
    }
}
