public abstract class AimLogic : IGetAimed
{
    private ITarget _target;

    protected bool _isAimed;
    public bool IsAimed => _isAimed;

    private AimData _aimData;

    public AimLogic(AimData aimData)
    {
        _aimData = aimData;
    }

    public void ChangeTarget(ITarget target)
    {
        _target = target;
        RestartAim();
    }

    protected virtual void RestartAim()
    {
        _isAimed = false;
    }

    public abstract void DoUpdate(float deltaTime);
}