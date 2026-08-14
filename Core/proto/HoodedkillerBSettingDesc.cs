using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B5C")]
public class HoodedkillerBSettingDesc
{
	[Token(Token = "0x400AC27")]
	[FieldOffset(Offset = "0x8")]
	public uint token_id;

	[Token(Token = "0x400AC28")]
	[FieldOffset(Offset = "0xC")]
	public uint s_points;

	[Token(Token = "0x400AC29")]
	[FieldOffset(Offset = "0x10")]
	public uint a_points;

	[Token(Token = "0x400AC2A")]
	[FieldOffset(Offset = "0x14")]
	public uint b_points;

	[Token(Token = "0x400AC2B")]
	[FieldOffset(Offset = "0x18")]
	public uint c_points;

	[Token(Token = "0x60081B7")]
	[Address(RVA = "0x30A30EC", Offset = "0x30A30EC", VA = "0x30A30EC")]
	public HoodedkillerBSettingDesc()
	{
	}
}
