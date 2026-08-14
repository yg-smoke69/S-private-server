using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A35")]
public class ClanWarOpeningInfoDesc
{
	[Token(Token = "0x400A41D")]
	[FieldOffset(Offset = "0x8")]
	public uint season_id;

	[Token(Token = "0x400A41E")]
	[FieldOffset(Offset = "0xC")]
	public EClan.ClanWarPhaseType phase_type;

	[Token(Token = "0x400A41F")]
	[FieldOffset(Offset = "0x10")]
	public long start_time;

	[Token(Token = "0x400A420")]
	[FieldOffset(Offset = "0x18")]
	public long end_time;

	[Token(Token = "0x600808D")]
	[Address(RVA = "0x309C3B0", Offset = "0x309C3B0", VA = "0x309C3B0")]
	public ClanWarOpeningInfoDesc()
	{
	}
}
