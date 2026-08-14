using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A66")]
public class RankMasterLevel
{
	[Token(Token = "0x400A53F")]
	[FieldOffset(Offset = "0x8")]
	public uint rank_master_level;

	[Token(Token = "0x400A540")]
	[FieldOffset(Offset = "0xC")]
	public uint lower_bound;

	[Token(Token = "0x400A541")]
	[FieldOffset(Offset = "0x10")]
	public uint upper_bound;

	[Token(Token = "0x400A542")]
	[FieldOffset(Offset = "0x14")]
	public uint season_id;

	[Token(Token = "0x60080C3")]
	[Address(RVA = "0x33E09A8", Offset = "0x33E09A8", VA = "0x33E09A8")]
	public RankMasterLevel()
	{
	}
}
