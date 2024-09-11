using UnityEngine;

public class Shooter : MonoBehaviour
{
    private Gun _gun;
    
    public void SetGun(Gun gun)
    {
        _gun = gun;
    }
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _gun.Shoot();
        }
    }
}
