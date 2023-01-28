public class AimByTimeLogic : AimLogic
{
    private AimByTimeData _aimByTimeData;

    private float _currentTime;

    public AimByTimeLogic(AimByTimeData aimByTimeData) : base(aimByTimeData)
    {
        _aimByTimeData = aimByTimeData;
    }

    protected override void RestartAim()
    {
        base.RestartAim();

        _currentTime = 0f;
    }

    public override void DoUpdate(float deltaTime)
    {
        TryAim(deltaTime);
    }

    private void TryAim(float deltaTime)
    {
        if (_isAimed)
        {
            return;
        }
        
        _currentTime += deltaTime;

        if (_aimByTimeData.AimTime <= _currentTime)
        {
            _isAimed = true;
        }
    }
}