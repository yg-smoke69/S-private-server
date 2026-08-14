using Il2CppDummyDll;

namespace WwiseGameSyncs.Switch;

[Token(Token = "0x20002BF")]
internal class Weapon_Silencer : SwitchBase
{
	[Token(Token = "0x40032E3")]
	[FieldOffset(Offset = "0x0")]
	public static Weapon_Silencer Default;

	[Token(Token = "0x40032E4")]
	[FieldOffset(Offset = "0x4")]
	public static Weapon_Silencer Silencer;

	[Token(Token = "0x6000D53")]
	[Address(RVA = "0x336F9DC", Offset = "0x336F9DC", VA = "0x336F9DC")]
	private Weapon_Silencer(uint _value)
	{
	}
}
