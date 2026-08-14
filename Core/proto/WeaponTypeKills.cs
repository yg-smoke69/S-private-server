using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20013ED")]
public class WeaponTypeKills
{
	[Token(Token = "0x4008B87")]
	[FieldOffset(Offset = "0x8")]
	public uint weapon_type;

	[Token(Token = "0x4008B88")]
	[FieldOffset(Offset = "0xC")]
	public uint cnt;

	[Token(Token = "0x4008B89")]
	[FieldOffset(Offset = "0x10")]
	public uint head_cnt;

	[Token(Token = "0x6007ACE")]
	[Address(RVA = "0x33E5338", Offset = "0x33E5338", VA = "0x33E5338")]
	public WeaponTypeKills()
	{
	}
}
