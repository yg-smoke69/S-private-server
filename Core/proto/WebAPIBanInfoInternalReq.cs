using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001944")]
public class WebAPIBanInfoInternalReq
{
	[Token(Token = "0x4009F4C")]
	[FieldOffset(Offset = "0x8")]
	public string env;

	[Token(Token = "0x4009F4D")]
	[FieldOffset(Offset = "0x10")]
	public ulong account_id;

	[Token(Token = "0x4009F4E")]
	[FieldOffset(Offset = "0x18")]
	public long expire_at;

	[Token(Token = "0x4009F4F")]
	[FieldOffset(Offset = "0x20")]
	public string ban_reason;

	[Token(Token = "0x4009F50")]
	[FieldOffset(Offset = "0x24")]
	public string ban_message;

	[Token(Token = "0x4009F51")]
	[FieldOffset(Offset = "0x28")]
	public string operator_id;

	[Token(Token = "0x4009F52")]
	[FieldOffset(Offset = "0x2C")]
	public string lock_region;

	[Token(Token = "0x4009F53")]
	[FieldOffset(Offset = "0x30")]
	public string noti_region;

	[Token(Token = "0x6007F9D")]
	[Address(RVA = "0x33E5340", Offset = "0x33E5340", VA = "0x33E5340")]
	public WebAPIBanInfoInternalReq()
	{
	}
}
