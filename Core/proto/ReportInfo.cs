using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001373")]
public class ReportInfo
{
	[Token(Token = "0x4008987")]
	[FieldOffset(Offset = "0x8")]
	public ulong offender_id;

	[Token(Token = "0x4008988")]
	[FieldOffset(Offset = "0x10")]
	public string offender_nickname;

	[Token(Token = "0x4008989")]
	[FieldOffset(Offset = "0x14")]
	public List<PunishRecord> punish_records;

	[Token(Token = "0x400898A")]
	[FieldOffset(Offset = "0x18")]
	public ulong match_id;

	[Token(Token = "0x400898B")]
	[FieldOffset(Offset = "0x20")]
	public long match_create_time;

	[Token(Token = "0x400898C")]
	[FieldOffset(Offset = "0x28")]
	public long report_time;

	[Token(Token = "0x400898D")]
	[FieldOffset(Offset = "0x30")]
	public long mute_mic_expire_time;

	[Token(Token = "0x6007A74")]
	[Address(RVA = "0x33E1884", Offset = "0x33E1884", VA = "0x33E1884")]
	public ReportInfo()
	{
	}
}
