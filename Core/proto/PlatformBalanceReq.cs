using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20013A4")]
public class PlatformBalanceReq
{
	[Token(Token = "0x4008A59")]
	[FieldOffset(Offset = "0x8")]
	public string token;

	[Token(Token = "0x4008A5A")]
	[FieldOffset(Offset = "0xC")]
	public string external_id;

	[Token(Token = "0x4008A5B")]
	[FieldOffset(Offset = "0x10")]
	public uint client_type;

	[Token(Token = "0x4008A5C")]
	[FieldOffset(Offset = "0x14")]
	public uint platform_sdk_id;

	[Token(Token = "0x6007A9F")]
	[Address(RVA = "0x33DF94C", Offset = "0x33DF94C", VA = "0x33DF94C")]
	public PlatformBalanceReq()
	{
	}
}
