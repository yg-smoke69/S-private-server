using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200193D")]
public class CSFFVoiceReportReq
{
	[Token(Token = "0x4009F2F")]
	[FieldOffset(Offset = "0x8")]
	public ulong report_action_id;

	[Token(Token = "0x4009F30")]
	[FieldOffset(Offset = "0x10")]
	public uint behavior_rule_id;

	[Token(Token = "0x4009F31")]
	[FieldOffset(Offset = "0x14")]
	public ulong[] reporter_account_ids;

	[Token(Token = "0x4009F32")]
	[FieldOffset(Offset = "0x18")]
	public ulong[] need_noti_account_ids;

	[Token(Token = "0x4009F33")]
	[FieldOffset(Offset = "0x20")]
	public long mute_mic_expire_time;

	[Token(Token = "0x4009F34")]
	[FieldOffset(Offset = "0x28")]
	public ulong match_id;

	[Token(Token = "0x4009F35")]
	[FieldOffset(Offset = "0x30")]
	public long match_create_time;

	[Token(Token = "0x4009F36")]
	[FieldOffset(Offset = "0x38")]
	public long report_time;

	[Token(Token = "0x6007F96")]
	[Address(RVA = "0x317FF5C", Offset = "0x317FF5C", VA = "0x317FF5C")]
	public CSFFVoiceReportReq()
	{
	}
}
