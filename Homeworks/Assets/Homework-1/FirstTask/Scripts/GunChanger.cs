using UnityEngine;

public class GunChanger : MonoBehaviour
{
    [SerializeField] private Transform _firePoint;
    [SerializeField] private GameObject _bullet;
    [SerializeField] private Shooter _shooter;
    
    private Gun _currentWeapon;

    private void Awake()
    {
        SetGun(new SingleShotGun(_bullet, _firePoint));
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SetGun(new SingleShotGun(_bullet, _firePoint));
        } 
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SetGun(new InfiniteGun(_bullet, _firePoint));
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SetGun(new MultishotGun(_bullet, _firePoint));
        }
    }
    
    private void SetGun(Gun newGun)
    {
        _currentWeapon = newGun;
        _shooter.SetGun(newGun);
        
        Debug.Log("Weapon changed to: " + _currentWeapon.GetType().Name);
    }
}
