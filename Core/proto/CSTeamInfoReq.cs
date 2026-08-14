using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001786")]
public class CSTeamInfoReq
{
	[Token(Token = "0x4009A7C")]
	[FieldOffset(Offset = "0x8")]
	public ulong team_id;

	[Token(Token = "0x4009A7D")]
	[FieldOffset(Offset = "0x10")]
	public bool ignore_region;

	[Token(Token = "0x6007DE0")]
	[Address(RVA = "0x309A200", Offset = "0x309A200", VA = "0x309A200")]
	public CSTeamInfoReq()
	{
	}
}
