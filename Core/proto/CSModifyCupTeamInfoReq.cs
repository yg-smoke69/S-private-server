using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001582")]
public class CSModifyCupTeamInfoReq
{
	[Token(Token = "0x400935C")]
	[FieldOffset(Offset = "0x8")]
	public ulong team_id;

	[Token(Token = "0x400935D")]
	[FieldOffset(Offset = "0x10")]
	public string team_name;

	[Token(Token = "0x400935E")]
	[FieldOffset(Offset = "0x14")]
	public string country_or_area;

	[Token(Token = "0x400935F")]
	[FieldOffset(Offset = "0x18")]
	public uint head_pic;

	[Token(Token = "0x4009360")]
	[FieldOffset(Offset = "0x1C")]
	public uint banner_id;

	[Token(Token = "0x6007BCA")]
	[Address(RVA = "0x3097C98", Offset = "0x3097C98", VA = "0x3097C98")]
	public CSModifyCupTeamInfoReq()
	{
	}
}
