using UnityEngine;

namespace Homework_5
{
    public class Enemy : MonoBehaviour
    {
        private int _health;
        private float _speed;
        
        public virtual void Initialize(int health, float speed)
        {
            _health = health;
            _speed = speed;

            Debug.Log($"Health: {_health}, Speed: {_speed}");
        }

        public void MoveTo(Vector3 position) => transform.position = position;
    }
}
