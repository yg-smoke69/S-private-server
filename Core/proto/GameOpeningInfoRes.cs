using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019E8")]
public class GameOpeningInfoRes
{
	[Token(Token = "0x400A2B2")]
	[FieldOffset(Offset = "0x8")]
	public GameOpeningInfoDescList opening_info_list;

	[Token(Token = "0x400A2B3")]
	[FieldOffset(Offset = "0x10")]
	public long timezone_offset_secs;

	[Token(Token = "0x400A2B4")]
	[FieldOffset(Offset = "0x18")]
	public GameModeNameList game_mode_name_list;

	[Token(Token = "0x400A2B5")]
	[FieldOffset(Offset = "0x1C")]
	public ModeLevelLimitDescList mode_level_limit_list;

	[Token(Token = "0x400A2B6")]
	[FieldOffset(Offset = "0x20")]
	public RankingLevelLimitDescList ranking_level_limit_list;

	[Token(Token = "0x6008040")]
	[Address(RVA = "0x30A1C88", Offset = "0x30A1C88", VA = "0x30A1C88")]
	public GameOpeningInfoRes()
	{
	}
}
