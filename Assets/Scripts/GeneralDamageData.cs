using System;

[Serializable]
public class GeneralDamageData : DamageData
{
    public override DamageRule CreateDamageRule()
    {
        return new GeneralDamageRule(this);
    }
}