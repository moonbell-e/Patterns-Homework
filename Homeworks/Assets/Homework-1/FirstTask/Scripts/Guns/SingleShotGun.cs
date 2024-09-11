using UnityEngine;

public class SingleShotGun : Gun
{
    private readonly IAmmoConsumer _ammoConsumer;
    private const int AmmoCount = 10;
    private const int SingleShotAmmo = 1;

    public SingleShotGun(GameObject bulletGo, Transform firePoint) : base(bulletGo, firePoint)
    {
        _ammoConsumer = new AmmoConsumer(AmmoCount);
    }

    public override void Shoot()
    {
        if (_ammoConsumer.HasAmmo(SingleShotAmmo))
        {
            FireBullet();
            _ammoConsumer.ConsumeAmmo(SingleShotAmmo);
        }
        else
        {
            Debug.Log("No ammo left for single shot!");
        }
    }
}