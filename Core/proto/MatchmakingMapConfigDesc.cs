using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019E9")]
public class MatchmakingMapConfigDesc
{
	[Token(Token = "0x400A2B7")]
	[FieldOffset(Offset = "0x8")]
	public uint match_mode;

	[Token(Token = "0x400A2B8")]
	[FieldOffset(Offset = "0xC")]
	public uint game_mode;

	[Token(Token = "0x400A2B9")]
	[FieldOffset(Offset = "0x10")]
	public uint map_id;

	[Token(Token = "0x400A2BA")]
	[FieldOffset(Offset = "0x14")]
	public uint map_priority;

	[Token(Token = "0x400A2BB")]
	[FieldOffset(Offset = "0x18")]
	public uint map_weight;

	[Token(Token = "0x400A2BC")]
	[FieldOffset(Offset = "0x1C")]
	public uint new_map_priority;

	[Token(Token = "0x400A2BD")]
	[FieldOffset(Offset = "0x20")]
	public uint map_degrade_time;

	[Token(Token = "0x400A2BE")]
	[FieldOffset(Offset = "0x24")]
	public string start_time;

	[Token(Token = "0x400A2BF")]
	[FieldOffset(Offset = "0x28")]
	public string end_time;

	[Token(Token = "0x400A2C0")]
	[FieldOffset(Offset = "0x30")]
	public long config_start_timestamp;

	[Token(Token = "0x400A2C1")]
	[FieldOffset(Offset = "0x38")]
	public long config_end_timestamp;

	[Token(Token = "0x6008041")]
	[Address(RVA = "0x30A858C", Offset = "0x30A858C", VA = "0x30A858C")]
	public MatchmakingMapConfigDesc()
	{
	}
}
