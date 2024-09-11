using UnityEngine;

public abstract class Gun
{
    protected readonly GameObject bullet;
    protected readonly Transform firePoint;

    protected Gun(GameObject bulletGo, Transform firePoint)
    {
        bullet = bulletGo;
        this.firePoint = firePoint;
    }
    
    public abstract void Shoot();
    
    protected virtual void FireBullet()
    { 
        Object.Instantiate(bullet, firePoint.position, firePoint.rotation);
    }
}
