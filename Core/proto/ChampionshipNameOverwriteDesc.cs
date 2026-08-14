using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AFB")]
public class ChampionshipNameOverwriteDesc
{
	[Token(Token = "0x400A9B7")]
	[FieldOffset(Offset = "0x8")]
	public uint championship_type;

	[Token(Token = "0x400A9B8")]
	[FieldOffset(Offset = "0xC")]
	public uint championship_id;

	[Token(Token = "0x400A9B9")]
	[FieldOffset(Offset = "0x10")]
	public uint name_type;

	[Token(Token = "0x400A9BA")]
	[FieldOffset(Offset = "0x14")]
	public string language;

	[Token(Token = "0x400A9BB")]
	[FieldOffset(Offset = "0x18")]
	public string content;

	[Token(Token = "0x6008156")]
	[Address(RVA = "0x309AE88", Offset = "0x309AE88", VA = "0x309AE88")]
	public ChampionshipNameOverwriteDesc()
	{
	}
}
