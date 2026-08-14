using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018C3")]
public class CSGetMusicFestSettingRes
{
	[Token(Token = "0x4009DC8")]
	[FieldOffset(Offset = "0x8")]
	public MusicFestSettingDesc setting;

	[Token(Token = "0x4009DC9")]
	[FieldOffset(Offset = "0xC")]
	public List<MusicFestCardDesc> music_fest_card_desc_list;

	[Token(Token = "0x4009DCA")]
	[FieldOffset(Offset = "0x10")]
	public List<MusicFestCardRewardDesc> music_fest_card_reward_desc_list;

	[Token(Token = "0x4009DCB")]
	[FieldOffset(Offset = "0x14")]
	public List<MusicFestSignInDesc> sign_in_desc_list;

	[Token(Token = "0x4009DCC")]
	[FieldOffset(Offset = "0x18")]
	public List<MusicFestPuzzleDesc> puzzle_desc_list;

	[Token(Token = "0x4009DCD")]
	[FieldOffset(Offset = "0x1C")]
	public List<MusicFestPuzzleProgressDesc> puzzle_progress_desc_list;

	[Token(Token = "0x4009DCE")]
	[FieldOffset(Offset = "0x20")]
	public List<MusicFestGachaConditionDesc> gacha_condition_desc_list;

	[Token(Token = "0x6007F1C")]
	[Address(RVA = "0x3187B64", Offset = "0x3187B64", VA = "0x3187B64")]
	public CSGetMusicFestSettingRes()
	{
	}
}
