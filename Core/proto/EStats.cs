using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200131B")]
public class EStats
{
	[Token(Token = "0x200131C")]
	public enum MissionType
	{
		[Token(Token = "0x400873C")]
		MissionType_NONE,
		[Token(Token = "0x400873D")]
		MissionType_UPGRADE_LEVEL
	}

	[Token(Token = "0x200131D")]
	public enum DailyMatchRewardConfigID
	{
		[Token(Token = "0x400873F")]
		DailyMatchRewardConfigID_NONE,
		[Token(Token = "0x4008740")]
		DailyMatchRewardConfigID_SOLO_TOPN,
		[Token(Token = "0x4008741")]
		DailyMatchRewardConfigID_DUO_TOPN,
		[Token(Token = "0x4008742")]
		DailyMatchRewardConfigID_QUAD_TOPN,
		[Token(Token = "0x4008743")]
		DailyMatchRewardConfigID_FIRST_MATCH
	}

	[Token(Token = "0x200131E")]
	public enum DailyMatchRewardType
	{
		[Token(Token = "0x4008745")]
		DailyMatchRewardType_NONE,
		[Token(Token = "0x4008746")]
		DailyMatchRewardType_OUTSTANDING,
		[Token(Token = "0x4008747")]
		DailyMatchRewardType_FIRST_MATCH
	}

	[Token(Token = "0x200131F")]
	public enum WinnerTakesAllCurrencyType
	{
		[Token(Token = "0x4008749")]
		WinnerTakesAllCurrencyType_NONE,
		[Token(Token = "0x400874A")]
		WinnerTakesAllCurrencyType_CHIP,
		[Token(Token = "0x400874B")]
		WinnerTakesAllCurrencyType_DIAMOND,
		[Token(Token = "0x400874C")]
		WinnerTakesAllCurrencyType_FREE
	}

	[Token(Token = "0x2001320")]
	public enum RelationMaskPos
	{
		[Token(Token = "0x400874E")]
		RelationMaskPos_FRIEND = 0,
		[Token(Token = "0x400874F")]
		RelationMaskPos_CONDFIDANT = 1,
		[Token(Token = "0x4008750")]
		RelationMaskPos_MENTOR = 2,
		[Token(Token = "0x4008751")]
		RelationMaskPos_STUDENT = 3,
		[Token(Token = "0x4008752")]
		RelationMaskPos_MAX = 32
	}

	[Token(Token = "0x6007A50")]
	[Address(RVA = "0x309F8F4", Offset = "0x309F8F4", VA = "0x309F8F4")]
	public EStats()
	{
	}
}
