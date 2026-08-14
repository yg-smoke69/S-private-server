using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20014E1")]
public class BigEventIdReq
{
	[Token(Token = "0x400901A")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x400901B")]
	[FieldOffset(Offset = "0x10")]
	public string lock_region;

	[Token(Token = "0x400901C")]
	[FieldOffset(Offset = "0x14")]
	public string noti_region;

	[Token(Token = "0x400901D")]
	[FieldOffset(Offset = "0x18")]
	public uint event_id;

	[Token(Token = "0x6007B36")]
	[Address(RVA = "0x317C04C", Offset = "0x317C04C", VA = "0x317C04C")]
	public BigEventIdReq()
	{
	}
}
