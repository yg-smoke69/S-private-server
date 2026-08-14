using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200177D")]
public class ManualWeaponReward
{
	[Token(Token = "0x4009A5C")]
	[FieldOffset(Offset = "0x8")]
	public uint quantity_period;

	[Token(Token = "0x4009A5D")]
	[FieldOffset(Offset = "0xC")]
	public EManual.State state;

	[Token(Token = "0x6007DD7")]
	[Address(RVA = "0x30A78EC", Offset = "0x30A78EC", VA = "0x30A78EC")]
	public ManualWeaponReward()
	{
	}
}
