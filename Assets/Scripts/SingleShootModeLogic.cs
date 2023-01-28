public class SingleShootModeLogic : ShootModeLogic
{
    private SingleShootModeData _data;

    private float _currentDelay;
    
    public SingleShootModeLogic(SingleShootModeData data) : base(data)
    {
        _data = data;
    }

    public override void DoUpdate(float deltaTime)
    {
        TryUpdateShooting(deltaTime);
    }

    private void TryUpdateShooting(float deltaTime)
    {
        if (!_canShoot.CanShoot)
        {
            _currentDelay = 0f;
            return;
        }

        _currentDelay += deltaTime;

        if (_data.ShootDelay <= _currentDelay)
        {
            _currentDelay = 0f;
            _shoot?.Invoke();
        }
    }
}