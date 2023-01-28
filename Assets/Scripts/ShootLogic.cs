using System;
using Object = UnityEngine.Object;

public class ShootLogic : ICanShoot
{
    private IGetAimed _getAimed;
    private IGetReload _getReload;

    public bool CanShoot => _getAimed.IsAimed && _getReload.IsReload && 0 < _state.CurrentAmmo;

    private float _shotDelay;

    private WeaponState _state;
    private WeaponData _data;

    private IGetTarget _getTarget;

    private ShootModeLogic _shootModeLogic;

    private DamageRule _damageRule; 

    public void Init(IGetAimed getAimed, IGetReload getReload, IGetTarget getTarget ,WeaponState state, WeaponData data)
    {
        _getAimed = getAimed;
        _getReload = getReload;
        _getTarget = getTarget;
        _state = state;
        _data = data;

        _shootModeLogic = _data.ShootModeData.CreateShootModeLogic();
        _damageRule = _data.DamageData.CreateDamageRule();
        
        _shootModeLogic.Init(Shoot, this);
    }

    public void DoUpdate(float deltaTime)
    {
        _shootModeLogic.DoUpdate(deltaTime);
    }

    public void Shoot()
    {
        var projectile = Object.Instantiate(_data.Projectile, _data.SpawnPoint.position, _data.SpawnPoint.rotation);
        projectile.Init(OnHit, _getTarget.Target);
    }

    private void OnHit(ITarget target)
    {
        _damageRule.SetTarget(target);
        _damageRule.Damage();
    }
}