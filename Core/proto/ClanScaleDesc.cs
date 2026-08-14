using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A20")]
public class ClanScaleDesc
{
	[Token(Token = "0x400A3B7")]
	[FieldOffset(Offset = "0x8")]
	public uint clan_scale;

	[Token(Token = "0x400A3B8")]
	[FieldOffset(Offset = "0xC")]
	public uint max_member_count;

	[Token(Token = "0x400A3B9")]
	[FieldOffset(Offset = "0x10")]
	public uint create_gold_cost;

	[Token(Token = "0x400A3BA")]
	[FieldOffset(Offset = "0x14")]
	public uint create_diamond_cost;

	[Token(Token = "0x6008078")]
	[Address(RVA = "0x309C138", Offset = "0x309C138", VA = "0x309C138")]
	public ClanScaleDesc()
	{
	}
}
