using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018CF")]
public class CSGetMocoMonthSettingRes
{
	[Token(Token = "0x4009DDF")]
	[FieldOffset(Offset = "0x8")]
	public MocoMonthSettingDesc setting;

	[Token(Token = "0x4009DE0")]
	[FieldOffset(Offset = "0xC")]
	public List<MocoMonthChatDesc> chat_desc;

	[Token(Token = "0x4009DE1")]
	[FieldOffset(Offset = "0x10")]
	public List<MocoMonthLevelDesc> level_desc;

	[Token(Token = "0x4009DE2")]
	[FieldOffset(Offset = "0x14")]
	public List<MocoMonthLevelRandomDesc> level_random_desc;

	[Token(Token = "0x4009DE3")]
	[FieldOffset(Offset = "0x18")]
	public List<MocoMonthEnemyDesc> enemy_desc;

	[Token(Token = "0x4009DE4")]
	[FieldOffset(Offset = "0x1C")]
	public MocoMonthPlayerDesc player_desc;

	[Token(Token = "0x4009DE5")]
	[FieldOffset(Offset = "0x20")]
	public MocoMonthGameConfigDesc game_config_desc;

	[Token(Token = "0x6007F28")]
	[Address(RVA = "0x3187710", Offset = "0x3187710", VA = "0x3187710")]
	public CSGetMocoMonthSettingRes()
	{
	}
}
