using System;

public abstract class ShootModeLogic
{
    private ShootModeData _data;

    protected Action _shoot;

    protected ICanShoot _canShoot;

    public ShootModeLogic(ShootModeData data)
    {
        _data = data;
    }
    
    public void Init(Action shoot, ICanShoot canShoot)
    {
        _shoot = shoot;
        _canShoot = canShoot;
    }

    public abstract void DoUpdate(float deltaTime);
}