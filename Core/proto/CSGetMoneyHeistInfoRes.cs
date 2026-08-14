using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017FA")]
public class CSGetMoneyHeistInfoRes
{
	[Token(Token = "0x4009BCB")]
	[FieldOffset(Offset = "0x8")]
	public uint speed_from_friend;

	[Token(Token = "0x4009BCC")]
	[FieldOffset(Offset = "0xC")]
	public uint speed_from_task;

	[Token(Token = "0x4009BCD")]
	[FieldOffset(Offset = "0x10")]
	public uint speed_from_tokens;

	[Token(Token = "0x4009BCE")]
	[FieldOffset(Offset = "0x14")]
	public uint[] rewarded;

	[Token(Token = "0x4009BCF")]
	[FieldOffset(Offset = "0x18")]
	public ulong[] help_other;

	[Token(Token = "0x4009BD0")]
	[FieldOffset(Offset = "0x1C")]
	public List<HelpPlayer> be_helped;

	[Token(Token = "0x4009BD1")]
	[FieldOffset(Offset = "0x20")]
	public uint deposit;

	[Token(Token = "0x4009BD2")]
	[FieldOffset(Offset = "0x24")]
	public uint speed_change_time;

	[Token(Token = "0x4009BD3")]
	[FieldOffset(Offset = "0x28")]
	public long reset_time;

	[Token(Token = "0x6007E54")]
	[Address(RVA = "0x31878C4", Offset = "0x31878C4", VA = "0x31878C4")]
	public CSGetMoneyHeistInfoRes()
	{
	}
}
