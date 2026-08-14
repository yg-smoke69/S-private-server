using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20013B7")]
public class ClanIDReq
{
	[Token(Token = "0x4008AD6")]
	[FieldOffset(Offset = "0x8")]
	public ulong clan_id;

	[Token(Token = "0x4008AD7")]
	[FieldOffset(Offset = "0x10")]
	public ulong account_id;

	[Token(Token = "0x4008AD8")]
	[FieldOffset(Offset = "0x18")]
	public string lock_region;

	[Token(Token = "0x4008AD9")]
	[FieldOffset(Offset = "0x1C")]
	public string noti_region;

	[Token(Token = "0x6007AA2")]
	[Address(RVA = "0x309B8EC", Offset = "0x309B8EC", VA = "0x309B8EC")]
	public ClanIDReq()
	{
	}
}
