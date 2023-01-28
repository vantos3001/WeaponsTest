using System;

[Serializable]
public class BurstShootModeData : ShootModeData
{
    public float BurstDelay;
    public int BulletsPerBurst;
    
    public override ShootModeLogic CreateShootModeLogic()
    {
        return new BurstShootModeLogic(this);
    }
}