using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001365")]
public class DelAccountReq
{
	[Token(Token = "0x40088D7")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x40088D8")]
	[FieldOffset(Offset = "0x10")]
	public string external_id;

	[Token(Token = "0x40088D9")]
	[FieldOffset(Offset = "0x14")]
	public uint external_type;

	[Token(Token = "0x40088DA")]
	[FieldOffset(Offset = "0x18")]
	public string lock_region;

	[Token(Token = "0x40088DB")]
	[FieldOffset(Offset = "0x1C")]
	public uint plat_id;

	[Token(Token = "0x40088DC")]
	[FieldOffset(Offset = "0x20")]
	public string noti_region;

	[Token(Token = "0x6007A66")]
	[Address(RVA = "0x309E618", Offset = "0x309E618", VA = "0x309E618")]
	public DelAccountReq()
	{
	}
}
