using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A3E")]
public class MMRDecayDesc
{
	[Token(Token = "0x400A45D")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400A45E")]
	[FieldOffset(Offset = "0xC")]
	public uint game_mode;

	[Token(Token = "0x400A45F")]
	[FieldOffset(Offset = "0x10")]
	public bool enable_decay;

	[Token(Token = "0x400A460")]
	[FieldOffset(Offset = "0x14")]
	public uint days_to_mark_decay;

	[Token(Token = "0x400A461")]
	[FieldOffset(Offset = "0x18")]
	public uint decay_basis_per_day;

	[Token(Token = "0x400A462")]
	[FieldOffset(Offset = "0x1C")]
	public uint progressive_factor;

	[Token(Token = "0x400A463")]
	[FieldOffset(Offset = "0x20")]
	public uint decay_stage_in_days;

	[Token(Token = "0x400A464")]
	[FieldOffset(Offset = "0x24")]
	public uint decay_ratio_upperlimit;

	[Token(Token = "0x400A465")]
	[FieldOffset(Offset = "0x28")]
	public uint mmr_lowerlimit_after_decay;

	[Token(Token = "0x6008096")]
	[Address(RVA = "0x30A700C", Offset = "0x30A700C", VA = "0x30A700C")]
	public MMRDecayDesc()
	{
	}
}
