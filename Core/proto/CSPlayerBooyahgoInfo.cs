using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200184C")]
public class CSPlayerBooyahgoInfo
{
	[Token(Token = "0x4009C9E")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4009C9F")]
	[FieldOffset(Offset = "0x10")]
	public uint dice_number;

	[Token(Token = "0x4009CA0")]
	[FieldOffset(Offset = "0x14")]
	public uint current_index;

	[Token(Token = "0x4009CA1")]
	[FieldOffset(Offset = "0x18")]
	public uint total_cycles;

	[Token(Token = "0x4009CA2")]
	[FieldOffset(Offset = "0x1C")]
	public BooyahgoBoard booyahgo_board;

	[Token(Token = "0x4009CA3")]
	[FieldOffset(Offset = "0x20")]
	public List<BooyahgoTriggeredEvent> events;

	[Token(Token = "0x4009CA4")]
	[FieldOffset(Offset = "0x24")]
	public uint current_activity;

	[Token(Token = "0x4009CA5")]
	[FieldOffset(Offset = "0x28")]
	public uint buff_remain_time;

	[Token(Token = "0x4009CA6")]
	[FieldOffset(Offset = "0x2C")]
	public bool under_trap;

	[Token(Token = "0x4009CA7")]
	[FieldOffset(Offset = "0x30")]
	public uint points;

	[Token(Token = "0x4009CA8")]
	[FieldOffset(Offset = "0x34")]
	public uint dice_count;

	[Token(Token = "0x6007EA6")]
	[Address(RVA = "0x3098468", Offset = "0x3098468", VA = "0x3098468")]
	public CSPlayerBooyahgoInfo()
	{
	}
}
