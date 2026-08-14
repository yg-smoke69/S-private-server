using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20013B9")]
public class AccountRegionReq
{
	[Token(Token = "0x4008ADB")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4008ADC")]
	[FieldOffset(Offset = "0x10")]
	public string lock_region;

	[Token(Token = "0x4008ADD")]
	[FieldOffset(Offset = "0x14")]
	public string noti_region;

	[Token(Token = "0x6007AA4")]
	[Address(RVA = "0x3179B80", Offset = "0x3179B80", VA = "0x3179B80")]
	public AccountRegionReq()
	{
	}
}
