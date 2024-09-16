public interface INpcStateSwitcher
{
    void SwitchState<T>() where T : INpcState;
}
