using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001606")]
public class CSGetActivityDescRes
{
	[Token(Token = "0x40094D4")]
	[FieldOffset(Offset = "0x8")]
	public List<ClientActivityDesc> activity_descs;

	[Token(Token = "0x40094D5")]
	[FieldOffset(Offset = "0xC")]
	public List<ActivityFestivalDesc> activity_festivals;

	[Token(Token = "0x40094D6")]
	[FieldOffset(Offset = "0x10")]
	public List<ClientActivityEntranceSwitchDesc> entrance_list;

	[Token(Token = "0x40094D7")]
	[FieldOffset(Offset = "0x14")]
	public List<ClientActivityBingoInfoDesc> bingo_info;

	[Token(Token = "0x40094D8")]
	[FieldOffset(Offset = "0x18")]
	public List<ActivityBingoRewardsDesc> bingo_rewards_info;

	[Token(Token = "0x40094D9")]
	[FieldOffset(Offset = "0x1C")]
	public List<EventIntegretPageDesc> event_integret_pages;

	[Token(Token = "0x40094DA")]
	[FieldOffset(Offset = "0x20")]
	public List<LobbyGameEnterStyleDesc> lobby_game_enter_styles;

	[Token(Token = "0x6007C50")]
	[Address(RVA = "0x3181064", Offset = "0x3181064", VA = "0x3181064")]
	public CSGetActivityDescRes()
	{
	}
}
