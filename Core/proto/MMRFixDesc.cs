using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019DF")]
public class MMRFixDesc
{
	[Token(Token = "0x400A268")]
	[FieldOffset(Offset = "0x8")]
	public uint mmr_fix_id;

	[Token(Token = "0x400A269")]
	[FieldOffset(Offset = "0xC")]
	public uint mmr_start;

	[Token(Token = "0x400A26A")]
	[FieldOffset(Offset = "0x10")]
	public uint mmr_end;

	[Token(Token = "0x400A26B")]
	[FieldOffset(Offset = "0x14")]
	public uint base_mmr_delta_up;

	[Token(Token = "0x400A26C")]
	[FieldOffset(Offset = "0x18")]
	public uint base_mmr_delta_down;

	[Token(Token = "0x400A26D")]
	[FieldOffset(Offset = "0x1C")]
	public List<MatchmakingTimeMMRRangeItem> ranges;

	[Token(Token = "0x400A26E")]
	[FieldOffset(Offset = "0x20")]
	public uint mm_timeout;

	[Token(Token = "0x400A26F")]
	[FieldOffset(Offset = "0x24")]
	public uint begin_add_player_time;

	[Token(Token = "0x400A270")]
	[FieldOffset(Offset = "0x28")]
	public uint stop_add_player_time;

	[Token(Token = "0x6008037")]
	[Address(RVA = "0x30A70AC", Offset = "0x30A70AC", VA = "0x30A70AC")]
	public MMRFixDesc()
	{
	}
}
