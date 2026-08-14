using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200169C")]
public class CSGetFacebookFriendListReq
{
	[Token(Token = "0x4009693")]
	[FieldOffset(Offset = "0x8")]
	public string token;

	[Token(Token = "0x4009694")]
	[FieldOffset(Offset = "0xC")]
	public bool need_presence;

	[Token(Token = "0x4009695")]
	[FieldOffset(Offset = "0xD")]
	public bool need_stats;

	[Token(Token = "0x4009696")]
	[FieldOffset(Offset = "0xE")]
	public bool need_ranking_stats;

	[Token(Token = "0x4009697")]
	[FieldOffset(Offset = "0xF")]
	public bool need_casual_stats;

	[Token(Token = "0x4009698")]
	[FieldOffset(Offset = "0x10")]
	public bool need_cs_ranking_stats;

	[Token(Token = "0x6007CF9")]
	[Address(RVA = "0x3184B40", Offset = "0x3184B40", VA = "0x3184B40")]
	public CSGetFacebookFriendListReq()
	{
	}
}
