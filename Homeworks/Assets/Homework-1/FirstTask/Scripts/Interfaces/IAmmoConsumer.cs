public interface IAmmoConsumer
{
    bool HasAmmo(int requiredAmmoCount);
    void ConsumeAmmo(int amount);
}
