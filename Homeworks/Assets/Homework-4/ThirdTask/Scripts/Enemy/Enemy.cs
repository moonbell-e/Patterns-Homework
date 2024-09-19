using System;
using UnityEngine;

namespace Homework4
{
    public abstract class Enemy: MonoBehaviour
    {
        public event Action<Enemy> Died;
        
        public float Weight { get; protected set; }
        
        public abstract void Accept(IEnemyVisitor visiter); 

        public void MoveTo(Vector3 position) => transform.position = position;

        public void Kill()
        {
            Died?.Invoke(this);
            Destroy(gameObject);
        }
    }
}
