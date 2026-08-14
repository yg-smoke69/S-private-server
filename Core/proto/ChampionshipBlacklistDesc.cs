using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AFC")]
public class ChampionshipBlacklistDesc
{
	[Token(Token = "0x400A9BC")]
	[FieldOffset(Offset = "0x8")]
	public uint championship_type;

	[Token(Token = "0x400A9BD")]
	[FieldOffset(Offset = "0xC")]
	public uint championship_id;

	[Token(Token = "0x400A9BE")]
	[FieldOffset(Offset = "0x10")]
	public ulong account_id;

	[Token(Token = "0x6008157")]
	[Address(RVA = "0x309ADF4", Offset = "0x309ADF4", VA = "0x309ADF4")]
	public ChampionshipBlacklistDesc()
	{
	}
}
