using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;
using proto;

namespace COW;

[Token(Token = "0x2002D8E")]
internal static class UIUtils
{
	[Token(Token = "0x2002D8F")]
	public enum SpriteScaleType
	{
		[Token(Token = "0x40117BA")]
		WidthFixed,
		[Token(Token = "0x40117BB")]
		HeightFixed,
		[Token(Token = "0x40117BC")]
		Fit,
		[Token(Token = "0x40117BD")]
		BestFillBoarder,
		[Token(Token = "0x40117BE")]
		BestFillBoadrderNoSpace,
		[Token(Token = "0x40117BF")]
		WidthOrHeight
	}

	[Token(Token = "0x2002D90")]
	public enum ScreenshotType
	{
		[Token(Token = "0x40117C1")]
		None = 0,
		[Token(Token = "0x40117C2")]
		PlayerProfile = 1,
		[Token(Token = "0x40117C3")]
		GameHistory = 2,
		[Token(Token = "0x40117C4")]
		GachaReward = 3,
		[Token(Token = "0x40117C5")]
		GachaLuckyBag = 4,
		[Token(Token = "0x40117C6")]
		GainItem = 5,
		[Token(Token = "0x40117C7")]
		LeaderBoard = 6,
		[Token(Token = "0x40117C8")]
		RankLobby = 7,
		[Token(Token = "0x40117C9")]
		RankSeasonInfo = 8,
		[Token(Token = "0x40117CA")]
		PreviewCG = 9,
		[Token(Token = "0x40117CB")]
		Pet = 10,
		[Token(Token = "0x40117CC")]
		IAPBundle = 11,
		[Token(Token = "0x40117CD")]
		Manual = 12,
		[Token(Token = "0x40117CE")]
		ChampionshipStats = 13,
		[Token(Token = "0x40117CF")]
		ElitePassShare = 14,
		[Token(Token = "0x40117D0")]
		RankComparison = 15,
		[Token(Token = "0x40117D1")]
		MatchResult = 16,
		[Token(Token = "0x40117D2")]
		MysteryMall = 18,
		[Token(Token = "0x40117D3")]
		WeaponSkinMain = 19,
		[Token(Token = "0x40117D4")]
		WeaponSkinUpgrader = 20,
		[Token(Token = "0x40117D5")]
		Bounty = 21,
		[Token(Token = "0x40117D6")]
		IngamePhotograph = 22,
		[Token(Token = "0x40117D7")]
		PortraitCloseup = 23,
		[Token(Token = "0x40117D8")]
		FriendGraph = 24,
		[Token(Token = "0x40117D9")]
		HDYard = 25,
		[Token(Token = "0x40117DA")]
		BR_MVP_Show = 26,
		[Token(Token = "0x40117DB")]
		CS_MVP_Show = 27,
		[Token(Token = "0x40117DC")]
		SplashBannerLiveTv = 28,
		[Token(Token = "0x40117DD")]
		CupMatch = 29,
		[Token(Token = "0x40117DE")]
		FourSymbols = 30,
		[Token(Token = "0x40117DF")]
		MusicFestAlbumMian = 31,
		[Token(Token = "0x40117E0")]
		MusicFestPhoto1 = 32,
		[Token(Token = "0x40117E1")]
		OBMatchResult = 53,
		[Token(Token = "0x40117E2")]
		WebViewCaptureScreenshot = 54,
		[Token(Token = "0x40117E3")]
		Winterfest = 55,
		[Token(Token = "0x40117E4")]
		SceneEdit = 56,
		[Token(Token = "0x40117E5")]
		HurricaneB = 57,
		[Token(Token = "0x40117E6")]
		BoybandB = 59,
		[Token(Token = "0x40117E7")]
		BigEventTemplate = 60,
		[Token(Token = "0x40117E8")]
		FFWS03 = 61,
		[Token(Token = "0x40117E9")]
		FFWS03Bill = 62,
		[Token(Token = "0x40117EA")]
		LadderMatchInfo = 63,
		[Token(Token = "0x40117EB")]
		AvatarLink = 64,
		[Token(Token = "0x40117EC")]
		SingersB = 65
	}

	[Token(Token = "0x2002D91")]
	public enum ShareUrlType
	{
		[Token(Token = "0x40117EE")]
		None = 1000,
		[Token(Token = "0x40117EF")]
		InviteFriend = 1001,
		[Token(Token = "0x40117F0")]
		InviteToGroup = 1002,
		[Token(Token = "0x40117F1")]
		ActivityFriendCallback = 1003,
		[Token(Token = "0x40117F2")]
		InviteToClan = 1005,
		[Token(Token = "0x40117F3")]
		InviteToRoom = 1006,
		[Token(Token = "0x40117F4")]
		SuperCarInvite = 1008,
		[Token(Token = "0x40117F5")]
		WorkShop = 1009,
		[Token(Token = "0x40117F6")]
		BigEventFriendCallback = 1010,
		[Token(Token = "0x40117F7")]
		LCDP2 = 1011,
		[Token(Token = "0x40117F8")]
		HurricaneB = 1012,
		[Token(Token = "0x40117F9")]
		LadderMatch = 1013,
		[Token(Token = "0x40117FA")]
		BigEventTemplate = 1014,
		[Token(Token = "0x40117FB")]
		DigitaluniverseB = 1015,
		[Token(Token = "0x40117FC")]
		SecretMessage = 1101
	}

	[Token(Token = "0x2002D92")]
	public enum EShareScreenType
	{
		[Token(Token = "0x40117FE")]
		LandScape,
		[Token(Token = "0x40117FF")]
		Portrait
	}

	[Token(Token = "0x2002D93")]
	public delegate void OnSavedScreenshot(bool result);

	[Token(Token = "0x2002D94")]
	private class ScreenshotRenderHandler : MonoBehaviour
	{
		[Token(Token = "0x2002D95")]
		public delegate void RenderedCallback(ScreenshotRenderHandler handler);

		[Token(Token = "0x4011800")]
		[FieldOffset(Offset = "0xC")]
		public RenderedCallback OnRendered;

		[Token(Token = "0x4011801")]
		[FieldOffset(Offset = "0x10")]
		public bool AllowHDR;

		[Token(Token = "0x6013166")]
		[Address(RVA = "0x2843858", Offset = "0x2843858", VA = "0x2843858")]
		public ScreenshotRenderHandler()
		{
		}

		[Token(Token = "0x6013167")]
		[Address(RVA = "0x2843860", Offset = "0x2843860", VA = "0x2843860")]
		private void OnPreCull()
		{
		}

		[Token(Token = "0x6013168")]
		[Address(RVA = "0x2843A58", Offset = "0x2843A58", VA = "0x2843A58")]
		private void OnPostRender()
		{
		}
	}

	[Token(Token = "0x2002D96")]
	private sealed class _003CPlayAnimAndCallFunWhenAnimEnds_003Ec__AnonStorey0
	{
		[Token(Token = "0x4011802")]
		[FieldOffset(Offset = "0x8")]
		internal Action action;

		[Token(Token = "0x601316D")]
		[Address(RVA = "0x2843020", Offset = "0x2843020", VA = "0x2843020")]
		public _003CPlayAnimAndCallFunWhenAnimEnds_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x601316E")]
		[Address(RVA = "0x2843028", Offset = "0x2843028", VA = "0x2843028")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2002D97")]
	private sealed class _003CSaveScreenshot_003Ec__AnonStorey1
	{
		[Token(Token = "0x4011803")]
		[FieldOffset(Offset = "0x8")]
		internal RenderTexture renderTexture;

		[Token(Token = "0x4011804")]
		[FieldOffset(Offset = "0xC")]
		internal bool needRotationResultPic;

		[Token(Token = "0x4011805")]
		[FieldOffset(Offset = "0x10")]
		internal string filePath;

		[Token(Token = "0x4011806")]
		[FieldOffset(Offset = "0x14")]
		internal OnSavedScreenshot saved;

		[Token(Token = "0x601316F")]
		[Address(RVA = "0x2843214", Offset = "0x2843214", VA = "0x2843214")]
		public _003CSaveScreenshot_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6013170")]
		[Address(RVA = "0x284321C", Offset = "0x284321C", VA = "0x284321C")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2002D98")]
	private sealed class _003CRenderScreenshot_003Ec__AnonStorey2
	{
		[Token(Token = "0x4011807")]
		[FieldOffset(Offset = "0x8")]
		internal bool needPostEffect;

		[Token(Token = "0x6013171")]
		[Address(RVA = "0x2843054", Offset = "0x2843054", VA = "0x2843054")]
		public _003CRenderScreenshot_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x6013172")]
		[Address(RVA = "0x284305C", Offset = "0x284305C", VA = "0x284305C")]
		internal bool _003C_003Em__0(Camera camera)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4011779")]
	[FieldOffset(Offset = "0x0")]
	public static string PlatformIcon_Guest;

	[Token(Token = "0x401177A")]
	[FieldOffset(Offset = "0x4")]
	public static string PlatformIcon_HW;

	[Token(Token = "0x401177B")]
	[FieldOffset(Offset = "0x8")]
	public static string PlatformIcon_VK;

	[Token(Token = "0x401177C")]
	[FieldOffset(Offset = "0xC")]
	public static string PlatformIcon_FB;

	[Token(Token = "0x401177D")]
	[FieldOffset(Offset = "0x10")]
	public static string PlatformIcon_FF_VK;

	[Token(Token = "0x401177E")]
	[FieldOffset(Offset = "0x14")]
	public static string PlatformIcon_Google;

	[Token(Token = "0x401177F")]
	[FieldOffset(Offset = "0x18")]
	public static string PlatformIcon_Garena;

	[Token(Token = "0x4011780")]
	[FieldOffset(Offset = "0x1C")]
	public static string[] LevelSpirteNameArray;

	[Token(Token = "0x4011781")]
	[FieldOffset(Offset = "0x20")]
	public static string[] ProfileTagLevel;

	[Token(Token = "0x4011782")]
	[FieldOffset(Offset = "0x24")]
	public static string[] ProfileActiveTime;

	[Token(Token = "0x4011783")]
	[FieldOffset(Offset = "0x28")]
	public static string[] ProfileOnlineTime;

	[Token(Token = "0x4011784")]
	[FieldOffset(Offset = "0x2C")]
	public static string[] ProfileModePrefer;

	[Token(Token = "0x4011785")]
	[FieldOffset(Offset = "0x30")]
	public static string[] ProfileSex;

	[Token(Token = "0x4011786")]
	[FieldOffset(Offset = "0x34")]
	public static string[] ProfileModes;

	[Token(Token = "0x4011787")]
	[FieldOffset(Offset = "0x38")]
	public static Rect SCREEN_MARGIN_RATIO;

	[Token(Token = "0x4011788")]
	private const string SCREENSHOT_FILE_NAME = "Free Fire Screenshot.png";

	[Token(Token = "0x4011789")]
	[FieldOffset(Offset = "0x48")]
	public static float MAP_WIDTH;

	[Token(Token = "0x401178A")]
	[FieldOffset(Offset = "0x4C")]
	public static string CLICK_FILTER_MAP;

	[Token(Token = "0x401178B")]
	[FieldOffset(Offset = "0x50")]
	public static string CLICK_FILTER_GROUP;

	[Token(Token = "0x401178C")]
	[FieldOffset(Offset = "0x54")]
	public static string CLICK_FILTER_PVE_MAP;

	[Token(Token = "0x401178D")]
	[FieldOffset(Offset = "0x58")]
	public static string CLICK_FILTER_TEAM;

	[Token(Token = "0x401178E")]
	[FieldOffset(Offset = "0x5C")]
	public static string CLICK_FILTER_GIFTRECEIVERLIST;

	[Token(Token = "0x401178F")]
	[FieldOffset(Offset = "0x60")]
	public static string CLICK_FILTER_TUTORIAL;

	[Token(Token = "0x4011790")]
	[FieldOffset(Offset = "0x64")]
	public static string CLICK_FILTER_VOUCHERLIST;

	[Token(Token = "0x4011791")]
	[FieldOffset(Offset = "0x68")]
	public static string CLICK_FILTER_TEAM_MODE_BTN;

	[Token(Token = "0x4011792")]
	public const float PERFECT_PROPROTION_TO_ICONBOXWIDTH = 1f;

	[Token(Token = "0x4011793")]
	public const float PERFECT_PROPROTION_TO_ICONBOXHEIGHT = 0.5f;

	[Token(Token = "0x4011794")]
	[FieldOffset(Offset = "0x6C")]
	private static string HINDI_CULTURE_CODE;

	[Token(Token = "0x4011795")]
	[FieldOffset(Offset = "0x70")]
	private static int[] HINDI_NUMBER_GROUP_SIZE;

	[Token(Token = "0x4011796")]
	[FieldOffset(Offset = "0x74")]
	private static readonly Color[] MARKCOLOR;

	[Token(Token = "0x4011797")]
	[FieldOffset(Offset = "0x78")]
	private static readonly Color[] MARKCOLOR_TEAM;

	[Token(Token = "0x4011798")]
	[FieldOffset(Offset = "0x7C")]
	private static readonly Color HP_COLOR_NORMAL;

	[Token(Token = "0x4011799")]
	[FieldOffset(Offset = "0x8C")]
	private static readonly Color HP_COLOR_WARNING;

	[Token(Token = "0x401179A")]
	[FieldOffset(Offset = "0x9C")]
	private static readonly Color HP_COLOR_DANGER;

	[Token(Token = "0x401179B")]
	[FieldOffset(Offset = "0xAC")]
	private static readonly Color HP_COLOR_KNOCK_DOWN;

	[Token(Token = "0x401179C")]
	[FieldOffset(Offset = "0xBC")]
	private static readonly Color HP_COLOR_WARNING_VEHICLE;

	[Token(Token = "0x401179D")]
	[FieldOffset(Offset = "0xCC")]
	private static readonly Color HP_COLOR_DANGER_VEHICLE;

	[Token(Token = "0x401179E")]
	[FieldOffset(Offset = "0xDC")]
	private static readonly Color EP_COLOR_NORMAL;

	[Token(Token = "0x401179F")]
	[FieldOffset(Offset = "0xEC")]
	private static readonly Color EP_COLOR_DISABLE;

	[Token(Token = "0x40117A0")]
	[FieldOffset(Offset = "0xFC")]
	private static readonly Color ELITEPASS_COLOR;

	[Token(Token = "0x40117A1")]
	[FieldOffset(Offset = "0x10C")]
	public static readonly Color ITEM_COLOR_NEW;

	[Token(Token = "0x40117A2")]
	[FieldOffset(Offset = "0x11C")]
	public static readonly Color ITEM_COLOR_DISCOUNT;

	[Token(Token = "0x40117A3")]
	[FieldOffset(Offset = "0x12C")]
	public static readonly Color ITEM_COLOR_LIMIT;

	[Token(Token = "0x40117A4")]
	[FieldOffset(Offset = "0x13C")]
	public static readonly Color ITEM_COLOR_HOT;

	[Token(Token = "0x40117A5")]
	[FieldOffset(Offset = "0x14C")]
	public static readonly Color ITEM_COLOR_EXPIRE;

	[Token(Token = "0x40117A6")]
	[FieldOffset(Offset = "0x15C")]
	public static readonly Color ITEM_COLOR_PREVIEW;

	[Token(Token = "0x40117A7")]
	[FieldOffset(Offset = "0x16C")]
	public static readonly Color ITEM_COLOR_GRENADE_CHOOSE;

	[Token(Token = "0x40117A8")]
	[FieldOffset(Offset = "0x17C")]
	public static readonly Color ITEM_COLOR_GRENADE_COMMON;

	[Token(Token = "0x40117A9")]
	[FieldOffset(Offset = "0x18C")]
	public static readonly Color ITEM_COLOR_LOADOUT_CHARGE;

	[Token(Token = "0x40117AA")]
	[FieldOffset(Offset = "0x19C")]
	private static Action _OnRenderedScreenshot;

	[Token(Token = "0x40117AB")]
	[FieldOffset(Offset = "0x1A0")]
	private static int _ScreenshotWaitingCameras;

	[Token(Token = "0x40117AC")]
	[FieldOffset(Offset = "0x1A4")]
	public static readonly uint[] BIG_LADDER_IDS;

	[Token(Token = "0x40117AD")]
	[FieldOffset(Offset = "0x1A8")]
	public static readonly uint[] BIG_CS_LADDER_IDS;

	[Token(Token = "0x40117AE")]
	[FieldOffset(Offset = "0x1AC")]
	private static Color ColorHide;

	[Token(Token = "0x40117AF")]
	[FieldOffset(Offset = "0x1BC")]
	private static Color ColorShow;

	[Token(Token = "0x40117B0")]
	[FieldOffset(Offset = "0x1CC")]
	private static ScreenshotRenderHandler.RenderedCallback _003C_003Ef__mg_0024cache0;

	[Token(Token = "0x40117B1")]
	[FieldOffset(Offset = "0x1D0")]
	private static Comparison<Camera> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x40117B2")]
	[FieldOffset(Offset = "0x1D4")]
	private static Predicate<RareProbability> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x40117B3")]
	[FieldOffset(Offset = "0x1D8")]
	private static Comparison<RareProbability> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x40117B4")]
	[FieldOffset(Offset = "0x1DC")]
	private static Comparison<ItemProbabilityInfo> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x40117B5")]
	[FieldOffset(Offset = "0x1E0")]
	private static Predicate<RareProbability> _003C_003Ef__am_0024cache4;

	[Token(Token = "0x40117B6")]
	[FieldOffset(Offset = "0x1E4")]
	private static Comparison<RareProbability> _003C_003Ef__am_0024cache5;

	[Token(Token = "0x40117B7")]
	[FieldOffset(Offset = "0x1E8")]
	private static Func<char, bool> _003C_003Ef__mg_0024cache1;

	[Token(Token = "0x40117B8")]
	[FieldOffset(Offset = "0x1EC")]
	private static Func<float, float> _003C_003Ef__am_0024cache6;

	[Token(Token = "0x17001387")]
	public static string DefaultScreenshotFilePath
	{
		[Token(Token = "0x60130F8")]
		[Address(RVA = "0xF5B5A0", Offset = "0xF5B5A0", VA = "0xF5B5A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001388")]
	private static ResourceID DEFAULT_OPT_ATLASID
	{
		[Token(Token = "0x60130F9")]
		[Address(RVA = "0xF5B680", Offset = "0xF5B680", VA = "0xF5B680")]
		get
		{
			return default(ResourceID);
		}
	}

	[Token(Token = "0x60130FA")]
	public static T GetRandomItem<T>(T[] ts)
	{
		return (T)null;
	}

	[Token(Token = "0x60130FB")]
	[Address(RVA = "0xF5B724", Offset = "0xF5B724", VA = "0xF5B724")]
	public static int RandomWeight(uint[] weights)
	{
		return default(int);
	}

	[Token(Token = "0x60130FC")]
	[Address(RVA = "0xF5B8EC", Offset = "0xF5B8EC", VA = "0xF5B8EC")]
	public static bool IsEquippedByID(uint id)
	{
		return default(bool);
	}

	[Token(Token = "0x60130FD")]
	[Address(RVA = "0xF5C494", Offset = "0xF5C494", VA = "0xF5C494")]
	public static bool IsDefaultItemByID(uint id)
	{
		return default(bool);
	}

	[Token(Token = "0x60130FE")]
	[Address(RVA = "0xF5C6C0", Offset = "0xF5C6C0", VA = "0xF5C6C0")]
	public static bool CheckIdFemaleInvalid(uint id)
	{
		return default(bool);
	}

	[Token(Token = "0x60130FF")]
	[Address(RVA = "0xF5C864", Offset = "0xF5C864", VA = "0xF5C864")]
	public static bool IsCanEquipeByID(uint id)
	{
		return default(bool);
	}

	[Token(Token = "0x6013100")]
	[Address(RVA = "0xF5CA64", Offset = "0xF5CA64", VA = "0xF5CA64")]
	public static string WrapText(UILabel label, string value)
	{
		return null;
	}

	[Token(Token = "0x6013101")]
	[Address(RVA = "0xF5CC28", Offset = "0xF5CC28", VA = "0xF5CC28")]
	public static string SeparateDigit(int number, string cultureCode)
	{
		return null;
	}

	[Token(Token = "0x6013102")]
	[Address(RVA = "0xF5CE88", Offset = "0xF5CE88", VA = "0xF5CE88")]
	public static float GetAnimDuratin(Animation animation, [Optional] string clipName)
	{
		return default(float);
	}

	[Token(Token = "0x6013103")]
	[Address(RVA = "0xF5D108", Offset = "0xF5D108", VA = "0xF5D108")]
	public static void ResetAnimation(Animation animation, [Optional] string clipName)
	{
	}

	[Token(Token = "0x6013104")]
	[Address(RVA = "0xF5D480", Offset = "0xF5D480", VA = "0xF5D480")]
	public static void SkipAnimation(Animation animation, [Optional] string clipName)
	{
	}

	[Token(Token = "0x6013105")]
	[Address(RVA = "0xF5D7E4", Offset = "0xF5D7E4", VA = "0xF5D7E4")]
	public static void ResetAllAnimation(Animation animation)
	{
	}

	[Token(Token = "0x6013106")]
	[Address(RVA = "0xF5DC60", Offset = "0xF5DC60", VA = "0xF5DC60")]
	public static uint PlayAnimAndCallFunWhenAnimEnds(Animation anim, string animName, Action action)
	{
		return default(uint);
	}

	[Token(Token = "0x6013107")]
	[Address(RVA = "0xF5DF04", Offset = "0xF5DF04", VA = "0xF5DF04")]
	public static string GetPlatformIcon(PlatformType platform)
	{
		return null;
	}

	[Token(Token = "0x6013108")]
	[Address(RVA = "0xF5E1C4", Offset = "0xF5E1C4", VA = "0xF5E1C4")]
	public static bool AdjustSlotSpriteSize(UISprite InSprite, Vector2 InMargin)
	{
		return default(bool);
	}

	[Token(Token = "0x6013109")]
	[Address(RVA = "0xF5E608", Offset = "0xF5E608", VA = "0xF5E608")]
	public static Color GetGradientLerpColorByRatio(int InMax, int InValue)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color);
	}

	[Token(Token = "0x601310A")]
	[Address(RVA = "0xF5E810", Offset = "0xF5E810", VA = "0xF5E810")]
	public static Color GetColorByItemLevel(int level)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color);
	}

	[Token(Token = "0x601310B")]
	[Address(RVA = "0xF5E8C0", Offset = "0xF5E8C0", VA = "0xF5E8C0")]
	public static void UpdateMarkColorByTeamIndex(UISprite icon, int teamIndex)
	{
	}

	[Token(Token = "0x601310C")]
	[Address(RVA = "0xF5EB5C", Offset = "0xF5EB5C", VA = "0xF5EB5C")]
	public static Color GetMarkColorByTeamIndex2(int teamIndex)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color);
	}

	[Token(Token = "0x601310D")]
	[Address(RVA = "0xF5EDBC", Offset = "0xF5EDBC", VA = "0xF5EDBC")]
	public static Color GetMarkColorByTeamIndex(int teamIndex)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color);
	}

	[Token(Token = "0x601310E")]
	[Address(RVA = "0xF5F01C", Offset = "0xF5F01C", VA = "0xF5F01C")]
	public static Color GetVehicleHPColor(float ratio)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color);
	}

	[Token(Token = "0x601310F")]
	[Address(RVA = "0xF5F1B4", Offset = "0xF5F1B4", VA = "0xF5F1B4")]
	public static Color GetHPColor(bool isDieing, float ratio)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color);
	}

	[Token(Token = "0x6013110")]
	[Address(RVA = "0xF5F3AC", Offset = "0xF5F3AC", VA = "0xF5F3AC")]
	public static Color GetHPColor(Player player, float ratio)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color);
	}

	[Token(Token = "0x6013111")]
	[Address(RVA = "0xF5F554", Offset = "0xF5F554", VA = "0xF5F554")]
	public static Color GetEPColor(Player player, float ratio)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color);
	}

	[Token(Token = "0x6013112")]
	[Address(RVA = "0xF5F6B4", Offset = "0xF5F6B4", VA = "0xF5F6B4")]
	public static Color GetElitePassColor(bool isFirePass)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color);
	}

	[Token(Token = "0x6013113")]
	[Address(RVA = "0xF5F7D8", Offset = "0xF5F7D8", VA = "0xF5F7D8")]
	public static void SetTagStyle(uint tagType, UISprite tagIcon)
	{
	}

	[Token(Token = "0x6013114")]
	[Address(RVA = "0xF5F988", Offset = "0xF5F988", VA = "0xF5F988")]
	public static bool BindAtlasSpriteByResourceID(ResourceID InResID, UISprite InSprite)
	{
		return default(bool);
	}

	[Token(Token = "0x6013115")]
	[Address(RVA = "0xF5FE88", Offset = "0xF5FE88", VA = "0xF5FE88")]
	public static void SetActive(GameObject go, bool state)
	{
	}

	[Token(Token = "0x6013116")]
	[Address(RVA = "0xF3A694", Offset = "0xF3A694", VA = "0xF3A694")]
	public static bool GetAtlasSpriteByResourceID(ResourceID InResID, out string OutStrSprite, out UIAtlas OutAtlas)
	{
		return default(bool);
	}

	[Token(Token = "0x6013117")]
	[Address(RVA = "0xF5FFC4", Offset = "0xF5FFC4", VA = "0xF5FFC4")]
	public static string GetLevelSprite(int EquipmentLevel)
	{
		return null;
	}

	[Token(Token = "0x6013118")]
	[Address(RVA = "0xF60188", Offset = "0xF60188", VA = "0xF60188")]
	public static void SetSpriteNameByString(UISprite sprite, string spriteName, SpriteScaleType scaleType = SpriteScaleType.Fit, bool makePixelPerfect = true)
	{
	}

	[Token(Token = "0x6013119")]
	[Address(RVA = "0xF4BC78", Offset = "0xF4BC78", VA = "0xF4BC78")]
	public static void SetSpriteName(UISprite sprite, ResourceID resourceID, SpriteScaleType scaleType = SpriteScaleType.Fit, bool makePixelPerfect = true)
	{
	}

	[Token(Token = "0x601311A")]
	[Address(RVA = "0xF60380", Offset = "0xF60380", VA = "0xF60380")]
	public static void SetSpriteTokenIcon(UISprite targetSprite, EInventory.AwardType tokenType, uint tokenID, SpriteScaleType scaleType = SpriteScaleType.Fit, bool makePixelPerfect = true)
	{
	}

	[Token(Token = "0x601311B")]
	[Address(RVA = "0xF606F4", Offset = "0xF606F4", VA = "0xF606F4")]
	public static void SetSpriteItemIcon(UISprite targetSprite, Vector2 maxSize, ResourceID iconRes, bool enableEnlarge = false)
	{
	}

	[Token(Token = "0x601311C")]
	[Address(RVA = "0xF60ABC", Offset = "0xF60ABC", VA = "0xF60ABC")]
	public static void GetIconValidContentPixSize(UISprite targetSprite, Vector2 maxSize, bool enableEnlarge = false)
	{
	}

	[Token(Token = "0x601311D")]
	[Address(RVA = "0xF60CF8", Offset = "0xF60CF8", VA = "0xF60CF8")]
	public static void SetSpriteItemIcon(UISprite targetSprite, Vector2 maxSize, ResourceID iconRes, UISprite Bg, Vector2 BgPending, bool BgFixedHeight = true)
	{
	}

	[Token(Token = "0x601311E")]
	[Address(RVA = "0xF60EF8", Offset = "0xF60EF8", VA = "0xF60EF8")]
	public static void UpdateWidgetColliderWithSpecialGameObject(BoxCollider box, GameObject go, bool considerInactive)
	{
	}

	[Token(Token = "0x601311F")]
	[Address(RVA = "0xF61498", Offset = "0xF61498", VA = "0xF61498")]
	public static void MoveScrollViewToBottom(UIScrollView scrollView)
	{
	}

	[Token(Token = "0x6013120")]
	public static bool IsSameList<T>(List<T> list_a, List<T> list_b)
	{
		return default(bool);
	}

	[Token(Token = "0x6013121")]
	[Address(RVA = "0xF6192C", Offset = "0xF6192C", VA = "0xF6192C")]
	public static void SaveScreenshot(string filePath, OnSavedScreenshot saved, bool needRotationResultPic, int width, int height)
	{
	}

	[Token(Token = "0x6013122")]
	[Address(RVA = "0xF628DC", Offset = "0xF628DC", VA = "0xF628DC")]
	public static void SaveScreenshot(string filePath, OnSavedScreenshot saved, bool needRotationResultPic)
	{
	}

	[Token(Token = "0x6013123")]
	[Address(RVA = "0xF629EC", Offset = "0xF629EC", VA = "0xF629EC")]
	public static Texture2D RotationTexture(Texture2D originalTexture, bool clockwise = true)
	{
		return null;
	}

	[Token(Token = "0x6013124")]
	[Address(RVA = "0xF62CCC", Offset = "0xF62CCC", VA = "0xF62CCC")]
	public static bool SaveImageToFile(Texture2D image, string filePath)
	{
		return default(bool);
	}

	[Token(Token = "0x6013125")]
	[Address(RVA = "0xF62F5C", Offset = "0xF62F5C", VA = "0xF62F5C")]
	private static void OnRenderedScreenshot()
	{
	}

	[Token(Token = "0x6013126")]
	[Address(RVA = "0xF630A4", Offset = "0xF630A4", VA = "0xF630A4")]
	private static void OnCameraRenderedScreenshot(ScreenshotRenderHandler handler)
	{
	}

	[Token(Token = "0x6013127")]
	[Address(RVA = "0xF61B1C", Offset = "0xF61B1C", VA = "0xF61B1C")]
	public static void RenderScreenshot(RenderTexture screenshot, Action done)
	{
	}

	[Token(Token = "0x6013128")]
	[Address(RVA = "0xF63238", Offset = "0xF63238", VA = "0xF63238")]
	public static int GetRareTypeSortValue(uint rare)
	{
		return default(int);
	}

	[Token(Token = "0x6013129")]
	[Address(RVA = "0xF632C8", Offset = "0xF632C8", VA = "0xF632C8")]
	public static List<string> GenerateProbabilityString(List<RareProbability> probabilityList)
	{
		return null;
	}

	[Token(Token = "0x601312A")]
	[Address(RVA = "0xF63BD4", Offset = "0xF63BD4", VA = "0xF63BD4")]
	public static List<string> GenerateProbabilityString(List<RareProbability> rare_pr, List<ItemProbability> item_pr, List<AwardTypeProbability> award_type_pr)
	{
		return null;
	}

	[Token(Token = "0x601312B")]
	[Address(RVA = "0xF65790", Offset = "0xF65790", VA = "0xF65790")]
	public static string ItemLimitTimeFormat(uint deltaTime)
	{
		return null;
	}

	[Token(Token = "0x601312C")]
	[Address(RVA = "0xF65B8C", Offset = "0xF65B8C", VA = "0xF65B8C")]
	public static void CalFullScreenSize(out float width, out float height)
	{
	}

	[Token(Token = "0x601312D")]
	[Address(RVA = "0xF65D38", Offset = "0xF65D38", VA = "0xF65D38")]
	public static void SetCSFactionName(bool isTeamA, UILabel label)
	{
	}

	[Token(Token = "0x601312E")]
	[Address(RVA = "0xF65E9C", Offset = "0xF65E9C", VA = "0xF65E9C")]
	public static void SetCSFactionIntroduction(bool isTeamA, UILabel label)
	{
	}

	[Token(Token = "0x601312F")]
	[Address(RVA = "0xF66000", Offset = "0xF66000", VA = "0xF66000")]
	public static void SetCSFactionIcon(bool isTeamA, UISprite sprite, bool isLarge = true)
	{
	}

	[Token(Token = "0x6013130")]
	[Address(RVA = "0xF6610C", Offset = "0xF6610C", VA = "0xF6610C")]
	public static string CSFactionIcon(bool isTeamA)
	{
		return null;
	}

	[Token(Token = "0x6013131")]
	[Address(RVA = "0xF661C0", Offset = "0xF661C0", VA = "0xF661C0")]
	public static void SetFactionIcon(bool attack, UISprite sprite)
	{
	}

	[Token(Token = "0x6013132")]
	[Address(RVA = "0xF662B4", Offset = "0xF662B4", VA = "0xF662B4")]
	public static string FactionIcon(bool attack)
	{
		return null;
	}

	[Token(Token = "0x6013133")]
	[Address(RVA = "0xF66368", Offset = "0xF66368", VA = "0xF66368")]
	public static void SetFactionDescription(bool isAttack, UILabel label)
	{
	}

	[Token(Token = "0x6013134")]
	[Address(RVA = "0xF664CC", Offset = "0xF664CC", VA = "0xF664CC")]
	public static void FilterInput(UIInput input)
	{
	}

	[Token(Token = "0x6013135")]
	[Address(RVA = "0xF6667C", Offset = "0xF6667C", VA = "0xF6667C")]
	public static void ChangeResToFileInfo(List<ResourceID> ids, out List<ResVersionInfo.FileInfo> infolist)
	{
	}

	[Token(Token = "0x6013136")]
	[Address(RVA = "0xF669E8", Offset = "0xF669E8", VA = "0xF669E8")]
	public static bool CheckNeedChangeIcon(CSSharedItemData itemdata, out ResourceID resid, out bool isGemOrCoin)
	{
		return default(bool);
	}

	[Token(Token = "0x6013137")]
	[Address(RVA = "0xF66F68", Offset = "0xF66F68", VA = "0xF66F68")]
	public static void ChangeIcon(UISprite boxIcon, UIAtlas atlas, string name, Vector3 pos, bool isGemOrCoin)
	{
	}

	[Token(Token = "0x6013138")]
	[Address(RVA = "0xF67300", Offset = "0xF67300", VA = "0xF67300")]
	private static void SetComposeIcon(UISprite boxIcon, UISprite sprite, Vector3 pos, bool isGemOrCoin)
	{
	}

	[Token(Token = "0x6013139")]
	[Address(RVA = "0xF678A4", Offset = "0xF678A4", VA = "0xF678A4")]
	public static void SetQualityBG(int Quality, UISprite QualityBG, UISprite QualityNameBG01, UISprite SpriteQualityPlus, UISprite SpriteOrangeQualityPlus)
	{
	}

	[Token(Token = "0x601313A")]
	[Address(RVA = "0xF67D7C", Offset = "0xF67D7C", VA = "0xF67D7C")]
	public static void SetQualityBG2(int Quality, UISprite QualityBG, UISprite QualityNameBG01, UISprite SpriteQualityPlus, UISprite SpriteOrangeQualityPlus)
	{
	}

	[Token(Token = "0x601313B")]
	[Address(RVA = "0xF68254", Offset = "0xF68254", VA = "0xF68254")]
	public static void SetQualityWithNoBG(int Quality, UISprite QualityNameBG01, UISprite SpriteQualityPlus, UISprite SpriteOrangeQualityPlus)
	{
	}

	[Token(Token = "0x601313C")]
	[Address(RVA = "0xF6859C", Offset = "0xF6859C", VA = "0xF6859C")]
	public static void SetWeaponQualityBG(int Quality, UISprite QualityBG, UISprite QualityNameBG01, UISprite SpriteQualityPlus, UISprite SpriteOrangeQualityPlus)
	{
	}

	[Token(Token = "0x601313D")]
	[Address(RVA = "0xF68A74", Offset = "0xF68A74", VA = "0xF68A74")]
	public static bool CheckNicknameValid(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x601313E")]
	[Address(RVA = "0xF690DC", Offset = "0xF690DC", VA = "0xF690DC")]
	public static GameObject LoadRes(ResourceID res_id)
	{
		return null;
	}

	[Token(Token = "0x601313F")]
	[Address(RVA = "0xF692F8", Offset = "0xF692F8", VA = "0xF692F8")]
	public static void AdjustIPXAnchor(Transform modifiedUI)
	{
	}

	[Token(Token = "0x6013140")]
	[Address(RVA = "0xF69894", Offset = "0xF69894", VA = "0xF69894")]
	public static int GetAdjustedAnchor(int oldAnchor, float defRatio, float ipxRatio)
	{
		return default(int);
	}

	[Token(Token = "0x6013141")]
	[Address(RVA = "0xF699B0", Offset = "0xF699B0", VA = "0xF699B0")]
	public static float GetProgressValueByNonAverageMilepostValue(List<float> Mileposts, float curValue)
	{
		return default(float);
	}

	[Token(Token = "0x6013142")]
	[Address(RVA = "0xF69EDC", Offset = "0xF69EDC", VA = "0xF69EDC")]
	public static void SetSpriteByNum(int num, UISprite[] sprites, string spriteNamePrefix)
	{
	}

	[Token(Token = "0x6013143")]
	[Address(RVA = "0xF6A198", Offset = "0xF6A198", VA = "0xF6A198")]
	public static string FormatBigNum(string num, int digit = 3, string sign = ",")
	{
		return null;
	}

	[Token(Token = "0x6013144")]
	[Address(RVA = "0xF6A8AC", Offset = "0xF6A8AC", VA = "0xF6A8AC")]
	public static bool IsIphoneXDevice()
	{
		return default(bool);
	}

	[Token(Token = "0x6013145")]
	[Address(RVA = "0xF6A8FC", Offset = "0xF6A8FC", VA = "0xF6A8FC")]
	public static void InitNGUINotchSetting(bool reset = false)
	{
	}

	[Token(Token = "0x6013146")]
	[Address(RVA = "0xF6AC44", Offset = "0xF6AC44", VA = "0xF6AC44")]
	public static bool IsBG1500x750(ResourceID bg)
	{
		return default(bool);
	}

	[Token(Token = "0x6013147")]
	[Address(RVA = "0xF6BB18", Offset = "0xF6BB18", VA = "0xF6BB18")]
	public static Vector2 FitBgSize(int width, int height)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector2);
	}

	[Token(Token = "0x6013148")]
	[Address(RVA = "0xF3B6A0", Offset = "0xF3B6A0", VA = "0xF3B6A0")]
	public static void ClipCDNTexture(UINetworkTexture cdnTexture)
	{
	}

	[Token(Token = "0x6013149")]
	[Address(RVA = "0xF6BD60", Offset = "0xF6BD60", VA = "0xF6BD60")]
	public static Texture2D GetWorkShopMap(uint mapID)
	{
		return null;
	}

	[Token(Token = "0x601314A")]
	[Address(RVA = "0xF6C028", Offset = "0xF6C028", VA = "0xF6C028")]
	public static Texture2D GetWorkShopMiniMap(uint mapID)
	{
		return null;
	}

	[Token(Token = "0x601314B")]
	[Address(RVA = "0xF39AA4", Offset = "0xF39AA4", VA = "0xF39AA4")]
	public static void BuildWorkShopMap(uint mapID, byte[] bitMap, byte[] iconMap, UITexture bitMaptexture, UISprite iconSprite, UITexture iconSpriteSpawnParent)
	{
	}

	[Token(Token = "0x601314C")]
	[Address(RVA = "0xF6C3F8", Offset = "0xF6C3F8", VA = "0xF6C3F8")]
	public static bool NeedShowProfileInfo()
	{
		return default(bool);
	}

	[Token(Token = "0x601314D")]
	[Address(RVA = "0xF6C4D8", Offset = "0xF6C4D8", VA = "0xF6C4D8")]
	public static float CalRatioByGroupMode(HHDIPHFOBFO mode)
	{
		return default(float);
	}

	[Token(Token = "0x601314E")]
	[Address(RVA = "0xF6C55C", Offset = "0xF6C55C", VA = "0xF6C55C")]
	public static int CalMatchInfoBgWidth(HHDIPHFOBFO mode)
	{
		return default(int);
	}

	[Token(Token = "0x601314F")]
	[Address(RVA = "0xF6C5D0", Offset = "0xF6C5D0", VA = "0xF6C5D0")]
	public static void AdjustClipPanelWithActiveWidth(UIPanel scrollViewPanel, bool changeChild = true)
	{
	}

	[Token(Token = "0x6013150")]
	[Address(RVA = "0xF6CB2C", Offset = "0xF6CB2C", VA = "0xF6CB2C")]
	public static void SetButtonActiveAndGray(UIButton button, bool active)
	{
	}

	[Token(Token = "0x6013151")]
	[Address(RVA = "0xF6CD40", Offset = "0xF6CD40", VA = "0xF6CD40")]
	public static void SetUILabelWithSprite(UILabel label, string text, List<ResourceID> resourceList)
	{
	}

	[Token(Token = "0x6013152")]
	[Address(RVA = "0xF6D49C", Offset = "0xF6D49C", VA = "0xF6D49C")]
	public static void AddAllDragViewIgnorePlayerInput(Transform root)
	{
	}

	[Token(Token = "0x6013153")]
	[Address(RVA = "0xF6D68C", Offset = "0xF6D68C", VA = "0xF6D68C")]
	public static StandardTabTagConfig GetStandardTabTagConfig(EEventTag eEvent)
	{
		return null;
	}

	[Token(Token = "0x6013154")]
	[Address(RVA = "0xF6D800", Offset = "0xF6D800", VA = "0xF6D800")]
	public static void SetLabelColor(UILabel label, string labelColor, string gradientTop = "", string gradientBottom = "")
	{
	}

	[Token(Token = "0x6013155")]
	[Address(RVA = "0xF6DB38", Offset = "0xF6DB38", VA = "0xF6DB38")]
	public static void SetSpriteColor(UISprite sprite, string spriteColor, string gradientTop = "", string gradientBottom = "")
	{
	}

	[Token(Token = "0x6013156")]
	[Address(RVA = "0xF6DE70", Offset = "0xF6DE70", VA = "0xF6DE70")]
	public static bool CreateVFXByResName(Transform parent, string resName)
	{
		return default(bool);
	}

	[Token(Token = "0x6013157")]
	[Address(RVA = "0xF6E1C8", Offset = "0xF6E1C8", VA = "0xF6E1C8")]
	public static void SetSpriteViewByResName(UISprite sprite, string resName)
	{
	}

	[Token(Token = "0x6013158")]
	[Address(RVA = "0xF6E3C0", Offset = "0xF6E3C0", VA = "0xF6E3C0")]
	public static void SetEntranceClick(string newbietype, NewbieGuideId guideId)
	{
	}

	[Token(Token = "0x6013159")]
	[Address(RVA = "0xF6E7B0", Offset = "0xF6E7B0", VA = "0xF6E7B0")]
	public static void ShowEntranceLockTip(uint entranceId)
	{
	}

	[Token(Token = "0x601315B")]
	[Address(RVA = "0xF70154", Offset = "0xF70154", VA = "0xF70154")]
	private static int _003CRenderScreenshot_003Em__0(Camera a, Camera b)
	{
		return default(int);
	}

	[Token(Token = "0x601315C")]
	[Address(RVA = "0xF701C0", Offset = "0xF701C0", VA = "0xF701C0")]
	private static bool _003CGenerateProbabilityString_003Em__1(RareProbability item)
	{
		return default(bool);
	}

	[Token(Token = "0x601315D")]
	[Address(RVA = "0xF701EC", Offset = "0xF701EC", VA = "0xF701EC")]
	private static int _003CGenerateProbabilityString_003Em__2(RareProbability itemA, RareProbability itemB)
	{
		return default(int);
	}

	[Token(Token = "0x601315E")]
	[Address(RVA = "0xF702E4", Offset = "0xF702E4", VA = "0xF702E4")]
	private static int _003CGenerateProbabilityString_003Em__3(ItemProbabilityInfo infoA, ItemProbabilityInfo infoB)
	{
		return default(int);
	}

	[Token(Token = "0x601315F")]
	[Address(RVA = "0xF703D8", Offset = "0xF703D8", VA = "0xF703D8")]
	private static bool _003CGenerateProbabilityString_003Em__4(RareProbability item)
	{
		return default(bool);
	}

	[Token(Token = "0x6013160")]
	[Address(RVA = "0xF70404", Offset = "0xF70404", VA = "0xF70404")]
	private static int _003CGenerateProbabilityString_003Em__5(RareProbability itemA, RareProbability itemB)
	{
		return default(int);
	}

	[Token(Token = "0x6013161")]
	[Address(RVA = "0xF704DC", Offset = "0xF704DC", VA = "0xF704DC")]
	private static float _003CGetProgressValueByNonAverageMilepostValue_003Em__6(float u)
	{
		return default(float);
	}
}
