using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001443")]
public class BlacklistOpReq
{
	[Token(Token = "0x4008D0C")]
	[FieldOffset(Offset = "0x8")]
	public EAccount.BlacklistOpType ban_type;

	[Token(Token = "0x4008D0D")]
	[FieldOffset(Offset = "0x10")]
	public ulong account_id;

	[Token(Token = "0x4008D0E")]
	[FieldOffset(Offset = "0x18")]
	public string device_id;

	[Token(Token = "0x4008D0F")]
	[FieldOffset(Offset = "0x1C")]
	public string ban_reason_detail;

	[Token(Token = "0x4008D10")]
	[FieldOffset(Offset = "0x20")]
	public string noti_region;

	[Token(Token = "0x4008D11")]
	[FieldOffset(Offset = "0x24")]
	public EAccount.BanReason ban_reason;

	[Token(Token = "0x4008D12")]
	[FieldOffset(Offset = "0x28")]
	public uint ban_expire_timestamp;

	[Token(Token = "0x6007AF2")]
	[Address(RVA = "0x317C5F8", Offset = "0x317C5F8", VA = "0x317C5F8")]
	public BlacklistOpReq()
	{
	}
}
