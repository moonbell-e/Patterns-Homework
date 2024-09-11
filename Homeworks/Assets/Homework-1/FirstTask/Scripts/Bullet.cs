using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _timeToLive = 5f;
    [SerializeField] private float _speed = 10f;

    private Rigidbody _rb;
    private Vector3 _direction;
    
    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        _rb.AddForce(-transform.forward * _speed, ForceMode.Impulse);
    }

    private void Start()
    {
        Destroy(gameObject, _timeToLive);
    }
}
