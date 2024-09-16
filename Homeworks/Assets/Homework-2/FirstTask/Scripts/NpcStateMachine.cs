using System.Collections.Generic;
using System.Linq;
using Homework_2.FirstTask.Scripts.States;

public class NpcStateMachine: INpcStateSwitcher
{
    private readonly List<INpcState> _states;
    private INpcState _currentState;
    
    public NpcStateMachine(Npc npc)
    {
        _states = new List<INpcState>()
        {
            new WalkingState(npc, this),
            new WorkingState(npc, this),
            new RestingState(npc, this)
        };

        _currentState = _states[0];
        _currentState.EnterState();
    }

    public void SwitchState<T>() where T: INpcState
    {
        var state = _states.FirstOrDefault(state => state is T);

        _currentState.ExitState();
        _currentState = state;
        _currentState?.EnterState();
    }

    public void Update() => _currentState.UpdateState();
}