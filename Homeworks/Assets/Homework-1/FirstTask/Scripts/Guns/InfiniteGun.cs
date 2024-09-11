using UnityEngine;

public class InfiniteGun : Gun
{
    public InfiniteGun(GameObject bulletGo, Transform firePoint) : base(bulletGo, firePoint)
    {
    }
    
    public override void Shoot()
    {
        FireBullet();
    }
}

