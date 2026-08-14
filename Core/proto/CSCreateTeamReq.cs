using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001789")]
public class CSCreateTeamReq
{
	[Token(Token = "0x4009A84")]
	[FieldOffset(Offset = "0x8")]
	public string team_name;

	[Token(Token = "0x4009A85")]
	[FieldOffset(Offset = "0xC")]
	public string contact_info;

	[Token(Token = "0x4009A86")]
	[FieldOffset(Offset = "0x10")]
	public string country_or_area;

	[Token(Token = "0x4009A87")]
	[FieldOffset(Offset = "0x14")]
	public uint head_pic;

	[Token(Token = "0x4009A88")]
	[FieldOffset(Offset = "0x18")]
	public uint banner_id;

	[Token(Token = "0x4009A89")]
	[FieldOffset(Offset = "0x1C")]
	public uint scale_type;

	[Token(Token = "0x6007DE3")]
	[Address(RVA = "0x317F2EC", Offset = "0x317F2EC", VA = "0x317F2EC")]
	public CSCreateTeamReq()
	{
	}
}
