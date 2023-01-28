using UnityEngine;

public class CurveProjectileMovement : ProjectileMovement
{
    [SerializeField] private AnimationCurve _heightCurve;
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

        var newPosition = Vector3.Lerp(_startProjectilePosition, _target.GetPosition, _currentTime);

        var deltaYPos = _heightCurve.Evaluate(_currentTime / _time);
        newPosition.y += deltaYPos;

        transform.position = newPosition;
        
        if (_time <= _currentTime)
        {
            EndMove(_target);
        }
    }
}