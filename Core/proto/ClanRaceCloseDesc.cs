using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A2D")]
public class ClanRaceCloseDesc
{
	[Token(Token = "0x400A3F4")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400A3F5")]
	[FieldOffset(Offset = "0xC")]
	public string start_time;

	[Token(Token = "0x400A3F6")]
	[FieldOffset(Offset = "0x10")]
	public string end_time;

	[Token(Token = "0x6008085")]
	[Address(RVA = "0x309BE7C", Offset = "0x309BE7C", VA = "0x309BE7C")]
	public ClanRaceCloseDesc()
	{
	}
}
