using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200160D")]
public class CSFlipBingoReq
{
	[Token(Token = "0x40094E6")]
	[FieldOffset(Offset = "0x8")]
	public uint activity_id;

	[Token(Token = "0x40094E7")]
	[FieldOffset(Offset = "0xC")]
	public string language;

	[Token(Token = "0x6007C57")]
	[Address(RVA = "0x3180760", Offset = "0x3180760", VA = "0x3180760")]
	public CSFlipBingoReq()
	{
	}
}
