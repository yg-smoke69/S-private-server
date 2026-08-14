using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001844")]
public class CSPlayerMonopolyInfo
{
	[Token(Token = "0x4009C88")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4009C89")]
	[FieldOffset(Offset = "0x10")]
	public uint dice_number;

	[Token(Token = "0x4009C8A")]
	[FieldOffset(Offset = "0x14")]
	public EMiniGame.MonopolyPlayerStatus player_status;

	[Token(Token = "0x4009C8B")]
	[FieldOffset(Offset = "0x18")]
	public uint current_index;

	[Token(Token = "0x4009C8C")]
	[FieldOffset(Offset = "0x1C")]
	public uint total_cycles;

	[Token(Token = "0x4009C8D")]
	[FieldOffset(Offset = "0x20")]
	public MonopolyBoard monopoly_board;

	[Token(Token = "0x4009C8E")]
	[FieldOffset(Offset = "0x24")]
	public List<TriggeredEvent> events;

	[Token(Token = "0x4009C8F")]
	[FieldOffset(Offset = "0x28")]
	public uint current_event;

	[Token(Token = "0x4009C90")]
	[FieldOffset(Offset = "0x2C")]
	public uint current_activity;

	[Token(Token = "0x4009C91")]
	[FieldOffset(Offset = "0x30")]
	public uint buff_remain_time;

	[Token(Token = "0x6007E9E")]
	[Address(RVA = "0x3098514", Offset = "0x3098514", VA = "0x3098514")]
	public CSPlayerMonopolyInfo()
	{
	}
}
