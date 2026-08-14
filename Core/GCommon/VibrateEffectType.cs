using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2004181")]
public enum VibrateEffectType
{
	[Token(Token = "0x401B765")]
	OnHearEnemyShoot = 1,
	[Token(Token = "0x401B766")]
	OnLocalHitByEnemyShoot,
	[Token(Token = "0x401B767")]
	OnHearEnemyFootStep,
	[Token(Token = "0x401B768")]
	OnHearEnemyVehicleRun,
	[Token(Token = "0x401B769")]
	OnLocalVehicleHitByShoot,
	[Token(Token = "0x401B76A")]
	OnLocalVehicleHitCollision,
	[Token(Token = "0x401B76B")]
	OnLocalVehicleRun,
	[Token(Token = "0x401B76C")]
	OnSilenceWeaponFire,
	[Token(Token = "0x401B76D")]
	RouletteSwitchVibrate,
	[Token(Token = "0x401B76E")]
	RouletteCancelVibrate
}
