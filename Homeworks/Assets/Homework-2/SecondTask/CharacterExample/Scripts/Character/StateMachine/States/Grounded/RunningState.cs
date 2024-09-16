using Homework_2.SecondTask.CharacterExample.Scripts.Character.StateMachine.States.Grounded;

public class RunningState : GroundedState
{
    private readonly MovingStateConfig _config;

    public RunningState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character)
        => _config = character.Config.MovingStateConfig;

    public override void Enter()
    {
        base.Enter();

        Data.Speed = _config.RunningSpeed;
        Data.IsRunning = true;
        
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

        if (!Data.IsRunning)
            StateSwitcher.SwitchState<WalkingState>();
        else if (IsHorizontalInputZero())
            StateSwitcher.SwitchState<IdlingState>();
    }
}
