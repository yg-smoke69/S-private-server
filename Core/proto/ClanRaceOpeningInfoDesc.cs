using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A2B")]
public class ClanRaceOpeningInfoDesc
{
	[Token(Token = "0x400A3ED")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400A3EE")]
	[FieldOffset(Offset = "0xC")]
	public uint start_week_day;

	[Token(Token = "0x400A3EF")]
	[FieldOffset(Offset = "0x10")]
	public string start_time;

	[Token(Token = "0x400A3F0")]
	[FieldOffset(Offset = "0x14")]
	public uint end_week_day;

	[Token(Token = "0x400A3F1")]
	[FieldOffset(Offset = "0x18")]
	public string end_time;

	[Token(Token = "0x6008083")]
	[Address(RVA = "0x309BF3C", Offset = "0x309BF3C", VA = "0x309BF3C")]
	public ClanRaceOpeningInfoDesc()
	{
	}
}
