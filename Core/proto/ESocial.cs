using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200148E")]
public class ESocial
{
	[Token(Token = "0x200148F")]
	public enum PlayerBattleTagID
	{
		[Token(Token = "0x4008E86")]
		PlayerBattleTagID_NONE = 0,
		[Token(Token = "0x4008E87")]
		PlayerBattleTagID_DOMINATION = 1101,
		[Token(Token = "0x4008E88")]
		PlayerBattleTagID_UNCROWN = 1102,
		[Token(Token = "0x4008E89")]
		PlayerBattleTagID_BESTPARTNER = 1103,
		[Token(Token = "0x4008E8A")]
		PlayerBattleTagID_SNIPER = 1104,
		[Token(Token = "0x4008E8B")]
		PlayerBattleTagID_MELEE = 1105,
		[Token(Token = "0x4008E8C")]
		PlayerBattleTagID_PEACEMAKER = 1106,
		[Token(Token = "0x4008E8D")]
		PlayerBattleTagID_AMBUSH = 1107,
		[Token(Token = "0x4008E8E")]
		PlayerBattleTagID_SHORTSTOP = 1108,
		[Token(Token = "0x4008E8F")]
		PlayerBattleTagID_RAMPAGE = 1109,
		[Token(Token = "0x4008E90")]
		PlayerBattleTagID_LEADER = 1110
	}

	[Token(Token = "0x2001490")]
	public enum PlayerBattleTagCdtType
	{
		[Token(Token = "0x4008E92")]
		PlayerBattleTagCdtType_NONE = 0,
		[Token(Token = "0x4008E93")]
		PlayerBattleTagCdtType_BR_RANK_LARGER = 100101,
		[Token(Token = "0x4008E94")]
		PlayerBattleTagCdtType_BR_RANK_SMALLER = 100102,
		[Token(Token = "0x4008E95")]
		PlayerBattleTagCdtType_BR_LAST_ELIMINATED = 100201,
		[Token(Token = "0x4008E96")]
		PlayerBattleTagCdtType_BR_KILL_LARGER = 100501,
		[Token(Token = "0x4008E97")]
		PlayerBattleTagCdtType_BR_KILL_SMALLER = 100502,
		[Token(Token = "0x4008E98")]
		PlayerBattleTagCdtType_BR_DAMAGE_LARGER = 100601,
		[Token(Token = "0x4008E99")]
		PlayerBattleTagCdtType_BR_DAMAGE_SMALLER = 100602,
		[Token(Token = "0x4008E9A")]
		PlayerBattleTagCdtType_BR_ASSIST_LARGER = 100701,
		[Token(Token = "0x4008E9B")]
		PlayerBattleTagCdtType_BR_ASSIST_SMALLER = 100702,
		[Token(Token = "0x4008E9C")]
		PlayerBattleTagCdtType_BR_REVIVE_LARGER = 100801,
		[Token(Token = "0x4008E9D")]
		PlayerBattleTagCdtType_BR_REVIVE_SMALLER = 100802,
		[Token(Token = "0x4008E9E")]
		PlayerBattleTagCdtType_BR_DISTANCE_LARGER_PER_MINIUE = 100901,
		[Token(Token = "0x4008E9F")]
		PlayerBattleTagCdtType_BR_DISTANCE_SMALLER_PER_MINIUE = 100902,
		[Token(Token = "0x4008EA0")]
		PlayerBattleTagCdtType_BR_DISTANCE_LARGER = 101001,
		[Token(Token = "0x4008EA1")]
		PlayerBattleTagCdtType_BR_DISTANCE_SMALLER = 101002,
		[Token(Token = "0x4008EA2")]
		PlayerBattleTagCdtType_BR_TripleKill_LARGER = 101101,
		[Token(Token = "0x4008EA3")]
		PlayerBattleTagCdtType_BR_QuadraKill_LARGER = 101102,
		[Token(Token = "0x4008EA4")]
		PlayerBattleTagCdtType_CS_WIN = 200101,
		[Token(Token = "0x4008EA5")]
		PlayerBattleTagCdtType_CS_KILL_MAX = 200201,
		[Token(Token = "0x4008EA6")]
		PlayerBattleTagCdtType_CS_DAMAGE_MAX = 200301,
		[Token(Token = "0x4008EA7")]
		PlayerBattleTagCdtType_CS_DEATH_PER_ROUND_LARGER = 200401,
		[Token(Token = "0x4008EA8")]
		PlayerBattleTagCdtType_CS_DEATH_PER_ROUND_SMALLER = 200402,
		[Token(Token = "0x4008EA9")]
		PlayerBattleTagCdtType_CS_KILL_PER_ROUND_LARGER = 200501,
		[Token(Token = "0x4008EAA")]
		PlayerBattleTagCdtType_CS_KILL_PER_ROUND_SMALLER = 200502,
		[Token(Token = "0x4008EAB")]
		PlayerBattleTagCdtType_CS_DAMAGE_PER_ROUND_LARGER = 200601,
		[Token(Token = "0x4008EAC")]
		PlayerBattleTagCdtType_CS_DAMAGE_PER_ROUND_SMALLER = 200602,
		[Token(Token = "0x4008EAD")]
		PlayerBattleTagCdtType_CS_ASSIST_PER_ROUND_LARGER = 200701,
		[Token(Token = "0x4008EAE")]
		PlayerBattleTagCdtType_CS_ASSIST_PER_ROUND_SMALLER = 200702,
		[Token(Token = "0x4008EAF")]
		PlayerBattleTagCdtType_CS_REVIVE_PER_ROUND_LARGER = 200801,
		[Token(Token = "0x4008EB0")]
		PlayerBattleTagCdtType_CS_REVIVE_PER_ROUND_SMALLER = 200802,
		[Token(Token = "0x4008EB1")]
		PlayerBattleTagCdtType_CS_DISTANCE_LARGER = 201001,
		[Token(Token = "0x4008EB2")]
		PlayerBattleTagCdtType_CS_DISTANCE_SMALLER = 201002,
		[Token(Token = "0x4008EB3")]
		PlayerBattleTagCdtType_CS_WinAverageKill_LARGER = 201301,
		[Token(Token = "0x4008EB4")]
		PlayerBattleTagCdtType_CS_WinAverageKill_SMALLER = 201302,
		[Token(Token = "0x4008EB5")]
		PlayerBattleTagCdtType_CS_FirstBlood_LARGER = 201401,
		[Token(Token = "0x4008EB6")]
		PlayerBattleTagCdtType_CS_MVP_LARGER = 201501
	}

	[Token(Token = "0x2001491")]
	public enum SocialTag
	{
		[Token(Token = "0x4008EB8")]
		SocialTag_NONE = 0,
		[Token(Token = "0x4008EB9")]
		SocialTag_FASHION = 2101,
		[Token(Token = "0x4008EBA")]
		SocialTag_SOCIAL = 2102,
		[Token(Token = "0x4008EBB")]
		SocialTag_VETERAN = 2103,
		[Token(Token = "0x4008EBC")]
		SocialTag_NEWBIE = 2104,
		[Token(Token = "0x4008EBD")]
		SocialTag_PLAYFORWIN = 2105,
		[Token(Token = "0x4008EBE")]
		SocialTag_PLAYFORFUN = 2106,
		[Token(Token = "0x4008EBF")]
		SocialTag_VOICEON = 2107,
		[Token(Token = "0x4008EC0")]
		SocialTag_VOICEOFF = 2108
	}

	[Token(Token = "0x2001492")]
	public enum Gender
	{
		[Token(Token = "0x4008EC2")]
		Gender_NONE = 0,
		[Token(Token = "0x4008EC3")]
		Gender_MALE = 1,
		[Token(Token = "0x4008EC4")]
		Gender_FEMALE = 2,
		[Token(Token = "0x4008EC5")]
		Gender_UNLIMITED = 999
	}

	[Token(Token = "0x2001493")]
	public enum Language
	{
		[Token(Token = "0x4008EC7")]
		Language_NONE = 0,
		[Token(Token = "0x4008EC8")]
		Language_EN = 1,
		[Token(Token = "0x4008EC9")]
		Language_CN_SIMPLIFIED = 2,
		[Token(Token = "0x4008ECA")]
		Language_CN_TRADITIONAL = 3,
		[Token(Token = "0x4008ECB")]
		Language_Thai = 4,
		[Token(Token = "0x4008ECC")]
		Language_VIETNAMESE = 5,
		[Token(Token = "0x4008ECD")]
		Language_INDONESIAN = 6,
		[Token(Token = "0x4008ECE")]
		Language_PORTUGUESE = 7,
		[Token(Token = "0x4008ECF")]
		Language_SPANISH = 8,
		[Token(Token = "0x4008ED0")]
		Language_RUSSIAN = 9,
		[Token(Token = "0x4008ED1")]
		Language_KOREAN = 10,
		[Token(Token = "0x4008ED2")]
		Language_FRENCH = 11,
		[Token(Token = "0x4008ED3")]
		Language_GERMAN = 12,
		[Token(Token = "0x4008ED4")]
		Language_TURKISH = 13,
		[Token(Token = "0x4008ED5")]
		Language_HINDI = 14,
		[Token(Token = "0x4008ED6")]
		Language_JAPANESE = 15,
		[Token(Token = "0x4008ED7")]
		Language_ROMANIAN = 16,
		[Token(Token = "0x4008ED8")]
		Language_ARABIC = 17,
		[Token(Token = "0x4008ED9")]
		Language_BURMESE = 18,
		[Token(Token = "0x4008EDA")]
		Language_URDU = 19,
		[Token(Token = "0x4008EDB")]
		Language_BENGALI = 20,
		[Token(Token = "0x4008EDC")]
		Language_UNLIMITED = 999
	}

	[Token(Token = "0x2001494")]
	public enum RankShow
	{
		[Token(Token = "0x4008EDE")]
		RankShow_NONE = 0,
		[Token(Token = "0x4008EDF")]
		RankShow_BR = 1,
		[Token(Token = "0x4008EE0")]
		RankShow_CS = 2,
		[Token(Token = "0x4008EE1")]
		RankShow_UNLIMITED = 999
	}

	[Token(Token = "0x2001495")]
	public enum TimeOnline
	{
		[Token(Token = "0x4008EE3")]
		TimeOnline_NONE = 0,
		[Token(Token = "0x4008EE4")]
		TimeOnline_WORKDAY = 1,
		[Token(Token = "0x4008EE5")]
		TimeOnline_WEEKEND = 2,
		[Token(Token = "0x4008EE6")]
		TimeOnline_UNLIMITED = 999
	}

	[Token(Token = "0x2001496")]
	public enum TimeActive
	{
		[Token(Token = "0x4008EE8")]
		TimeActive_NONE = 0,
		[Token(Token = "0x4008EE9")]
		TimeActive_MORNING = 1,
		[Token(Token = "0x4008EEA")]
		TimeActive_AFTERNOON = 2,
		[Token(Token = "0x4008EEB")]
		TimeActive_NIGHT = 3,
		[Token(Token = "0x4008EEC")]
		TimeActive_UNLIMITED = 999
	}

	[Token(Token = "0x2001497")]
	public enum ModePrefer
	{
		[Token(Token = "0x4008EEE")]
		ModePrefer_NONE = 0,
		[Token(Token = "0x4008EEF")]
		ModePrefer_BR = 1,
		[Token(Token = "0x4008EF0")]
		ModePrefer_CS = 2,
		[Token(Token = "0x4008EF1")]
		ModePrefer_ENTERTAINMENT = 3,
		[Token(Token = "0x4008EF2")]
		ModePrefer_UNLIMITED = 999
	}

	[Token(Token = "0x6007B0A")]
	[Address(RVA = "0x309F8EC", Offset = "0x309F8EC", VA = "0x309F8EC")]
	public ESocial()
	{
	}
}
