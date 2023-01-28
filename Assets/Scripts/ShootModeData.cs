using System;

[Serializable]
public abstract class ShootModeData
{
    public float ShootDelay;
    
    public abstract ShootModeLogic CreateShootModeLogic();
}