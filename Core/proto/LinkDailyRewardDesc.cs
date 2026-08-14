using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B1E")]
public class LinkDailyRewardDesc
{
	[Token(Token = "0x400AA75")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400AA76")]
	[FieldOffset(Offset = "0xC")]
	public uint activity_id;

	[Token(Token = "0x400AA77")]
	[FieldOffset(Offset = "0x10")]
	public uint activity_type;

	[Token(Token = "0x400AA78")]
	[FieldOffset(Offset = "0x14")]
	public string start_time;

	[Token(Token = "0x400AA79")]
	[FieldOffset(Offset = "0x18")]
	public string end_time;

	[Token(Token = "0x400AA7A")]
	[FieldOffset(Offset = "0x1C")]
	public uint[] award_ids;

	[Token(Token = "0x6008179")]
	[Address(RVA = "0x30A4BC4", Offset = "0x30A4BC4", VA = "0x30A4BC4")]
	public LinkDailyRewardDesc()
	{
	}
}
