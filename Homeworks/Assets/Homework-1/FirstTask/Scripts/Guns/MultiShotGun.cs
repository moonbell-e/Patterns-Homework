using UnityEngine;

public class MultishotGun : Gun
{
    private readonly IAmmoConsumer _ammoConsumer;
    private const int AmmoCount = 30;
    private const int SingleShotAmmo = 3;
    private const float AngleBetweenBullets = 15f;
    
    public MultishotGun(GameObject bulletGo, Transform firePoint) : base(bulletGo, firePoint)
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
            Debug.Log("No ammo left for multi shot!");
        }
    }
    
    protected override void FireBullet()
    {
        for (var i = 0; i < 3; i++)
        {
            var angleOffset = (i - (SingleShotAmmo - 1) / 2f) * AngleBetweenBullets;
            var bulletRotation = Quaternion.Euler(0, angleOffset, 0) * firePoint.rotation;
            
            var bulletPositionOffset = new Vector3(0, 0, i - 1);
            var bulletPosition = firePoint.position + bulletPositionOffset;
            
            
            Object.Instantiate(bullet, bulletPosition, firePoint.rotation);
        }
    }
}
