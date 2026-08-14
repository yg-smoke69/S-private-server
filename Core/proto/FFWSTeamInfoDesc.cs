using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B8B")]
public class FFWSTeamInfoDesc
{
	[Token(Token = "0x400AD42")]
	[FieldOffset(Offset = "0x8")]
	public uint team_id;

	[Token(Token = "0x400AD43")]
	[FieldOffset(Offset = "0xC")]
	public string team_icon;

	[Token(Token = "0x400AD44")]
	[FieldOffset(Offset = "0x10")]
	public uint weight;

	[Token(Token = "0x400AD45")]
	[FieldOffset(Offset = "0x14")]
	public string url;

	[Token(Token = "0x400AD46")]
	[FieldOffset(Offset = "0x18")]
	public string team_name;

	[Token(Token = "0x60081E6")]
	[Address(RVA = "0x30A08A4", Offset = "0x30A08A4", VA = "0x30A08A4")]
	public FFWSTeamInfoDesc()
	{
	}
}
