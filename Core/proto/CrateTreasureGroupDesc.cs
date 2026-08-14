using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019CF")]
public class CrateTreasureGroupDesc
{
	[Token(Token = "0x400A1B6")]
	[FieldOffset(Offset = "0x8")]
	public uint group_id;

	[Token(Token = "0x400A1B7")]
	[FieldOffset(Offset = "0xC")]
	public uint num_group;

	[Token(Token = "0x400A1B8")]
	[FieldOffset(Offset = "0x10")]
	public bool is_repeatable;

	[Token(Token = "0x400A1B9")]
	[FieldOffset(Offset = "0x14")]
	public string icon;

	[Token(Token = "0x6008027")]
	[Address(RVA = "0x309D7AC", Offset = "0x309D7AC", VA = "0x309D7AC")]
	public CrateTreasureGroupDesc()
	{
	}
}
