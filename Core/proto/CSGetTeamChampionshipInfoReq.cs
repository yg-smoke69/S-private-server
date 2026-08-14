using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200179F")]
public class CSGetTeamChampionshipInfoReq
{
	[Token(Token = "0x4009AD5")]
	[FieldOffset(Offset = "0x8")]
	public uint championship_type;

	[Token(Token = "0x4009AD6")]
	[FieldOffset(Offset = "0xC")]
	public uint championship_id;

	[Token(Token = "0x6007DF9")]
	[Address(RVA = "0x3095B60", Offset = "0x3095B60", VA = "0x3095B60")]
	public CSGetTeamChampionshipInfoReq()
	{
	}
}
