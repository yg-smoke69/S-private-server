using Il2CppDummyDll;

namespace WwiseGameSyncs.Switch;

[Token(Token = "0x20002BE")]
internal class Weapon_Melee_Impact : SwitchBase
{
	[Token(Token = "0x40032DF")]
	[FieldOffset(Offset = "0x0")]
	public static Weapon_Melee_Impact Body;

	[Token(Token = "0x40032E0")]
	[FieldOffset(Offset = "0x4")]
	public static Weapon_Melee_Impact Concrete;

	[Token(Token = "0x40032E1")]
	[FieldOffset(Offset = "0x8")]
	public static Weapon_Melee_Impact Metal;

	[Token(Token = "0x40032E2")]
	[FieldOffset(Offset = "0xC")]
	public static Weapon_Melee_Impact Wood;

	[Token(Token = "0x6000D51")]
	[Address(RVA = "0x336F86C", Offset = "0x336F86C", VA = "0x336F86C")]
	private Weapon_Melee_Impact(uint _value)
	{
	}
}
