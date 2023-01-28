# WeaponsTest

Weapon - класс оружия
WeaponData - данные об оружии
WeaponState - состояние оружия (текущее кол-во потронов)

AimLogic - логика прицеливания
ShootLogic - логика стрельбы
ReloadLogic - логика перезарядки

Projectile - пуля
ProjectileMovement - движение пули

DamageRule - правило нанесения урона
DamageData - данные о дамаге

Настройки для пистолет одиночными выстрелами:
Projectile c ForwardMovement
дамаг -  GeneralDamageData
нацеливание - AimByTimeData
перезарядка - GeneralReloadData
режим стрельбы - SingleShootModeData

Настройки для автомата стреляющего очередями:
Projectile c ForwardMovement
дамаг -  GeneralDamageData
нацеливание - AimByTimeData
перезарядка - GeneralReloadData
режим стрельбы - BurstShootModeLogic

Настройки для гранаты, летящей по дуге:
Projectile c CurveProjectileMovement
дамаг -  AoeDamageData
нацеливание - AimByTimeData
перезарядка - GeneralReloadData
режим стрельбы - SingleShootModeData
