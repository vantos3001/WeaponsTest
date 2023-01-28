using System;

[Serializable]
public class AimByTimeData : AimData
{
    public float AimTime;
    
    public override AimLogic CreateAimLogic()
    {
        return new AimByTimeLogic(this);
    }
}