using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001444")]
public class BlacklistReq
{
	[Token(Token = "0x4008D13")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4008D14")]
	[FieldOffset(Offset = "0x10")]
	public string device_id;

	[Token(Token = "0x4008D15")]
	[FieldOffset(Offset = "0x14")]
	public string lock_region;

	[Token(Token = "0x4008D16")]
	[FieldOffset(Offset = "0x18")]
	public string noti_region;

	[Token(Token = "0x6007AF3")]
	[Address(RVA = "0x317C6B0", Offset = "0x317C6B0", VA = "0x317C6B0")]
	public BlacklistReq()
	{
	}
}
