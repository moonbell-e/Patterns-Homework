public class NpcState : INpcState
{
    protected readonly Npc npc;
    protected readonly NpcStateMachine npcStateMachine;

    protected NpcState(Npc npc, NpcStateMachine npcStateMachine)
    {
        this.npc = npc;
        this.npcStateMachine = npcStateMachine;
    }

    public virtual void EnterState() { }
    public virtual void ExitState() { }

    public virtual void UpdateState() { }
}