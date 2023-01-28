using System;

[Serializable]
public class SingleShootModeData : ShootModeData
{
    public override ShootModeLogic CreateShootModeLogic()
    {
        return new SingleShootModeLogic(this);
    }
}