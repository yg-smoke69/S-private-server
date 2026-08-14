using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using proto;
using tcp;

namespace COW;

[Token(Token = "0x2002D06")]
public static class ItemUtil
{
	[Token(Token = "0x2002D07")]
	public enum ItemShareType
	{
		[Token(Token = "0x40112C3")]
		None,
		[Token(Token = "0x40112C4")]
		AvatarLinkDefault,
		[Token(Token = "0x40112C5")]
		AvatarLinkOnlySkill,
		[Token(Token = "0x40112C6")]
		AvatarLinkHeadPic
	}

	[Token(Token = "0x2002D08")]
	public enum ItemQualityType
	{
		[Token(Token = "0x40112C8")]
		Grey = 1,
		[Token(Token = "0x40112C9")]
		Green = 2,
		[Token(Token = "0x40112CA")]
		Blue = 3,
		[Token(Token = "0x40112CB")]
		Purple = 4,
		[Token(Token = "0x40112CC")]
		Orange = 5,
		[Token(Token = "0x40112CD")]
		Red = 7,
		[Token(Token = "0x40112CE")]
		PurplePlus = 8,
		[Token(Token = "0x40112CF")]
		OrangePlus = 9
	}

	[Token(Token = "0x40112AD")]
	public const int INVALID = 0;

	[Token(Token = "0x40112AE")]
	public const string GOLDRES = "SG_Icon_Signin_Gold";

	[Token(Token = "0x40112AF")]
	public const string GOLDBIGRES = "SG_Icon_Signin_Gold_big";

	[Token(Token = "0x40112B0")]
	public const string DIAMOND_RES = "SG_Icon_Signin_Diamond";

	[Token(Token = "0x40112B1")]
	public const string DIAMOND_BIGRES = "SG_Icon_Signin_Diamond_big";

	[Token(Token = "0x40112B2")]
	public const string SPECIAL_RES = "SG_Icon_Signin_CBelite";

	[Token(Token = "0x40112B3")]
	public const string SPECIAL_BIGRES = "SG_Icon_Signin_CBelite_big";

	[Token(Token = "0x40112B4")]
	public const string EXP_RES = "SG_Icon_Exp";

	[Token(Token = "0x40112B5")]
	public const string EXP_BIGRES = "SG_Icon_Exp_big";

	[Token(Token = "0x40112B6")]
	public const string GOLD_NAME = "TXT_CURRENCY_GOLD_TITLE";

	[Token(Token = "0x40112B7")]
	public const string DIAMOND_NAME = "TXT_CURRENCY_DIAMOND_TITLE";

	[Token(Token = "0x40112B8")]
	public const string SPECIAL_NAME = "TXT_ANNOUCEMENT_REWARD_SPECIAL";

	[Token(Token = "0x40112B9")]
	public const string EXP_NAME = "TXT_EXP_TITLE";

	[Token(Token = "0x40112BA")]
	public const string DIAMOND_DESC = "TXT_OB7_GXQ_CURRENCY_DIAMOND_DESC";

	[Token(Token = "0x40112BB")]
	public const string GOLD_DESC = "TXT_OB7_GXQ_CURRENCY_GOLD_DESC";

	[Token(Token = "0x40112BC")]
	public const string EXP_DESC = "TXT_OB7_GXQ_EXP_DESC";

	[Token(Token = "0x40112BD")]
	public const int SIGHT_HOLOGRAPHIC_ID = 533;

	[Token(Token = "0x40112BE")]
	public const int SIGHT_RED_DOT_ID = 532;

	[Token(Token = "0x40112BF")]
	public const int SIGHT_2_ID = 534;

	[Token(Token = "0x40112C0")]
	public const int SIGHT_4_ID = 535;

	[Token(Token = "0x40112C1")]
	public const int SIGHT_8_ID = 536;

	[Token(Token = "0x6012D30")]
	[Address(RVA = "0x1EE32F8", Offset = "0x1EE32F8", VA = "0x1EE32F8")]
	public static void SetQuantityString(UILabel m_Label, BaseItemInfo data, bool ShowExpireDayOnly = false, bool IsShowExpireTime = true)
	{
	}

	[Token(Token = "0x6012D31")]
	[Address(RVA = "0x1EE4028", Offset = "0x1EE4028", VA = "0x1EE4028")]
	public static void SetQuantityString(UILabel time, UILabel num, BaseItemInfo data, bool ignoreOne = true)
	{
	}

	[Token(Token = "0x6012D32")]
	[Address(RVA = "0x1EE3984", Offset = "0x1EE3984", VA = "0x1EE3984")]
	public static string GetExpireTimeString(uint expireTime, bool showExpireDayOnly = true, bool needAddOneDay = false)
	{
		return null;
	}

	[Token(Token = "0x6012D33")]
	[Address(RVA = "0x1EE4900", Offset = "0x1EE4900", VA = "0x1EE4900")]
	public static string GetItemAvalibleTime(uint expireTime)
	{
		return null;
	}

	[Token(Token = "0x6012D34")]
	[Address(RVA = "0x1EE4E30", Offset = "0x1EE4E30", VA = "0x1EE4E30")]
	public static List<BaseItemInfo> GetBaseItemInfoListByTcpAward(AwardDataTCP award)
	{
		return null;
	}

	[Token(Token = "0x6012D35")]
	[Address(RVA = "0x1EE513C", Offset = "0x1EE513C", VA = "0x1EE513C")]
	public static List<BaseItemInfo> GetBaseItemInfoListByAward(AwardData a)
	{
		return null;
	}

	[Token(Token = "0x6012D36")]
	[Address(RVA = "0x1EE545C", Offset = "0x1EE545C", VA = "0x1EE545C")]
	public static bool IsBigAwardshow(uint itemid, bool isBundleItem = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6012D37")]
	[Address(RVA = "0x1EE5BE8", Offset = "0x1EE5BE8", VA = "0x1EE5BE8")]
	public static bool IsCommonFeatureShowItem(uint itemid)
	{
		return default(bool);
	}

	[Token(Token = "0x6012D38")]
	[Address(RVA = "0x1EE5F38", Offset = "0x1EE5F38", VA = "0x1EE5F38")]
	public static List<AwardDesc> MergeSameItemInfo(List<AwardDesc> list)
	{
		return null;
	}

	[Token(Token = "0x6012D39")]
	[Address(RVA = "0x1EE638C", Offset = "0x1EE638C", VA = "0x1EE638C")]
	public static List<CommonRewardItemInfo> MergeSameItemInfo(List<CommonRewardItemInfo> list)
	{
		return null;
	}

	[Token(Token = "0x6012D3A")]
	[Address(RVA = "0x1EE6B34", Offset = "0x1EE6B34", VA = "0x1EE6B34")]
	public static string GetLabelColor(int type)
	{
		return null;
	}

	[Token(Token = "0x6012D3B")]
	[Address(RVA = "0x1EE6CCC", Offset = "0x1EE6CCC", VA = "0x1EE6CCC")]
	public static Color GetColorByQuality(int q)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color);
	}

	[Token(Token = "0x6012D3C")]
	[Address(RVA = "0x1EE6D3C", Offset = "0x1EE6D3C", VA = "0x1EE6D3C")]
	public static bool IsSightingTelescope(int itemID)
	{
		return default(bool);
	}

	[Token(Token = "0x6012D3D")]
	[Address(RVA = "0x1EE6DB4", Offset = "0x1EE6DB4", VA = "0x1EE6DB4")]
	public static string GetItemDescription(proto.EInventory.AwardType awardType, uint itemID)
	{
		return null;
	}

	[Token(Token = "0x6012D3E")]
	[Address(RVA = "0x1EE6F68", Offset = "0x1EE6F68", VA = "0x1EE6F68")]
	public static string SightScopeDisplayName(int itemID)
	{
		return null;
	}

	[Token(Token = "0x6012D3F")]
	[Address(RVA = "0x1EE3E78", Offset = "0x1EE3E78", VA = "0x1EE3E78")]
	public static bool IsStackItem(BaseItemInfo data)
	{
		return default(bool);
	}

	[Token(Token = "0x6012D40")]
	[Address(RVA = "0x1EE36A8", Offset = "0x1EE36A8", VA = "0x1EE36A8")]
	public static bool IsOnlyShowNumItem(BaseItemInfo data)
	{
		return default(bool);
	}

	[Token(Token = "0x6012D41")]
	[Address(RVA = "0x1EE3818", Offset = "0x1EE3818", VA = "0x1EE3818")]
	public static bool IsShowNumAndHideTimeItem(BaseItemInfo data)
	{
		return default(bool);
	}

	[Token(Token = "0x6012D42")]
	[Address(RVA = "0x1EE70B0", Offset = "0x1EE70B0", VA = "0x1EE70B0")]
	public static bool IsShowItemEndTimeWithDesc(byte itemSubType)
	{
		return default(bool);
	}

	[Token(Token = "0x6012D43")]
	[Address(RVA = "0x1EE7124", Offset = "0x1EE7124", VA = "0x1EE7124")]
	public static Color GetInGameShopItemRareColor(uint rare)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color);
	}

	[Token(Token = "0x6012D44")]
	[Address(RVA = "0x1EE7288", Offset = "0x1EE7288", VA = "0x1EE7288")]
	public static string GetRareTypeLabelColor(proto.EInventory.RareType rare)
	{
		return null;
	}
}
