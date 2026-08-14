using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20013DD")]
public class WeaponKill
{
	[Token(Token = "0x4008B52")]
	[FieldOffset(Offset = "0x8")]
	public uint weapon_id;

	[Token(Token = "0x4008B53")]
	[FieldOffset(Offset = "0xC")]
	public uint cnt;

	[Token(Token = "0x4008B54")]
	[FieldOffset(Offset = "0x10")]
	public uint head_cnt;

	[Token(Token = "0x4008B55")]
	[FieldOffset(Offset = "0x14")]
	public uint weapon_type;

	[Token(Token = "0x6007ABE")]
	[Address(RVA = "0x33E5128", Offset = "0x33E5128", VA = "0x33E5128")]
	public WeaponKill()
	{
	}
}
