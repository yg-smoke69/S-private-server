using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200142C")]
public class ERoom
{
	[Token(Token = "0x200142D")]
	public enum Cmd
	{
		[Token(Token = "0x4008C84")]
		Cmd_NONE,
		[Token(Token = "0x4008C85")]
		Cmd_SEND_ALL_ROOMS,
		[Token(Token = "0x4008C86")]
		Cmd_OK
	}

	[Token(Token = "0x200142E")]
	public enum ChangeMatchInfoEvent
	{
		[Token(Token = "0x4008C88")]
		ChangeMatchInfoEvent_NONE,
		[Token(Token = "0x4008C89")]
		ChangeMatchInfoEvent_CHOOSELOADOUTS,
		[Token(Token = "0x4008C8A")]
		ChangeMatchInfoEvent_CHOOSECLOTHES,
		[Token(Token = "0x4008C8B")]
		ChangeMatchInfoEvent_EQUIPSKILLS,
		[Token(Token = "0x4008C8C")]
		ChangeMatchInfoEvent_ROOMCARD
	}

	[Token(Token = "0x200142F")]
	public enum DropPresetState
	{
		[Token(Token = "0x4008C8E")]
		DropPresetState_DEFAULT_OFF_FUNC_OPEN,
		[Token(Token = "0x4008C8F")]
		DropPresetState_DEFAULT_ON_FUNC_OPEN,
		[Token(Token = "0x4008C90")]
		DropPresetState_DEFAULT_OFF_FUNC_CLOSE,
		[Token(Token = "0x4008C91")]
		DropPresetState_DEFAULT_ON_FUNC_CLOSE
	}

	[Token(Token = "0x2001430")]
	public enum WeatherType
	{
		[Token(Token = "0x4008C93")]
		WeatherType_NONE,
		[Token(Token = "0x4008C94")]
		WeatherType_DAY,
		[Token(Token = "0x4008C95")]
		WeatherType_NIGHT
	}

	[Token(Token = "0x2001431")]
	public enum CustomRoomSetting
	{
		[Token(Token = "0x4008C97")]
		CustomRoomSetting_HIDEKILLINFO = 0,
		[Token(Token = "0x4008C98")]
		CustomRoomSetting_UNLIMITEDAMMO = 1,
		[Token(Token = "0x4008C99")]
		CustomRoomSetting_NOFALLINGDAMAGE = 2,
		[Token(Token = "0x4008C9A")]
		CustomRoomSetting_NOLOADOUT = 3,
		[Token(Token = "0x4008C9B")]
		CustomRoomSetting_NOAIRDROP = 4,
		[Token(Token = "0x4008C9C")]
		CustomRoomSetting_NOSKILL = 5,
		[Token(Token = "0x4008C9D")]
		CustomRoomSetting_NOVEHICLE = 6,
		[Token(Token = "0x4008C9E")]
		CustomRoomSetting_PLAYERHP_START = 8,
		[Token(Token = "0x4008C9F")]
		CustomRoomSetting_PLAYERHP_END = 10,
		[Token(Token = "0x4008CA0")]
		CustomRoomSetting_PLAYEREP_START = 11,
		[Token(Token = "0x4008CA1")]
		CustomRoomSetting_PLAYEREP_END = 13,
		[Token(Token = "0x4008CA2")]
		CustomRoomSetting_PLAYERSPEED_START = 14,
		[Token(Token = "0x4008CA3")]
		CustomRoomSetting_PLAYERSPEED_END = 16,
		[Token(Token = "0x4008CA4")]
		CustomRoomSetting_DROPLIST_START = 17,
		[Token(Token = "0x4008CA5")]
		CustomRoomSetting_DROPLIST_END = 20,
		[Token(Token = "0x4008CA6")]
		CustomRoomSetting_PLAYERJUMPHEIGHT_START = 21,
		[Token(Token = "0x4008CA7")]
		CustomRoomSetting_PLAYERJUMPHEIGHT_END = 23,
		[Token(Token = "0x4008CA8")]
		CustomRoomSetting_ACCTOTALSTATS = 24,
		[Token(Token = "0x4008CA9")]
		CustomRoomSetting_ROUNDNUM_START = 25,
		[Token(Token = "0x4008CAA")]
		CustomRoomSetting_ROUNDNUM_END = 26,
		[Token(Token = "0x4008CAB")]
		CustomRoomSetting_INITCOIN_START = 27,
		[Token(Token = "0x4008CAC")]
		CustomRoomSetting_INITCOIN_END = 28,
		[Token(Token = "0x4008CAD")]
		CustomRoomSetting_NOPOWERGUN = 29
	}

	[Token(Token = "0x2001432")]
	public enum CustomRoomSetting2
	{
		[Token(Token = "0x4008CAF")]
		CustomRoomSetting2_NOUAV,
		[Token(Token = "0x4008CB0")]
		CustomRoomSetting2_NOBOMB
	}

	[Token(Token = "0x2001433")]
	public enum Type
	{
		[Token(Token = "0x4008CB2")]
		Type_NONE = 0,
		[Token(Token = "0x4008CB3")]
		Type_CASUAL = 1,
		[Token(Token = "0x4008CB4")]
		Type_LEAGUE_NORMAL = 2,
		[Token(Token = "0x4008CB5")]
		Type_LEAGUE_BATCH = 6,
		[Token(Token = "0x4008CB6")]
		Type_WEREWOLVES = 7,
		[Token(Token = "0x4008CB7")]
		Type_WORKSHOP = 8,
		[Token(Token = "0x4008CB8")]
		Type_RUSHING_PETS = 9
	}

	[Token(Token = "0x2001434")]
	public enum CardType
	{
		[Token(Token = "0x4008CBA")]
		CardType_NONE,
		[Token(Token = "0x4008CBB")]
		CardType_NORMAL,
		[Token(Token = "0x4008CBC")]
		CardType_ADVANCED,
		[Token(Token = "0x4008CBD")]
		CardType_WEREWOLVES,
		[Token(Token = "0x4008CBE")]
		CardType_WORKSHOP,
		[Token(Token = "0x4008CBF")]
		CardType_RUSHING_PETS
	}

	[Token(Token = "0x2001435")]
	public enum CardConsumeType
	{
		[Token(Token = "0x4008CC1")]
		CardConsuemType_NONE,
		[Token(Token = "0x4008CC2")]
		CardConsumeType_TIMELIMITED,
		[Token(Token = "0x4008CC3")]
		CardConsumeType_COUNT,
		[Token(Token = "0x4008CC4")]
		CardConsumeType_WORKSHOP_GENERAL_TIMES,
		[Token(Token = "0x4008CC5")]
		CardConsumeType_WORKSHOP_FREE
	}

	[Token(Token = "0x6007AE7")]
	[Address(RVA = "0x309F8DC", Offset = "0x309F8DC", VA = "0x309F8DC")]
	public ERoom()
	{
	}
}
