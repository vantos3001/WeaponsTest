public class BurstShootModeLogic : ShootModeLogic
{
    private BurstShootModeData _data;
    
    private float _currentDelay;
    private int _currentBulletsPerBurst;

    public BurstShootModeLogic(BurstShootModeData data) : base(data)
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
            _currentBulletsPerBurst = 0;
            return;
        }

        _currentDelay += deltaTime;

        if (TryUpdateShootingByBurst())
        {
            return;
        }

        TryUpdateShootByGeneral();
    }

    private bool TryUpdateShootingByBurst()
    {
        if (_data.BulletsPerBurst <= _currentBulletsPerBurst)
        {
            return false;
        }
        
        if (_data.BurstDelay <= _currentDelay)
        {
            _currentDelay = 0f;
            _currentBulletsPerBurst++;
            _shoot?.Invoke();
        }

        return true;
    }

    private void TryUpdateShootByGeneral()
    {
        if (_data.ShootDelay <= _currentDelay)
        {
            _currentDelay = 0f;
            _currentBulletsPerBurst = 1;
            _shoot?.Invoke();
        }
    }
}