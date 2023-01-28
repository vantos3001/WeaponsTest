using System;

[Serializable]
public abstract class DamageData
{
    public float Damage;

    public abstract DamageRule CreateDamageRule();
}