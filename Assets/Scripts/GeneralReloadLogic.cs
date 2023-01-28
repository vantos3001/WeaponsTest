public class GeneralReloadLogic : ReloadLogic
{
    private GeneralReloadData _data;

    private float _currentReloadTime;

    public GeneralReloadLogic(GeneralReloadData data) : base(data)
    {
        _data = data;
    }

    public override void DoUpdate(float deltaTime)
    {
        TryUpdateReload(deltaTime);
    }

    private void TryUpdateReload(float deltaTime)
    {
        if (0 < _state.CurrentAmmo)
        {
            _isReload = false;
            _currentReloadTime = 0f;
            return;
        }

        _isReload = true;
        _currentReloadTime += deltaTime;

        if (_data.ReloadTime <= _currentReloadTime)
        {
            _state.CurrentAmmo = _maxAmmo;
            _isReload = false;
            _currentReloadTime = 0f;
        }
    }
}