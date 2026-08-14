using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200179B")]
public class ChampionshipWinnerInfo
{
	[Token(Token = "0x4009AB7")]
	[FieldOffset(Offset = "0x8")]
	public uint championship_type;

	[Token(Token = "0x4009AB8")]
	[FieldOffset(Offset = "0xC")]
	public uint championship_id;

	[Token(Token = "0x4009AB9")]
	[FieldOffset(Offset = "0x10")]
	public string region;

	[Token(Token = "0x4009ABA")]
	[FieldOffset(Offset = "0x18")]
	public ulong team_id;

	[Token(Token = "0x6007DF5")]
	[Address(RVA = "0x309B1C4", Offset = "0x309B1C4", VA = "0x309B1C4")]
	public ChampionshipWinnerInfo()
	{
	}
}
