using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001574")]
public class CSCreateCupTeamReq
{
	[Token(Token = "0x400933E")]
	[FieldOffset(Offset = "0x8")]
	public uint cup_type;

	[Token(Token = "0x400933F")]
	[FieldOffset(Offset = "0xC")]
	public uint cup_id;

	[Token(Token = "0x4009340")]
	[FieldOffset(Offset = "0x10")]
	public string team_name;

	[Token(Token = "0x4009341")]
	[FieldOffset(Offset = "0x14")]
	public string country_or_area;

	[Token(Token = "0x4009342")]
	[FieldOffset(Offset = "0x18")]
	public uint head_pic;

	[Token(Token = "0x4009343")]
	[FieldOffset(Offset = "0x1C")]
	public uint banner_id;

	[Token(Token = "0x6007BBC")]
	[Address(RVA = "0x317F228", Offset = "0x317F228", VA = "0x317F228")]
	public CSCreateCupTeamReq()
	{
	}
}
