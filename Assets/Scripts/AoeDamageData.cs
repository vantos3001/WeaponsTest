using System;

[Serializable]
public class AoeDamageData : DamageData
{
    public float Radius = 1f;
    
    public override DamageRule CreateDamageRule()
    {
        return new AoeDamageRule(this);
    }
}