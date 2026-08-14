using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001636")]
public class CSExchangeAwardWithRPReq
{
	[Token(Token = "0x400956D")]
	[FieldOffset(Offset = "0x8")]
	public ulong clan_id;

	[Token(Token = "0x400956E")]
	[FieldOffset(Offset = "0x10")]
	public uint stage;

	[Token(Token = "0x6007C80")]
	[Address(RVA = "0x317FE70", Offset = "0x317FE70", VA = "0x317FE70")]
	public CSExchangeAwardWithRPReq()
	{
	}
}
