using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public abstract class GroundedState : MovementState
{
    private GroundChecker _groundChecker;
    public GroundedState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character)
        => _groundChecker = character.GroundChecker;

    public override void Enter()
    {
        base.Enter();
        
        Input.Movement.Jump.started += OnJumpKeyPressed;
        Input.Movement.Run.started += OnRunKeyPressed;
        Input.Movement.Run.canceled += OnRunKeyPressed;
        Input.Movement.FastRun.started += OnFastRunModeStarted;
    }

    public override void Exit()
    {
        base.Exit();

        Input.Movement.Jump.started -= OnJumpKeyPressed;
        Input.Movement.Run.started -= OnRunKeyPressed;
        Input.Movement.Run.canceled -= OnRunKeyPressed;
        Input.Movement.FastRun.started -= OnFastRunModeStarted;

        View.StopGrounded();
    }

    public override void Update()
    {
        base.Update();

        
        if (_groundChecker.IsTouches == false)
            StateSwitcher.SwitchState<FallingState>();
    }

    private void OnFastRunModeStarted(InputAction.CallbackContext obj)
    {
        Data.IsFastRunning = !Data.IsFastRunning;
        Debug.Log(Data.IsFastRunning);
    }
    
    private void OnRunKeyPressed(InputAction.CallbackContext obj)
    {
        Data.IsRunning = obj.ReadValueAsButton();
    }

    private void OnJumpKeyPressed(InputAction.CallbackContext obj)
        => StateSwitcher.SwitchState<JumpingState>();
    
}
