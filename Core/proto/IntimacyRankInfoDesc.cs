using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001ACF")]
public class IntimacyRankInfoDesc
{
	[Token(Token = "0x400A8C6")]
	[FieldOffset(Offset = "0x8")]
	public uint idx;

	[Token(Token = "0x400A8C7")]
	[FieldOffset(Offset = "0xC")]
	public EFriend.RelationType relation_type;

	[Token(Token = "0x400A8C8")]
	[FieldOffset(Offset = "0x10")]
	public uint intimacy_rank;

	[Token(Token = "0x400A8C9")]
	[FieldOffset(Offset = "0x14")]
	public uint lower_bound;

	[Token(Token = "0x400A8CA")]
	[FieldOffset(Offset = "0x18")]
	public uint upper_bound;

	[Token(Token = "0x400A8CB")]
	[FieldOffset(Offset = "0x1C")]
	public string relation_badge_icon;

	[Token(Token = "0x600812C")]
	[Address(RVA = "0x30A3DC0", Offset = "0x30A3DC0", VA = "0x30A3DC0")]
	public IntimacyRankInfoDesc()
	{
	}
}
