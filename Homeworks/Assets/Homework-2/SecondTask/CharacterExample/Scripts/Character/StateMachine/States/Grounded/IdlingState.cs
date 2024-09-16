using Homework_2.SecondTask.CharacterExample.Scripts.Character.StateMachine.States.Grounded;

public class IdlingState : GroundedState
{
    public IdlingState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher,
        data, character)
    {
    }

    public override void Enter()
    {
        base.Enter();

        Data.Speed = 0;

        View.StartIdling();
    }

    public override void Exit()
    {
        base.Exit();

        View.StopIdling();
    }

    public override void Update()
    {
        base.Update();

        if (IsHorizontalInputZero())
            return;

        if (Data.IsRunning)
        {
            if (Data.IsFastRunning)
                StateSwitcher.SwitchState<FastRunningState>();
            else
                StateSwitcher.SwitchState<RunningState>();
        }
        else
        {
            StateSwitcher.SwitchState<WalkingState>();
        }
    }
}