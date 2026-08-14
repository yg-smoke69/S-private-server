using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001445")]
public class BlacklistRes
{
	[Token(Token = "0x4008D17")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4008D18")]
	[FieldOffset(Offset = "0x10")]
	public string device_id;

	[Token(Token = "0x4008D19")]
	[FieldOffset(Offset = "0x14")]
	public uint ban_reason;

	[Token(Token = "0x4008D1A")]
	[FieldOffset(Offset = "0x18")]
	public uint ban_time;

	[Token(Token = "0x4008D1B")]
	[FieldOffset(Offset = "0x1C")]
	public string ban_reason_detail;

	[Token(Token = "0x4008D1C")]
	[FieldOffset(Offset = "0x20")]
	public bool is_in_blacklist;

	[Token(Token = "0x4008D1D")]
	[FieldOffset(Offset = "0x24")]
	public uint ban_expire_duration;

	[Token(Token = "0x6007AF4")]
	[Address(RVA = "0x317C768", Offset = "0x317C768", VA = "0x317C768")]
	public BlacklistRes()
	{
	}
}
