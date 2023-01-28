using System;
using UnityEngine;

public abstract class ProjectileMovement : MonoBehaviour
{
    private Action<ITarget> _onMoveEnd;
    protected ITarget _target;

    protected Vector3 _startProjectilePosition;
    
    public void Init(Action<ITarget> onMoveEnd, ITarget target)
    {
        _onMoveEnd = onMoveEnd;
        _target = target;
        _startProjectilePosition = transform.position;
    }
    
    protected virtual void OnInit(){}

    public abstract void StartMove();

    private void Update()
    {
        var deltaTime = Time.deltaTime;
        UpdateMove(deltaTime);
    }
    
    protected virtual void UpdateMove(float deltaTime)
    {
        
    }

    protected void EndMove(ITarget target)
    {
        _onMoveEnd?.Invoke(target);
    }
}