using System;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private ProjectileMovement _movement;
    
    private Action<ITarget> _onHit;
    
    public void Init(Action<ITarget> onHit, ITarget target)
    {
        _onHit = onHit;
        
        _movement.Init(OnMoveEnd, target);
        
        _movement.StartMove();
    }

    private void OnMoveEnd(ITarget target)
    {
        Destroy(gameObject);
        _onHit?.Invoke(target);
    }
}