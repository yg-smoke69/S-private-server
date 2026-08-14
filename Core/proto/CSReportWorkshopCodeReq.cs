using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018ED")]
public class CSReportWorkshopCodeReq
{
	[Token(Token = "0x4009E39")]
	[FieldOffset(Offset = "0x8")]
	public uint report_type;

	[Token(Token = "0x4009E3A")]
	[FieldOffset(Offset = "0xC")]
	public string workshop_code;

	[Token(Token = "0x4009E3B")]
	[FieldOffset(Offset = "0x10")]
	public uint report_channel;

	[Token(Token = "0x6007F46")]
	[Address(RVA = "0x3099490", Offset = "0x3099490", VA = "0x3099490")]
	public CSReportWorkshopCodeReq()
	{
	}
}
