using System.Collections.Generic;

public static class DamageManager
{
    public static void Damage(List<DamageInfo> damageInfos)
    {
        foreach (var damageInfo in damageInfos)
        {
            Damage(damageInfo);
        }
    }
    
    public static void Damage(DamageInfo damageInfo)
    {
        //TODO Damage target
    }
}