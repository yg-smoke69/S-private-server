using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001597")]
public class CSGetStoreReq
{
	[Token(Token = "0x40093AB")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x40093AC")]
	[FieldOffset(Offset = "0x10")]
	public string lock_region;

	[Token(Token = "0x40093AD")]
	[FieldOffset(Offset = "0x14")]
	public string language;

	[Token(Token = "0x6007BDF")]
	[Address(RVA = "0x30955A4", Offset = "0x30955A4", VA = "0x30955A4")]
	public CSGetStoreReq()
	{
	}
}
