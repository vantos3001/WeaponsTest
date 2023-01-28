using System;
using UnityEngine;

public class ForwardProjectileMovement : ProjectileMovement
{
    [SerializeField] private float _speed;

    private float _time;

    private float _currentTime;
    
    public override void StartMove()
    {
        var distance = Vector3.Distance(_startProjectilePosition, _target.GetPosition);
        _time = distance / _speed;
    }

    protected override void UpdateMove(float deltaTime)
    {
        base.UpdateMove(deltaTime);

        _currentTime += deltaTime;

        _currentTime = Mathf.Min(_currentTime, _time);

        transform.position = Vector3.Lerp(_startProjectilePosition, _target.GetPosition, _currentTime);

        if (_time <= _currentTime)
        {
            EndMove(_target);
        }
    }
}