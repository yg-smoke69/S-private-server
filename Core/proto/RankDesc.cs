using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A73")]
public class RankDesc
{
	[Token(Token = "0x400A58C")]
	[FieldOffset(Offset = "0x8")]
	public uint rank;

	[Token(Token = "0x400A58D")]
	[FieldOffset(Offset = "0xC")]
	public string rank_desc;

	[Token(Token = "0x400A58E")]
	[FieldOffset(Offset = "0x10")]
	public string rank_name;

	[Token(Token = "0x400A58F")]
	[FieldOffset(Offset = "0x14")]
	public uint lower_bound;

	[Token(Token = "0x400A590")]
	[FieldOffset(Offset = "0x18")]
	public uint upper_bound;

	[Token(Token = "0x400A591")]
	[FieldOffset(Offset = "0x1C")]
	public bool heroic_mark_switch;

	[Token(Token = "0x60080D0")]
	[Address(RVA = "0x33E0840", Offset = "0x33E0840", VA = "0x33E0840")]
	public RankDesc()
	{
	}
}
