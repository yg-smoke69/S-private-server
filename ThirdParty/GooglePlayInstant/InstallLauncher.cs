using Il2CppDummyDll;
using UnityEngine;

namespace GooglePlayInstant;

[Token(Token = "0x200007E")]
public static class InstallLauncher
{
	[Token(Token = "0x40002BA")]
	private const string IntentActionInstantAppInstall = "com.google.android.finsky.action.IA_INSTALL";

	[Token(Token = "0x40002BB")]
	private const int IgnoredRequestCode = 1001;

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0x35085EC", Offset = "0x35085EC", VA = "0x35085EC")]
	public static void ShowInstallPrompt()
	{
	}

	[Token(Token = "0x60002E9")]
	[Address(RVA = "0x3508A84", Offset = "0x3508A84", VA = "0x3508A84")]
	public static void ShowInstallPrompt(AndroidJavaObject activity, int requestCode, AndroidJavaObject postInstallIntent, string referrer)
	{
	}

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0x3508A88", Offset = "0x3508A88", VA = "0x3508A88")]
	public static AndroidJavaObject GetCurrentActivity()
	{
		return null;
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0x35087E0", Offset = "0x35087E0", VA = "0x35087E0")]
	public static AndroidJavaObject CreatePostInstallIntent(AndroidJavaObject activity)
	{
		return null;
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x3508A8C", Offset = "0x3508A8C", VA = "0x3508A8C")]
	public static void PutPostInstallIntentStringExtra(AndroidJavaObject postInstallIntent, string extraKey, string extraValue)
	{
	}

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0x3508C6C", Offset = "0x3508C6C", VA = "0x3508C6C")]
	public static string GetPostInstallIntentStringExtra(string extraKey)
	{
		return null;
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x3508FF8", Offset = "0x3508FF8", VA = "0x3508FF8")]
	private static AndroidJavaObject CreateMarketDetailsUri(string referrer)
	{
		return null;
	}

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0x3509B18", Offset = "0x3509B18", VA = "0x3509B18")]
	private static bool IsLegacyPlayStore(AndroidJavaObject context, AndroidJavaObject installIntent)
	{
		return default(bool);
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x3509EB0", Offset = "0x3509EB0", VA = "0x3509EB0")]
	private static void ShowLegacyInstallPrompt(AndroidJavaObject activity, int requestCode, AndroidJavaObject uri)
	{
	}
}
