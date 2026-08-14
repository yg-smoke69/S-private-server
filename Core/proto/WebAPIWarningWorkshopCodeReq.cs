using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001946")]
public class WebAPIWarningWorkshopCodeReq
{
	[Token(Token = "0x4009F56")]
	[FieldOffset(Offset = "0x8")]
	public string workshop_code;

	[Token(Token = "0x4009F57")]
	[FieldOffset(Offset = "0xC")]
	public string region;

	[Token(Token = "0x6007F9F")]
	[Address(RVA = "0x33E54BC", Offset = "0x33E54BC", VA = "0x33E54BC")]
	public WebAPIWarningWorkshopCodeReq()
	{
	}
}
