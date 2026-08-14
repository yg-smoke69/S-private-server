using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001361")]
public class AccountRegionSlice
{
	[Token(Token = "0x40088D1")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x40088D2")]
	[FieldOffset(Offset = "0x10")]
	public string noti_region;

	[Token(Token = "0x40088D3")]
	[FieldOffset(Offset = "0x14")]
	public string lock_region;

	[Token(Token = "0x6007A62")]
	[Address(RVA = "0x3179C2C", Offset = "0x3179C2C", VA = "0x3179C2C")]
	public AccountRegionSlice()
	{
	}
}
