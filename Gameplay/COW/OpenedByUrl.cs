using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using InterApp;
using proto;

namespace COW;

[Token(Token = "0x20032F4")]
public static class OpenedByUrl
{
	[Token(Token = "0x20032F5")]
	public static class DownloadUrls
	{
		[Token(Token = "0x40135F2")]
		public const string STD = "http://play.google.com/store/apps/details?id=com.dts.freefireth";

		[Token(Token = "0x40135F3")]
		public const string MAX = "http://play.google.com/store/apps/details?id=com.dts.freefiremax";
	}

	[Token(Token = "0x20032F6")]
	public static class BundleIDs
	{
		[Token(Token = "0x40135F4")]
		public const string STD = "com.studioarm.sigma";

		[Token(Token = "0x40135F5")]
		public const string MAX = "com.studioarm.sigma";
	}

	[Token(Token = "0x40135DC")]
	public const string URL = "freefire://process";

	[Token(Token = "0x40135DD")]
	public const string ACTION_KEY = "action";

	[Token(Token = "0x40135DE")]
	[FieldOffset(Offset = "0x0")]
	private static bool _Inited;

	[Token(Token = "0x40135DF")]
	public const string ACTION_GROUP_INVITE = "group_invite";

	[Token(Token = "0x40135E0")]
	public const string ACTION_LOBBY = "lobby";

	[Token(Token = "0x40135E1")]
	public const string ACTION_GACHA = "gacha";

	[Token(Token = "0x40135E2")]
	public const string ACTION_MAIL = "mail";

	[Token(Token = "0x40135E3")]
	public const string ACTION_CHARACTERS_NEW = "characters_new";

	[Token(Token = "0x40135E4")]
	public const string ACTION_ELITE_PASS = "elite_pass";

	[Token(Token = "0x40135E5")]
	public const string ACTION_REBATE_CARD = "rebate_card";

	[Token(Token = "0x40135E6")]
	public const string ACTION_IAP_BUNDLE = "iap_bundle";

	[Token(Token = "0x40135E7")]
	public const string ACTION_REUNION = "reunion";

	[Token(Token = "0x40135E8")]
	public const string ACTION_NAVIGATE = "navigate";

	[Token(Token = "0x40135E9")]
	public const string ACTION_INVITE_TO_CLAN = "locate_clan";

	[Token(Token = "0x40135EA")]
	public const string ACTION_INVITE_TO_ROOM = "locate_room";

	[Token(Token = "0x40135EB")]
	public const string ACTION_SUPERCAR = "supercar";

	[Token(Token = "0x40135EC")]
	public const string ACTION_CLANWAR_RECRUIT = "clanwar_recruit";

	[Token(Token = "0x40135ED")]
	[FieldOffset(Offset = "0x4")]
	private static Dictionary<string, InterAppActionType> _ActionTypes;

	[Token(Token = "0x40135EE")]
	private const string PLAYER_PREFS_KEY_NOTIFY_TYPES = "OpeneneWithLocalNotificationTypes";

	[Token(Token = "0x40135EF")]
	[FieldOffset(Offset = "0x8")]
	private static List<UniversalLinkSettingDesc> _WebUrlToDeepLinks;

	[Token(Token = "0x40135F0")]
	[FieldOffset(Offset = "0xC")]
	private static readonly AES.AESOption aesOption;

	[Token(Token = "0x40135F1")]
	[FieldOffset(Offset = "0x10")]
	private static OpenedByUrlProcessor.ProcessDelegate _003C_003Ef__mg_0024cache0;

	[Token(Token = "0x170016B5")]
	public static Dictionary<int, int> OpenedWithLocalNotificationTypes
	{
		[Token(Token = "0x60157A7")]
		[Address(RVA = "0x28C1C18", Offset = "0x28C1C18", VA = "0x28C1C18")]
		get
		{
			return null;
		}
		[Token(Token = "0x60157A8")]
		[Address(RVA = "0x28C20CC", Offset = "0x28C20CC", VA = "0x28C20CC")]
		set
		{
		}
	}

	[Token(Token = "0x6015793")]
	[Address(RVA = "0x28BE4C0", Offset = "0x28BE4C0", VA = "0x28BE4C0")]
	private static void Log(string content)
	{
	}

	[Token(Token = "0x6015794")]
	[Address(RVA = "0x28BE58C", Offset = "0x28BE58C", VA = "0x28BE58C")]
	private static void LogVerbose(string content)
	{
	}

	[Token(Token = "0x6015795")]
	[Address(RVA = "0x28BE690", Offset = "0x28BE690", VA = "0x28BE690")]
	public static string PrepareForGroupInvite(string url, string groupId, string region, string secretCode)
	{
		return null;
	}

	[Token(Token = "0x6015796")]
	[Address(RVA = "0x28BE950", Offset = "0x28BE950", VA = "0x28BE950")]
	public static string PrepareForRebateCard()
	{
		return null;
	}

	[Token(Token = "0x6015797")]
	[Address(RVA = "0x28BEA84", Offset = "0x28BEA84", VA = "0x28BEA84")]
	public static string PrepareForLobby()
	{
		return null;
	}

	[Token(Token = "0x6015798")]
	[Address(RVA = "0x28BEBB8", Offset = "0x28BEBB8", VA = "0x28BEBB8")]
	public static string PrepareForReunion(string url, string uid)
	{
		return null;
	}

	[Token(Token = "0x6015799")]
	[Address(RVA = "0x28BED70", Offset = "0x28BED70", VA = "0x28BED70")]
	public static string PrepareForIAPBundle()
	{
		return null;
	}

	[Token(Token = "0x601579A")]
	[Address(RVA = "0x28BEEA4", Offset = "0x28BEEA4", VA = "0x28BEEA4")]
	public static string PrepareForGacha()
	{
		return null;
	}

	[Token(Token = "0x601579B")]
	[Address(RVA = "0x28BEFD8", Offset = "0x28BEFD8", VA = "0x28BEFD8")]
	public static string PrepareForClanWarRecruit()
	{
		return null;
	}

	[Token(Token = "0x601579C")]
	[Address(RVA = "0x28BF10C", Offset = "0x28BF10C", VA = "0x28BF10C")]
	public static string PrepareForMail()
	{
		return null;
	}

	[Token(Token = "0x601579D")]
	[Address(RVA = "0x28BF240", Offset = "0x28BF240", VA = "0x28BF240")]
	public static string PrepareForNavigate(string url, uint pos, string param = "")
	{
		return null;
	}

	[Token(Token = "0x601579E")]
	[Address(RVA = "0x28BF664", Offset = "0x28BF664", VA = "0x28BF664")]
	public static string PrepareForInviteToClan(string url, string clanId)
	{
		return null;
	}

	[Token(Token = "0x601579F")]
	[Address(RVA = "0x28BF81C", Offset = "0x28BF81C", VA = "0x28BF81C")]
	public static string PrepareForInviteToRoom(string url, int roomType, string roomId)
	{
		return null;
	}

	[Token(Token = "0x60157A0")]
	[Address(RVA = "0x28BFA54", Offset = "0x28BFA54", VA = "0x28BFA54")]
	public static string PrepareForSuperCarInvite(string url, ulong helpee_id)
	{
		return null;
	}

	[Token(Token = "0x60157A1")]
	[Address(RVA = "0x28BFC2C", Offset = "0x28BFC2C", VA = "0x28BFC2C")]
	public static void Init()
	{
	}

	[Token(Token = "0x60157A2")]
	[Address(RVA = "0x28C0108", Offset = "0x28C0108", VA = "0x28C0108")]
	private static void ProcessFallback(string url)
	{
	}

	[Token(Token = "0x60157A3")]
	[Address(RVA = "0x28C015C", Offset = "0x28C015C", VA = "0x28C015C")]
	private static PlatformUtility.OpenedWith OverrideOpenedWith(PlatformUtility.OpenedWith ow)
	{
		return null;
	}

	[Token(Token = "0x60157A4")]
	[Address(RVA = "0x28C0500", Offset = "0x28C0500", VA = "0x28C0500")]
	private static string TranslateWebUrlToDeepLink(string webUrl)
	{
		return null;
	}

	[Token(Token = "0x60157A5")]
	[Address(RVA = "0x28C0E30", Offset = "0x28C0E30", VA = "0x28C0E30")]
	public static bool WillProcessOpenedWith()
	{
		return default(bool);
	}

	[Token(Token = "0x60157A6")]
	[Address(RVA = "0x28C196C", Offset = "0x28C196C", VA = "0x28C196C")]
	public static void LogOpenedWith()
	{
	}

	[Token(Token = "0x60157A9")]
	[Address(RVA = "0x28C25A8", Offset = "0x28C25A8", VA = "0x28C25A8")]
	public static void SetupWebUrlToDeepLinks(CSGetUniversalLinkSettingRes res)
	{
	}

	[Token(Token = "0x60157AA")]
	[Address(RVA = "0x28C2B38", Offset = "0x28C2B38", VA = "0x28C2B38")]
	public static void ProcessOpenedWith()
	{
	}

	[Token(Token = "0x60157AB")]
	[Address(RVA = "0x28C15BC", Offset = "0x28C15BC", VA = "0x28C15BC")]
	private static bool WillProcessParams(OpenedWithParamsDelegate.OpenedWithParams parameters)
	{
		return default(bool);
	}

	[Token(Token = "0x60157AC")]
	[Address(RVA = "0x28C331C", Offset = "0x28C331C", VA = "0x28C331C")]
	private static void ProcessParams(OpenedWithParamsDelegate.OpenedWithParams parameters)
	{
	}

	[Token(Token = "0x60157AD")]
	[Address(RVA = "0x28C133C", Offset = "0x28C133C", VA = "0x28C133C")]
	private static bool WillProcess(string url)
	{
		return default(bool);
	}

	[Token(Token = "0x60157AE")]
	[Address(RVA = "0x28C3014", Offset = "0x28C3014", VA = "0x28C3014")]
	public static void Process(string url)
	{
	}

	[Token(Token = "0x60157AF")]
	[Address(RVA = "0x28BF534", Offset = "0x28BF534", VA = "0x28BF534")]
	public static string ToBase64(string str)
	{
		return null;
	}

	[Token(Token = "0x60157B0")]
	[Address(RVA = "0x28C37A4", Offset = "0x28C37A4", VA = "0x28C37A4")]
	public static string FromBase64(string base64)
	{
		return null;
	}

	[Token(Token = "0x60157B2")]
	[Address(RVA = "0x28C4A04", Offset = "0x28C4A04", VA = "0x28C4A04")]
	private static void _003C_ActionTypes_003Em__0(InterAppAction action)
	{
	}

	[Token(Token = "0x60157B3")]
	[Address(RVA = "0x28C4D40", Offset = "0x28C4D40", VA = "0x28C4D40")]
	private static void _003C_ActionTypes_003Em__1(InterAppAction action)
	{
	}

	[Token(Token = "0x60157B4")]
	[Address(RVA = "0x28C4E78", Offset = "0x28C4E78", VA = "0x28C4E78")]
	private static void _003C_ActionTypes_003Em__2(InterAppAction action)
	{
	}

	[Token(Token = "0x60157B5")]
	[Address(RVA = "0x28C4FB0", Offset = "0x28C4FB0", VA = "0x28C4FB0")]
	private static void _003C_ActionTypes_003Em__3(InterAppAction action)
	{
	}

	[Token(Token = "0x60157B6")]
	[Address(RVA = "0x28C5178", Offset = "0x28C5178", VA = "0x28C5178")]
	private static void _003C_ActionTypes_003Em__4(InterAppAction action)
	{
	}

	[Token(Token = "0x60157B7")]
	[Address(RVA = "0x28C52B0", Offset = "0x28C52B0", VA = "0x28C52B0")]
	private static void _003C_ActionTypes_003Em__5(InterAppAction action)
	{
	}

	[Token(Token = "0x60157B8")]
	[Address(RVA = "0x28C53E8", Offset = "0x28C53E8", VA = "0x28C53E8")]
	private static void _003C_ActionTypes_003Em__6(InterAppAction action)
	{
	}

	[Token(Token = "0x60157B9")]
	[Address(RVA = "0x28C5520", Offset = "0x28C5520", VA = "0x28C5520")]
	private static void _003C_ActionTypes_003Em__7(InterAppAction action)
	{
	}

	[Token(Token = "0x60157BA")]
	[Address(RVA = "0x28C5658", Offset = "0x28C5658", VA = "0x28C5658")]
	private static void _003C_ActionTypes_003Em__8(InterAppAction action)
	{
	}

	[Token(Token = "0x60157BB")]
	[Address(RVA = "0x28C5790", Offset = "0x28C5790", VA = "0x28C5790")]
	private static void _003C_ActionTypes_003Em__9(InterAppAction action)
	{
	}

	[Token(Token = "0x60157BC")]
	[Address(RVA = "0x28C58C8", Offset = "0x28C58C8", VA = "0x28C58C8")]
	private static void _003C_ActionTypes_003Em__A(InterAppAction action)
	{
	}

	[Token(Token = "0x60157BD")]
	[Address(RVA = "0x28C5C2C", Offset = "0x28C5C2C", VA = "0x28C5C2C")]
	private static void _003C_ActionTypes_003Em__B(InterAppAction action)
	{
	}

	[Token(Token = "0x60157BE")]
	[Address(RVA = "0x28C5DF4", Offset = "0x28C5DF4", VA = "0x28C5DF4")]
	private static void _003C_ActionTypes_003Em__C(InterAppAction action)
	{
	}

	[Token(Token = "0x60157BF")]
	[Address(RVA = "0x28C607C", Offset = "0x28C607C", VA = "0x28C607C")]
	private static void _003C_ActionTypes_003Em__D(InterAppAction action)
	{
	}
}
