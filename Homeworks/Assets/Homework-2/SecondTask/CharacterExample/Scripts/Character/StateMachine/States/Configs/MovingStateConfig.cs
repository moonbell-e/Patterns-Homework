using System;
using UnityEngine;

[Serializable]
public class MovingStateConfig
{
    [field: SerializeField, Range(0, 10)] public float RunningSpeed { get; private set; } 
    
    [field: SerializeField, Range(0, 10)] public float FastRunningSpeed { get; private set; }  
    [field: SerializeField, Range(0, 10)] public float WalkingSpeed { get; private set; }  
}
