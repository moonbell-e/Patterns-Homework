namespace Homework_2.SecondTask.CharacterExample.Scripts.Character.StateMachine.States.Grounded
{
    public class FastRunningState : GroundedState
    {
        private readonly MovingStateConfig _config;

        public FastRunningState(IStateSwitcher stateSwitcher, StateMachineData data, global::Character character) :
            base(stateSwitcher, data, character)
            => _config = character.Config.MovingStateConfig;
        
        public override void Enter()
        {
            base.Enter();
            
            Data.Speed = _config.FastRunningSpeed;
            
            View.StartRunning();
        }
        
        public override void Exit()
        {
            base.Exit();
            
            View.StopRunning();
        }
        
        public override void Update()
        {
            base.Update();
            
            if (IsHorizontalInputZero())
                StateSwitcher.SwitchState<IdlingState>();
        }
    }
}