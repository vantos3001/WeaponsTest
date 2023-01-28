using System;

[Serializable]
public abstract class ReloadData
{
    public float ReloadTime;

    public abstract ReloadLogic CreateReloadLogic();
}