using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001870")]
public class CSRefreshEnergyGachaBuffReq
{
	[Token(Token = "0x4009CF9")]
	[FieldOffset(Offset = "0x8")]
	public uint lottery_id;

	[Token(Token = "0x4009CFA")]
	[FieldOffset(Offset = "0xC")]
	public uint lottery_sub_id;

	[Token(Token = "0x6007EC9")]
	[Address(RVA = "0x3098F78", Offset = "0x3098F78", VA = "0x3098F78")]
	public CSRefreshEnergyGachaBuffReq()
	{
	}
}
