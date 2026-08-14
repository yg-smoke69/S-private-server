using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AF3")]
public class ChampionshipOpenInfoDesc
{
	[Token(Token = "0x400A95A")]
	[FieldOffset(Offset = "0x8")]
	public uint championship_type;

	[Token(Token = "0x400A95B")]
	[FieldOffset(Offset = "0xC")]
	public uint championship_id;

	[Token(Token = "0x400A95C")]
	[FieldOffset(Offset = "0x10")]
	public long season_start_time;

	[Token(Token = "0x400A95D")]
	[FieldOffset(Offset = "0x18")]
	public long season_end_time;

	[Token(Token = "0x400A95E")]
	[FieldOffset(Offset = "0x20")]
	public long trial_start_time;

	[Token(Token = "0x400A95F")]
	[FieldOffset(Offset = "0x28")]
	public long trial_end_time;

	[Token(Token = "0x400A960")]
	[FieldOffset(Offset = "0x30")]
	public long final_start_time;

	[Token(Token = "0x400A961")]
	[FieldOffset(Offset = "0x38")]
	public long final_end_time;

	[Token(Token = "0x400A962")]
	[FieldOffset(Offset = "0x40")]
	public string map_id;

	[Token(Token = "0x400A963")]
	[FieldOffset(Offset = "0x48")]
	public long entrance_open_time;

	[Token(Token = "0x400A964")]
	[FieldOffset(Offset = "0x50")]
	public long entrance_end_time;

	[Token(Token = "0x600814E")]
	[Address(RVA = "0x309AF34", Offset = "0x309AF34", VA = "0x309AF34")]
	public ChampionshipOpenInfoDesc()
	{
	}
}
