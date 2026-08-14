using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001650")]
public class CSRandomClanListReq
{
	[Token(Token = "0x40095E7")]
	[FieldOffset(Offset = "0x8")]
	public EClan.ClanMainType clan_list_type;

	[Token(Token = "0x40095E8")]
	[FieldOffset(Offset = "0xC")]
	public uint area_id;

	[Token(Token = "0x40095E9")]
	[FieldOffset(Offset = "0x10")]
	public uint play_style;

	[Token(Token = "0x6007C9A")]
	[Address(RVA = "0x3098AAC", Offset = "0x3098AAC", VA = "0x3098AAC")]
	public CSRandomClanListReq()
	{
	}
}
