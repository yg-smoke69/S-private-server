using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20014FF")]
public class CSGetAccountInfoReq
{
	[Token(Token = "0x400907F")]
	[FieldOffset(Offset = "0x8")]
	public int input_type;

	[Token(Token = "0x4009080")]
	[FieldOffset(Offset = "0xC")]
	public string input_value;

	[Token(Token = "0x6007B48")]
	[Address(RVA = "0x3180CA8", Offset = "0x3180CA8", VA = "0x3180CA8")]
	public CSGetAccountInfoReq()
	{
	}
}
