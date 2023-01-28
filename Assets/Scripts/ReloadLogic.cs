public abstract class ReloadLogic : IGetReload
{
    protected bool _isReload;

    public bool IsReload => _isReload;
    
    protected WeaponState _state;

    private ReloadData _reloadData;

    protected float _maxAmmo;

    public ReloadLogic(ReloadData reloadData)
    {
        _reloadData = reloadData;
    }
    
    public void Init(WeaponState state, float maxAmmo)
    {
        _state = state;
        _maxAmmo = maxAmmo;
        
        _state.CurrentAmmo = _maxAmmo;
    }

    public abstract void DoUpdate(float deltaTime);
}