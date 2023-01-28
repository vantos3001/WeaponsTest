using System;

[Serializable]
public class GeneralReloadData : ReloadData
{
    public override ReloadLogic CreateReloadLogic()
    {
        return new GeneralReloadLogic(this);
    }
}