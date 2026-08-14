using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BBD")]
public class MusicFestPuzzleDesc
{
	[Token(Token = "0x400AE9F")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400AEA0")]
	[FieldOffset(Offset = "0xC")]
	public string range_name;

	[Token(Token = "0x400AEA1")]
	[FieldOffset(Offset = "0x10")]
	public uint range_pace_num;

	[Token(Token = "0x400AEA2")]
	[FieldOffset(Offset = "0x14")]
	public uint range_pace_id;

	[Token(Token = "0x400AEA3")]
	[FieldOffset(Offset = "0x18")]
	public AwardDesc award;

	[Token(Token = "0x6008218")]
	[Address(RVA = "0x30A92F4", Offset = "0x30A92F4", VA = "0x30A92F4")]
	public MusicFestPuzzleDesc()
	{
	}
}
