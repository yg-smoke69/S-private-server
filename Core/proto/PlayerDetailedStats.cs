using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001476")]
public class PlayerDetailedStats
{
	[Token(Token = "0x4008E00")]
	[FieldOffset(Offset = "0x8")]
	public uint deaths;

	[Token(Token = "0x4008E01")]
	[FieldOffset(Offset = "0xC")]
	public uint top10_times;

	[Token(Token = "0x4008E02")]
	[FieldOffset(Offset = "0x10")]
	public uint top_n_times;

	[Token(Token = "0x4008E03")]
	[FieldOffset(Offset = "0x14")]
	public uint distance_travelled;

	[Token(Token = "0x4008E04")]
	[FieldOffset(Offset = "0x18")]
	public uint survival_time;

	[Token(Token = "0x4008E05")]
	[FieldOffset(Offset = "0x1C")]
	public uint revives;

	[Token(Token = "0x4008E06")]
	[FieldOffset(Offset = "0x20")]
	public uint highest_kills;

	[Token(Token = "0x4008E07")]
	[FieldOffset(Offset = "0x24")]
	public uint damage;

	[Token(Token = "0x4008E08")]
	[FieldOffset(Offset = "0x28")]
	public uint road_kills;

	[Token(Token = "0x4008E09")]
	[FieldOffset(Offset = "0x2C")]
	public uint headshots;

	[Token(Token = "0x4008E0A")]
	[FieldOffset(Offset = "0x30")]
	public uint headshot_kills;

	[Token(Token = "0x4008E0B")]
	[FieldOffset(Offset = "0x34")]
	public uint knock_down;

	[Token(Token = "0x4008E0C")]
	[FieldOffset(Offset = "0x38")]
	public uint pick_ups;

	[Token(Token = "0x6007B03")]
	[Address(RVA = "0x33DFFE8", Offset = "0x33DFFE8", VA = "0x33DFFE8")]
	public PlayerDetailedStats()
	{
	}
}
