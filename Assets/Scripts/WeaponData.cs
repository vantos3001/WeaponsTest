using UnityEngine;

public abstract class WeaponData
{
    public float MinRange;
    public float MaxRange;
    
    public float Damage;

    public float MaxAmmo;

    public Projectile Projectile;
    public Transform SpawnPoint;

    [SerializeReference] public DamageData DamageData;

    [SerializeReference] public AimData AimData;

    [SerializeReference] public ReloadData ReloadData;

    [SerializeReference] public ShootModeData ShootModeData;
}