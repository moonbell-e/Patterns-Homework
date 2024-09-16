namespace Homework_2.SecondTask.CharacterExample.Scripts.Character.StateMachine.States.Grounded
{
    public class WalkingState : GroundedState
    {
        private readonly MovingStateConfig _config;

        public WalkingState(IStateSwitcher stateSwitcher, StateMachineData data, global::Character character) : base(
            stateSwitcher, data, character)
            => _config = character.Config.MovingStateConfig;

        public override void Enter()
        {
            base.Enter();
            
            Data.Speed = _config.WalkingSpeed;
            
            View.StartWalking();
        }
        
        public override void Exit()
        {
            base.Exit();
            
            View.StopWalking();
        }
        
        public override void Update()
        {
            base.Update();

            if (Data.IsRunning)
            {
                if (Data.IsFastRunning)
                    StateSwitcher.SwitchState<FastRunningState>();
                else
                    StateSwitcher.SwitchState<RunningState>();
            }
            else if (IsHorizontalInputZero())
                StateSwitcher.SwitchState<IdlingState>();
        }
    }
}