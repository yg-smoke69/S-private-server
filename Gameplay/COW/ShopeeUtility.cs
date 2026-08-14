using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200333E")]
public static class ShopeeUtility
{
	[Token(Token = "0x4013870")]
	private const string ANDROID_ACTION = "com.freefire.broadcast.ID";

	[Token(Token = "0x4013871")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string[] ANDROID_APP_NAMES;

	[Token(Token = "0x4013872")]
	private const string ANDROID_BROADCAST_INTENT_EXTRA_KEY_DEVICE_FINGERPRINT = "device_fingerprint";

	[Token(Token = "0x4013873")]
	private const string ANDROID_BROADCAST_INTENT_EXTRA_KEY_GOP_ID = "gop_id";

	[Token(Token = "0x4013874")]
	private const string ANDROID_BROADCAST_INTENT_EXTRA_KEY_GOP_ENV = "gop_env";

	[Token(Token = "0x4013875")]
	private const string ANDROID_AES_PASSWORD = "FreeFire_Shopee_20190813";

	[Token(Token = "0x4013876")]
	[FieldOffset(Offset = "0x4")]
	private static readonly AES.AESOption AES_Option_DeviceIdentifier;

	[Token(Token = "0x4013877")]
	[FieldOffset(Offset = "0x8")]
	private static readonly AES.AESOption AES_Option_OpenID;

	[Token(Token = "0x6015C52")]
	[Address(RVA = "0x20E544C", Offset = "0x20E544C", VA = "0x20E544C")]
	public static void AfterAppLaunch()
	{
	}

	[Token(Token = "0x6015C53")]
	[Address(RVA = "0x20E5614", Offset = "0x20E5614", VA = "0x20E5614")]
	private static void AfterAppLaunch_Android()
	{
	}

	[Token(Token = "0x6015C54")]
	[Address(RVA = "0x20E5ABC", Offset = "0x20E5ABC", VA = "0x20E5ABC")]
	public static void AfterLoginServer()
	{
	}

	[Token(Token = "0x6015C55")]
	[Address(RVA = "0x20E5CE4", Offset = "0x20E5CE4", VA = "0x20E5CE4")]
	private static void AfterLoginServer_Android_Garena()
	{
	}
}
