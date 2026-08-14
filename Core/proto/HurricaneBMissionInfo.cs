using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20014DA")]
public class HurricaneBMissionInfo
{
	[Token(Token = "0x400900E")]
	[FieldOffset(Offset = "0x8")]
	public uint checkpoint_id;

	[Token(Token = "0x400900F")]
	[FieldOffset(Offset = "0xC")]
	public uint mission_id;

	[Token(Token = "0x4009010")]
	[FieldOffset(Offset = "0x10")]
	public uint star_number;

	[Token(Token = "0x6007B2F")]
	[Address(RVA = "0x30A34B8", Offset = "0x30A34B8", VA = "0x30A34B8")]
	public HurricaneBMissionInfo()
	{
	}
}
