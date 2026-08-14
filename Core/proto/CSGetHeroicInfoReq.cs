using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001545")]
public class CSGetHeroicInfoReq
{
	[Token(Token = "0x4009293")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4009294")]
	[FieldOffset(Offset = "0x10")]
	public bool need_max_rank;

	[Token(Token = "0x6007B8D")]
	[Address(RVA = "0x3185CC8", Offset = "0x3185CC8", VA = "0x3185CC8")]
	public CSGetHeroicInfoReq()
	{
	}
}
