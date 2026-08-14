using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002D36")]
public static class UIProfileUtil
{
	[Token(Token = "0x401145F")]
	[FieldOffset(Offset = "0x0")]
	public static Color Online_Color;

	[Token(Token = "0x4011460")]
	[FieldOffset(Offset = "0x10")]
	public static Color InGame_Color;

	[Token(Token = "0x4011461")]
	[FieldOffset(Offset = "0x20")]
	public static Color Offline_Color;

	[Token(Token = "0x4011462")]
	public const uint BTN_COLOR_YELLOW = 4256628991u;

	[Token(Token = "0x4011463")]
	public const uint BTN_COLOR_GRAY = 2189591295u;

	[Token(Token = "0x4011464")]
	public const uint BG_COLOR_GRAY = 1448630527u;

	[Token(Token = "0x4011465")]
	public const uint UI_HideClanName = 1u;

	[Token(Token = "0x4011466")]
	public const uint UI_HideLevel = 2u;

	[Token(Token = "0x4011467")]
	public const uint UI_ShowRank = 4u;

	[Token(Token = "0x4011468")]
	public const uint UI_ShowOnline = 8u;

	[Token(Token = "0x4011469")]
	public const uint UI_GrayOffline = 16u;

	[Token(Token = "0x401146A")]
	public const uint UI_ShowPlatformIcon = 32u;

	[Token(Token = "0x401146B")]
	public const uint UI_ShowElitePass = 64u;

	[Token(Token = "0x401146C")]
	public const uint UI_ShowCSRank = 128u;

	[Token(Token = "0x401146D")]
	public const uint UI_ShowBtnPinIcon = 256u;

	[Token(Token = "0x401146E")]
	public const uint UI_ForceShowBRRank = 512u;

	[Token(Token = "0x401146F")]
	public const uint UI_ShowPeriodicRank = 1024u;

	[Token(Token = "0x4011470")]
	public const string DEFAULT_HEADICON = "SG_Icon_Avatar_Normal";

	[Token(Token = "0x4011471")]
	public const string DEFAULT_BRIEF_BANNER = "SG_Icon_callsign_briefbg_Default";

	[Token(Token = "0x4011472")]
	public const string DEFAULT_BANNER = "SG_Icon_Callsign_Basebg_Default";

	[Token(Token = "0x4011473")]
	public const string DEFAULT_STOREBG_BANNER = "SG_Icon_Callsign_Storebg_Default";

	[Token(Token = "0x4011474")]
	public const string DEFAULT_PIN = "FF_UI_Pin_Currency";

	[Token(Token = "0x4011475")]
	public const int MAX_EMOTESLOT_CNT = 0;

	[Token(Token = "0x4011476")]
	[FieldOffset(Offset = "0x30")]
	private static readonly Dictionary<uint, int> AccountPresenceSortOrder;

	[Token(Token = "0x6012E96")]
	[Address(RVA = "0x1ABBB64", Offset = "0x1ABBB64", VA = "0x1ABBB64")]
	public static int ComparePresence(EPresence.AccountPresence a, EPresence.AccountPresence b)
	{
		return default(int);
	}

	[Token(Token = "0x6012E97")]
	[Address(RVA = "0x1ABBDD8", Offset = "0x1ABBDD8", VA = "0x1ABBDD8")]
	public static string GetPlatformIconByType(AccountExternalPlatform platform)
	{
		return null;
	}

	[Token(Token = "0x6012E98")]
	[Address(RVA = "0x1ABBEF8", Offset = "0x1ABBEF8", VA = "0x1ABBEF8")]
	public static string GetGenderSprite(bool isFemale)
	{
		return null;
	}

	[Token(Token = "0x6012E99")]
	[Address(RVA = "0x1ABAC2C", Offset = "0x1ABAC2C", VA = "0x1ABAC2C")]
	public static void SetHeadPic(UISprite m_HeadIcon, uint iid)
	{
	}

	[Token(Token = "0x6012E9A")]
	[Address(RVA = "0x1ABBFD0", Offset = "0x1ABBFD0", VA = "0x1ABBFD0")]
	public static void SetHeadPic(UISprite m_HeadIcon, HeadPicData data, bool isDownloadIconCovered = false)
	{
	}

	[Token(Token = "0x6012E9B")]
	[Address(RVA = "0x1ABC560", Offset = "0x1ABC560", VA = "0x1ABC560")]
	public static void SetPinPic(UISprite pinIcon, uint pinId, bool isBigIcon)
	{
	}

	[Token(Token = "0x6012E9C")]
	[Address(RVA = "0x1ABC794", Offset = "0x1ABC794", VA = "0x1ABC794")]
	public static void SetBannerWithResourceID(UISprite m_Banner, BannerData data, bool isBrief = false, bool isDownloadIconCovered = false)
	{
	}

	[Token(Token = "0x6012E9D")]
	[Address(RVA = "0x1ABD010", Offset = "0x1ABD010", VA = "0x1ABD010")]
	public static void SetBanner(UISprite m_Banner, uint bannerId, bool isBrief = false)
	{
	}

	[Token(Token = "0x6012E9E")]
	[Address(RVA = "0x1ABD16C", Offset = "0x1ABD16C", VA = "0x1ABD16C")]
	public static void UpdateHeadPicOrPortraitUrl(UISprite headIcon, UINetworkTexture headTexture, BaseProfileInfo data, [Optional] GameObject fakeImage)
	{
	}

	[Token(Token = "0x6012E9F")]
	[Address(RVA = "0x1ABD4F8", Offset = "0x1ABD4F8", VA = "0x1ABD4F8")]
	public static string BlurNickName(string nickName)
	{
		return null;
	}
}
