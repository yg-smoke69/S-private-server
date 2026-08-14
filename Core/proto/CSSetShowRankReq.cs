using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200153E")]
public class CSSetShowRankReq
{
	[Token(Token = "0x4009284")]
	[FieldOffset(Offset = "0x8")]
	public uint season_id;

	[Token(Token = "0x4009285")]
	[FieldOffset(Offset = "0xC")]
	public bool show_rank;

	[Token(Token = "0x6007B86")]
	[Address(RVA = "0x3099B58", Offset = "0x3099B58", VA = "0x3099B58")]
	public CSSetShowRankReq()
	{
	}
}
