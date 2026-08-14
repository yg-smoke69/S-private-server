using Il2CppDummyDll;

namespace WwiseGameSyncs.Switch;

[Token(Token = "0x20002AD")]
internal class Bullet_Type : SwitchBase
{
	[Token(Token = "0x40032A0")]
	[FieldOffset(Offset = "0x0")]
	public static Bullet_Type Arrow;

	[Token(Token = "0x40032A1")]
	[FieldOffset(Offset = "0x4")]
	public static Bullet_Type Fist;

	[Token(Token = "0x40032A2")]
	[FieldOffset(Offset = "0x8")]
	public static Bullet_Type Grenade;

	[Token(Token = "0x40032A3")]
	[FieldOffset(Offset = "0xC")]
	public static Bullet_Type HandGun;

	[Token(Token = "0x40032A4")]
	[FieldOffset(Offset = "0x10")]
	public static Bullet_Type MachineGun;

	[Token(Token = "0x40032A5")]
	[FieldOffset(Offset = "0x14")]
	public static Bullet_Type Rifle;

	[Token(Token = "0x40032A6")]
	[FieldOffset(Offset = "0x18")]
	public static Bullet_Type ShotGun;

	[Token(Token = "0x40032A7")]
	[FieldOffset(Offset = "0x1C")]
	public static Bullet_Type Sniper;

	[Token(Token = "0x40032A8")]
	[FieldOffset(Offset = "0x20")]
	public static Bullet_Type SubmachineGun;

	[Token(Token = "0x6000D2F")]
	[Address(RVA = "0x336E098", Offset = "0x336E098", VA = "0x336E098")]
	private Bullet_Type(uint _value)
	{
	}
}
