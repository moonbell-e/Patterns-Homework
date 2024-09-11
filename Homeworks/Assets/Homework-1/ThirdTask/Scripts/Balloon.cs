using System;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    [SerializeField] private EColor _balloonColor;
    
    public Action<Balloon> OnBalloonPopped;
    public EColor Color => _balloonColor;

    private void OnMouseDown()
    {
        OnBalloonPopped?.Invoke(this);
    }
}
