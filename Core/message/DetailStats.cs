using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2001C3D")]
public class DetailStats
{
	[Token(Token = "0x400B400")]
	[FieldOffset(Offset = "0x8")]
	public uint deaths;

	[Token(Token = "0x400B401")]
	[FieldOffset(Offset = "0xC")]
	public uint top10_times;

	[Token(Token = "0x400B402")]
	[FieldOffset(Offset = "0x10")]
	public uint top_n_times;

	[Token(Token = "0x400B403")]
	[FieldOffset(Offset = "0x14")]
	public uint distance_travelled;

	[Token(Token = "0x400B404")]
	[FieldOffset(Offset = "0x18")]
	public uint survival_time;

	[Token(Token = "0x400B405")]
	[FieldOffset(Offset = "0x1C")]
	public uint revives;

	[Token(Token = "0x400B406")]
	[FieldOffset(Offset = "0x20")]
	public uint highest_kills;

	[Token(Token = "0x400B407")]
	[FieldOffset(Offset = "0x24")]
	public uint damage;

	[Token(Token = "0x400B408")]
	[FieldOffset(Offset = "0x28")]
	public uint road_kills;

	[Token(Token = "0x400B409")]
	[FieldOffset(Offset = "0x2C")]
	public uint headshots;

	[Token(Token = "0x400B40A")]
	[FieldOffset(Offset = "0x30")]
	public uint headshot_kills;

	[Token(Token = "0x400B40B")]
	[FieldOffset(Offset = "0x34")]
	public uint knock_down;

	[Token(Token = "0x400B40C")]
	[FieldOffset(Offset = "0x38")]
	public uint pick_ups;

	[Token(Token = "0x6008294")]
	[Address(RVA = "0x362328C", Offset = "0x362328C", VA = "0x362328C")]
	public DetailStats()
	{
	}
}
