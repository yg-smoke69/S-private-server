using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001626")]
public class CSClanInfoReq
{
	[Token(Token = "0x4009540")]
	[FieldOffset(Offset = "0x8")]
	public ulong clan_id;

	[Token(Token = "0x4009541")]
	[FieldOffset(Offset = "0x10")]
	public bool ignore_region;

	[Token(Token = "0x6007C70")]
	[Address(RVA = "0x317EBF4", Offset = "0x317EBF4", VA = "0x317EBF4")]
	public CSClanInfoReq()
	{
	}
}
