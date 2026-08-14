using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D7E")]
public class EMatch
{
	[Token(Token = "0x2001D7F")]
	public enum MatchMode
	{
		[Token(Token = "0x400BA31")]
		MatchMode_NONE = 0,
		[Token(Token = "0x400BA32")]
		MatchMode_CASUAL = 1,
		[Token(Token = "0x400BA33")]
		MatchMode_RANKING = 2,
		[Token(Token = "0x400BA34")]
		MatchMode_ROOM = 3,
		[Token(Token = "0x400BA35")]
		MatchMode_CHAMPIONSHIP = 4,
		[Token(Token = "0x400BA36")]
		MatchMode_TRAINING = 5,
		[Token(Token = "0x400BA37")]
		MatchMode_CSRANKING = 6,
		[Token(Token = "0x400BA38")]
		MatchMode_CUP = 7,
		[Token(Token = "0x400BA39")]
		MatchMode_UGC = 8,
		[Token(Token = "0x400BA3A")]
		MatchMode_PERIODIC = 9,
		[Token(Token = "0x400BA3B")]
		MatchMode_UGC_PLUS = 10,
		[Token(Token = "0x400BA3C")]
		MatchMode_COMMON = 999
	}

	[Token(Token = "0x2001D80")]
	public enum GameMode
	{
		[Token(Token = "0x400BA3E")]
		GameMode_NONE = 0,
		[Token(Token = "0x400BA3F")]
		GameMode_BattleRoyale = 1,
		[Token(Token = "0x400BA40")]
		GameMode_SpeedRoyale = 2,
		[Token(Token = "0x400BA41")]
		GameMode_FateRoyale = 3,
		[Token(Token = "0x400BA42")]
		GameMode_ZombieSpeedRoyale = 4,
		[Token(Token = "0x400BA43")]
		GameMode_ZombieGround = 7,
		[Token(Token = "0x400BA44")]
		GameMode_Jankenpon = 9,
		[Token(Token = "0x400BA45")]
		GameMode_WinnerTakesAll = 11,
		[Token(Token = "0x400BA46")]
		GameMode_Purge = 12,
		[Token(Token = "0x400BA47")]
		GameMode_Reborn = 13,
		[Token(Token = "0x400BA48")]
		GameMode_HookBrick = 14,
		[Token(Token = "0x400BA49")]
		GameMode_CS = 15,
		[Token(Token = "0x400BA4A")]
		GameMode_BigHead = 16,
		[Token(Token = "0x400BA4B")]
		GameMode_PumpkinSnatch = 21,
		[Token(Token = "0x400BA4C")]
		GameMode_ThrowingKnife = 22,
		[Token(Token = "0x400BA4D")]
		GameMode_Training = 23,
		[Token(Token = "0x400BA4E")]
		GameMode_TDM = 24,
		[Token(Token = "0x400BA4F")]
		GameMode_Snowman = 25,
		[Token(Token = "0x400BA50")]
		GameMode_ArmsRace = 26,
		[Token(Token = "0x400BA51")]
		GameMode_BombMatch = 27,
		[Token(Token = "0x400BA52")]
		GameMode_Token = 28,
		[Token(Token = "0x400BA53")]
		GameMode_Escort = 29,
		[Token(Token = "0x400BA54")]
		GameMode_Reaper = 30,
		[Token(Token = "0x400BA55")]
		GameMode_AttackOnHead = 31,
		[Token(Token = "0x400BA56")]
		GameMode_Control = 32,
		[Token(Token = "0x400BA57")]
		GameMode_BankNote = 33,
		[Token(Token = "0x400BA58")]
		GameMode_TeamArmsRace = 34,
		[Token(Token = "0x400BA59")]
		GameMode_ADSpace = 35,
		[Token(Token = "0x400BA5A")]
		GameMode_StrikeOut = 36,
		[Token(Token = "0x400BA5B")]
		GameMode_Werewolves = 37,
		[Token(Token = "0x400BA5C")]
		GameMode_Party = 38,
		[Token(Token = "0x400BA5D")]
		GameMode_FourSymbols = 39,
		[Token(Token = "0x400BA5E")]
		GameMode_TutorialBR = 40,
		[Token(Token = "0x400BA5F")]
		GameMode_TutorialCS = 41,
		[Token(Token = "0x400BA60")]
		GameMode_ClanWar = 42,
		[Token(Token = "0x400BA61")]
		GameMode_FightClub = 43,
		[Token(Token = "0x400BA62")]
		GameMode_RushingPets = 44,
		[Token(Token = "0x400BA63")]
		GameMode_UGCParty = 45,
		[Token(Token = "0x400BA64")]
		GameMode_UGC = 46,
		[Token(Token = "0x400BA65")]
		GameMode_CombineWeapon = 48,
		[Token(Token = "0x400BA66")]
		GameMode_LoneWolfStrikeOut = 49,
		[Token(Token = "0x400BA67")]
		GameMode_Ludo = 50,
		[Token(Token = "0x400BA68")]
		GameMode_HappyFriday = 51,
		[Token(Token = "0x400BA69")]
		GameMode_CSHardCore = 52,
		[Token(Token = "0x400BA6A")]
		GameMode_UGCCommon = 53,
		[Token(Token = "0x400BA6B")]
		GameMode_ZombieGroundPlus = 55,
		[Token(Token = "0x400BA6C")]
		GameMode_SingersB = 56,
		[Token(Token = "0x400BA6D")]
		GameMode_FlagBattle = 57,
		[Token(Token = "0x400BA6E")]
		Gamemode_Infection = 58,
		[Token(Token = "0x400BA6F")]
		GameMode_RushHour = 60,
		[Token(Token = "0x400BA70")]
		GameMode_PersonalDeathmatch = 61,
		[Token(Token = "0x400BA71")]
		GameMode_PVP_MaxMode = 62,
		[Token(Token = "0x400BA72")]
		GameMode_PVP = 99,
		[Token(Token = "0x400BA73")]
		GameMode_PVE_MinMode = 100,
		[Token(Token = "0x400BA74")]
		GameMode_PVE_HYAKKI = 101,
		[Token(Token = "0x400BA75")]
		GameMode_PVE_SVZombie = 102,
		[Token(Token = "0x400BA76")]
		GameMode_PVE_MaxMode = 103
	}

	[Token(Token = "0x2001D81")]
	public enum GroupMode
	{
		[Token(Token = "0x400BA78")]
		GroupMode_SOLO = 0,
		[Token(Token = "0x400BA79")]
		GroupMode_DUAL = 1,
		[Token(Token = "0x400BA7A")]
		GroupMode_TRIPLE = 2,
		[Token(Token = "0x400BA7B")]
		GroupMode_QUAD = 3,
		[Token(Token = "0x400BA7C")]
		GroupMode_PENTA = 4,
		[Token(Token = "0x400BA7D")]
		GroupMode_HEXA = 5,
		[Token(Token = "0x400BA7E")]
		GroupMode_OCTA = 7,
		[Token(Token = "0x400BA7F")]
		GroupMode_DOZEN = 11
	}

	[Token(Token = "0x2001D82")]
	public enum UGCDifficulty
	{
		[Token(Token = "0x400BA81")]
		UGCDifficulty_NONE,
		[Token(Token = "0x400BA82")]
		UGCDifficulty_TEAM_CONTEST,
		[Token(Token = "0x400BA83")]
		UGCDifficulty_BATTLE_GROUNDS
	}

	[Token(Token = "0x6008A21")]
	[Address(RVA = "0x33E9074", Offset = "0x33E9074", VA = "0x33E9074")]
	public EMatch()
	{
	}
}
