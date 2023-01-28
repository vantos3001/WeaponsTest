using System;

[Serializable]
public abstract class AimData
{
    public abstract AimLogic CreateAimLogic();
}