using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001793")]
public class CSModifyTeamInfoReq
{
	[Token(Token = "0x4009A98")]
	[FieldOffset(Offset = "0x8")]
	public ulong team_id;

	[Token(Token = "0x4009A99")]
	[FieldOffset(Offset = "0x10")]
	public string team_name;

	[Token(Token = "0x4009A9A")]
	[FieldOffset(Offset = "0x14")]
	public string country_or_area;

	[Token(Token = "0x4009A9B")]
	[FieldOffset(Offset = "0x18")]
	public uint head_pic;

	[Token(Token = "0x4009A9C")]
	[FieldOffset(Offset = "0x1C")]
	public uint banner_id;

	[Token(Token = "0x6007DED")]
	[Address(RVA = "0x3097E84", Offset = "0x3097E84", VA = "0x3097E84")]
	public CSModifyTeamInfoReq()
	{
	}
}
