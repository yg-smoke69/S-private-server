using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018EC")]
public class CSSubscribeWorkshopCodeRes
{
	[Token(Token = "0x4009E37")]
	[FieldOffset(Offset = "0x8")]
	public WorkshopBasicInfo workshop_basic_info;

	[Token(Token = "0x4009E38")]
	[FieldOffset(Offset = "0xC")]
	public string workshop_code;

	[Token(Token = "0x6007F45")]
	[Address(RVA = "0x3099F64", Offset = "0x3099F64", VA = "0x3099F64")]
	public CSSubscribeWorkshopCodeRes()
	{
	}
}
