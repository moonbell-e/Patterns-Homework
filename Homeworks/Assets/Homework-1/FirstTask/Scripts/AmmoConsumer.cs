public class AmmoConsumer : IAmmoConsumer
{
    public int AmmoCount { get; set; }

    public AmmoConsumer(int initialAmmo)
    {
        AmmoCount = initialAmmo;
    }
    
    public bool HasAmmo(int requiredAmmoCount)
    {
        return AmmoCount >= requiredAmmoCount;
    }

    public void ConsumeAmmo(int amount)
    {
        AmmoCount -= amount;
    }
}
