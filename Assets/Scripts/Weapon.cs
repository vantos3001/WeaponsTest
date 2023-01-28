using UnityEngine;

public abstract class Weapon : MonoBehaviour, IGetTarget
{
    [SerializeReference] protected WeaponData _weaponData;
    public WeaponData WeaponData => _weaponData;

    public ITarget Target => _target;

    protected ITarget _target;

    private AimLogic _aimLogic;
    private ShootLogic _shootLogic;
    private ReloadLogic _reloadLogic;

    protected WeaponState _weaponState = new WeaponState();

    public virtual void Init()
    {
        _aimLogic = _weaponData.AimData.CreateAimLogic();
        _shootLogic = new ShootLogic();
        _reloadLogic = _weaponData.ReloadData.CreateReloadLogic();
        
        _shootLogic.Init(_aimLogic, _reloadLogic, this, _weaponState, _weaponData);
        _reloadLogic.Init(_weaponState, _weaponData.MaxAmmo);
    }

    public void SetTarget(ITarget target)
    {
        if (_target == target)
        {
            return;
        }
        
        _target = target;
        _aimLogic.ChangeTarget(target);
    }

    private void Update()
    {
        var deltaTime = Time.deltaTime;
        _aimLogic.DoUpdate(deltaTime);
        _shootLogic.DoUpdate(deltaTime);
        _reloadLogic.DoUpdate(deltaTime);
    }
}