using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20032E0")]
public static class NewbieGuideEventMgr
{
	[Token(Token = "0x40135A9")]
	public const string LoginDay = "First_Loign_Day";

	[Token(Token = "0x40135AA")]
	public const string Competion = "Competion_time";

	[Token(Token = "0x40135AB")]
	public const string Entrance = "RuKou";

	[Token(Token = "0x40135AC")]
	public const string NewRegistered = "NewRegisted_";

	[Token(Token = "0x40135AD")]
	public const string CompetitionKey = "CompetitionKey_";

	[Token(Token = "0x40135AE")]
	public const string ManualBookKey = "ManualBookKey_";

	[Token(Token = "0x40135AF")]
	public const string AvatarProfileKey = "AvatarProfileKey_";

	[Token(Token = "0x40135B0")]
	public const string CollectionKey = "CollectionKey_";

	[Token(Token = "0x40135B1")]
	public const string RankCompetitionKey = "RankCompetitionKey_";

	[Token(Token = "0x40135B2")]
	public const string ShopKey = "ShopKey_";

	[Token(Token = "0x40135B3")]
	public const string GachaKey = "GachaKey_";

	[Token(Token = "0x40135B4")]
	public const string PetKey = "PetKey_";

	[Token(Token = "0x40135B5")]
	public const string ChampionshipKey = "ChampionshipKey_";

	[Token(Token = "0x40135B6")]
	public const string ClanKey = "ClanKey_";

	[Token(Token = "0x40135B7")]
	public const string FriendKey = "FriendKey_";

	[Token(Token = "0x40135B8")]
	public const string EPKey = "EPKey_";

	[Token(Token = "0x40135B9")]
	public const string LoadoutKey = "LoadoutKey_";

	[Token(Token = "0x40135BA")]
	public const string AvatarSkillKey = "SkillKey_";

	[Token(Token = "0x40135BB")]
	public const uint NewBieCommonPrority = 1000u;

	[Token(Token = "0x6015715")]
	[Address(RVA = "0x28B4708", Offset = "0x28B4708", VA = "0x28B4708")]
	public static bool CheckLevelEqual(uint level)
	{
		return default(bool);
	}

	[Token(Token = "0x6015716")]
	[Address(RVA = "0x28B4838", Offset = "0x28B4838", VA = "0x28B4838")]
	public static bool CheckLevelOver(uint level)
	{
		return default(bool);
	}

	[Token(Token = "0x6015717")]
	[Address(RVA = "0x28B4968", Offset = "0x28B4968", VA = "0x28B4968")]
	public static bool CheckLevelLess(uint level)
	{
		return default(bool);
	}

	[Token(Token = "0x6015718")]
	[Address(RVA = "0x28B4A98", Offset = "0x28B4A98", VA = "0x28B4A98")]
	public static bool CheckAvatarOver(int num)
	{
		return default(bool);
	}

	[Token(Token = "0x6015719")]
	[Address(RVA = "0x28B4BF4", Offset = "0x28B4BF4", VA = "0x28B4BF4")]
	public static bool CheckRedTips(NewbieGuideId newbieid, int open)
	{
		return default(bool);
	}

	[Token(Token = "0x601571A")]
	[Address(RVA = "0x28B5158", Offset = "0x28B5158", VA = "0x28B5158")]
	public static bool CheckLadderOver(int score)
	{
		return default(bool);
	}

	[Token(Token = "0x601571B")]
	[Address(RVA = "0x28B5288", Offset = "0x28B5288", VA = "0x28B5288")]
	public static bool CheckInClan(int open)
	{
		return default(bool);
	}

	[Token(Token = "0x601571C")]
	[Address(RVA = "0x28B5410", Offset = "0x28B5410", VA = "0x28B5410")]
	public static bool CheckfriendAccoutNum(int num)
	{
		return default(bool);
	}

	[Token(Token = "0x601571D")]
	[Address(RVA = "0x28B5564", Offset = "0x28B5564", VA = "0x28B5564")]
	public static bool CheckFirstDayLogin(int open)
	{
		return default(bool);
	}

	[Token(Token = "0x601571E")]
	[Address(RVA = "0x28B5B48", Offset = "0x28B5B48", VA = "0x28B5B48")]
	public static bool CheckCompetitionNum(int compenum)
	{
		return default(bool);
	}

	[Token(Token = "0x601571F")]
	[Address(RVA = "0x28B5D44", Offset = "0x28B5D44", VA = "0x28B5D44")]
	public static bool CheckAcccoutType(int open)
	{
		return default(bool);
	}

	[Token(Token = "0x6015720")]
	[Address(RVA = "0x28B5E50", Offset = "0x28B5E50", VA = "0x28B5E50")]
	public static bool CheckClickNum(NewbieGuideId newbieid, int num)
	{
		return default(bool);
	}

	[Token(Token = "0x6015721")]
	[Address(RVA = "0x28B6B60", Offset = "0x28B6B60", VA = "0x28B6B60")]
	public static bool CheckHasAvatar(uint avatarID)
	{
		return default(bool);
	}

	[Token(Token = "0x6015722")]
	[Address(RVA = "0x28B5EC8", Offset = "0x28B5EC8", VA = "0x28B5EC8")]
	private static int GetClickNum(NewbieGuideId newbieid)
	{
		return default(int);
	}

	[Token(Token = "0x6015723")]
	[Address(RVA = "0x28B4C6C", Offset = "0x28B4C6C", VA = "0x28B4C6C")]
	private static bool CheckHasRedTips(NewbieGuideId newbieid)
	{
		return default(bool);
	}

	[Token(Token = "0x6015724")]
	[Address(RVA = "0x28B6CB0", Offset = "0x28B6CB0", VA = "0x28B6CB0")]
	public static string GetRealGuideKey(NewbieGuideId newbieid)
	{
		return null;
	}
}
