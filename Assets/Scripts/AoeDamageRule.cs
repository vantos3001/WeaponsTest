using System.Collections.Generic;

public class AoeDamageRule : DamageRule
{
    private AoeDamageData _data;
    
    public AoeDamageRule(AoeDamageData data) : base(data)
    {
        _data = data;
    }

    public override List<DamageInfo> GetDamageInfos()
    {
        var targets = TargetManager.GetAllTargetsInRange(_target.GetPosition, _data.Radius);

        var infos = new List<DamageInfo>();

        for (int i = 0; i < targets.Count; i++)
        {
            var info = new DamageInfo()
            {
                Target = targets[i],
                Damage = _data.Damage
            };
            
            infos.Add(info);
        }

        return infos;
    }
}