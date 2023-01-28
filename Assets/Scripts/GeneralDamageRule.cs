using System.Collections.Generic;

public class GeneralDamageRule : DamageRule
{
    private GeneralDamageData _data;
    
    public GeneralDamageRule(GeneralDamageData data) : base(data)
    {
        _data = data;
    }

    public override List<DamageInfo> GetDamageInfos()
    {
        var info = new DamageInfo()
        {
            Target = _target,
            Damage = _data.Damage
        };

        return new List<DamageInfo>()
        {
            info,
        };
    }
}