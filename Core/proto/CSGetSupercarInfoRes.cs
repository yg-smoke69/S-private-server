using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001829")]
public class CSGetSupercarInfoRes
{
	[Token(Token = "0x4009C31")]
	[FieldOffset(Offset = "0x8")]
	public uint car_id;

	[Token(Token = "0x4009C32")]
	[FieldOffset(Offset = "0xC")]
	public uint exchange_tokens;

	[Token(Token = "0x4009C33")]
	[FieldOffset(Offset = "0x10")]
	public uint rewarded_to;

	[Token(Token = "0x4009C34")]
	[FieldOffset(Offset = "0x14")]
	public List<SupercarHelpPlayer> helpers;

	[Token(Token = "0x4009C35")]
	[FieldOffset(Offset = "0x18")]
	public uint drive_sum;

	[Token(Token = "0x4009C36")]
	[FieldOffset(Offset = "0x20")]
	public long update_time;

	[Token(Token = "0x4009C37")]
	[FieldOffset(Offset = "0x28")]
	public long next_reset_time;

	[Token(Token = "0x6007E83")]
	[Address(RVA = "0x3095954", Offset = "0x3095954", VA = "0x3095954")]
	public CSGetSupercarInfoRes()
	{
	}
}
