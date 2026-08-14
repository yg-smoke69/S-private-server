using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001ACC")]
public class TeammateIntimacyInfoDesc
{
	[Token(Token = "0x400A8B8")]
	[FieldOffset(Offset = "0x8")]
	public uint idx;

	[Token(Token = "0x400A8B9")]
	[FieldOffset(Offset = "0xC")]
	public EFriend.RelationType relation_type;

	[Token(Token = "0x400A8BA")]
	[FieldOffset(Offset = "0x10")]
	public uint game_mode;

	[Token(Token = "0x400A8BB")]
	[FieldOffset(Offset = "0x14")]
	public uint upper_ranking;

	[Token(Token = "0x400A8BC")]
	[FieldOffset(Offset = "0x18")]
	public uint lower_ranking;

	[Token(Token = "0x400A8BD")]
	[FieldOffset(Offset = "0x1C")]
	public uint intimacy_value;

	[Token(Token = "0x400A8BE")]
	[FieldOffset(Offset = "0x20")]
	public uint match_mode;

	[Token(Token = "0x400A8BF")]
	[FieldOffset(Offset = "0x24")]
	public uint group_mode;

	[Token(Token = "0x6008129")]
	[Address(RVA = "0x33E369C", Offset = "0x33E369C", VA = "0x33E369C")]
	public TeammateIntimacyInfoDesc()
	{
	}
}
