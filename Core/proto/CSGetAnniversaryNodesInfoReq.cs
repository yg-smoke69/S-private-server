using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001509")]
public class CSGetAnniversaryNodesInfoReq
{
	[Token(Token = "0x4009092")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4009093")]
	[FieldOffset(Offset = "0x10")]
	public string lock_region;

	[Token(Token = "0x4009094")]
	[FieldOffset(Offset = "0x14")]
	public string noti_region;

	[Token(Token = "0x6007B52")]
	[Address(RVA = "0x31819EC", Offset = "0x31819EC", VA = "0x31819EC")]
	public CSGetAnniversaryNodesInfoReq()
	{
	}
}
