using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20002C3")]
public static class DeviceIdentifier
{
	[Token(Token = "0x40032EE")]
	private const string DEVICE_IDENTIFIER_FORMAT = "{0}|{1}";

	[Token(Token = "0x40032EF")]
	private const string PLAYER_PREFS_KEY_ANDROID_DEVICE_IDENTIFIER = "AND_DEV_ID_0";

	[Token(Token = "0x40032F0")]
	private const string PROVIDER_GOOGLE = "Google";

	[Token(Token = "0x40032F1")]
	[FieldOffset(Offset = "0x0")]
	private static Action<PlatformUtility_Android.GetAdvertisingIdResult> _003C_003Ef__mg_0024cache0;

	[Token(Token = "0x6000D5B")]
	[Address(RVA = "0x1C91CC8", Offset = "0x1C91CC8", VA = "0x1C91CC8")]
	public static void Init()
	{
	}

	[Token(Token = "0x6000D5C")]
	[Address(RVA = "0x1C9219C", Offset = "0x1C9219C", VA = "0x1C9219C")]
	public static string Read()
	{
		return null;
	}

	[Token(Token = "0x6000D5D")]
	[Address(RVA = "0x1C91D1C", Offset = "0x1C91D1C", VA = "0x1C91D1C")]
	private static void InitAndroid()
	{
	}

	[Token(Token = "0x6000D5E")]
	[Address(RVA = "0x1C924D0", Offset = "0x1C924D0", VA = "0x1C924D0")]
	private static void OnGetAdvertisingId(PlatformUtility_Android.GetAdvertisingIdResult result)
	{
	}

	[Token(Token = "0x6000D5F")]
	[Address(RVA = "0x1C9236C", Offset = "0x1C9236C", VA = "0x1C9236C")]
	private static void WriteAndroidDeviceIdentifier(string deviceIdentifier)
	{
	}

	[Token(Token = "0x6000D60")]
	[Address(RVA = "0x1C921F0", Offset = "0x1C921F0", VA = "0x1C921F0")]
	private static string ReadAndroidDeviceIdentifier()
	{
		return null;
	}
}
