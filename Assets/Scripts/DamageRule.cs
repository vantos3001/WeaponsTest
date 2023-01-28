using System.Collections.Generic;

public abstract class DamageRule
{
    protected ITarget _target;

    private DamageData _data;

    public DamageRule(DamageData data)
    {
        _data = data;
    }
    
    public void SetTarget(ITarget target)
    {
        _target = target;
    }

    public abstract List<DamageInfo> GetDamageInfos();
    
    public void Damage()
    {
        DamageManager.Damage(GetDamageInfos());
    }
}