using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GooglePlayInstant;

[Token(Token = "0x200007C")]
public static class CookieApi
{
	[Token(Token = "0x200007D")]
	public class CookieApiException : Exception
	{
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x35085E4", Offset = "0x35085E4", VA = "0x35085E4")]
		public CookieApiException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x35085DC", Offset = "0x35085DC", VA = "0x35085DC")]
		public CookieApiException(string message)
		{
		}
	}

	[Token(Token = "0x40002B1")]
	private const string Authority = "com.google.android.gms.instantapps.provider.api";

	[Token(Token = "0x40002B2")]
	private const string ContentAuthority = "content://com.google.android.gms.instantapps.provider.api/";

	[Token(Token = "0x40002B3")]
	private const string KeyCookie = "cookie";

	[Token(Token = "0x40002B4")]
	private const string KeyResult = "result";

	[Token(Token = "0x40002B5")]
	private const string KeyUid = "uid";

	[Token(Token = "0x40002B6")]
	private const string MethodGetInstantAppCookie = "getInstantAppCookie";

	[Token(Token = "0x40002B7")]
	private const string MethodGetInstantAppCookieMaxSize = "getInstantAppCookieMaxSize";

	[Token(Token = "0x40002B8")]
	private const string MethodSetInstantAppCookie = "setInstantAppCookie";

	[Token(Token = "0x40002B9")]
	[FieldOffset(Offset = "0x0")]
	private static bool _verifiedContentProvider;

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0x3505E74", Offset = "0x3505E74", VA = "0x3505E74")]
	public static int GetInstantAppCookieMaxSizeBytes()
	{
		return default(int);
	}

	[Token(Token = "0x60002DF")]
	[Address(RVA = "0x3506D14", Offset = "0x3506D14", VA = "0x3506D14")]
	public static string GetInstantAppCookie()
	{
		return null;
	}

	[Token(Token = "0x60002E0")]
	[Address(RVA = "0x3506DD4", Offset = "0x3506DD4", VA = "0x3506DD4")]
	public static byte[] GetInstantAppCookieBytes()
	{
		return null;
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0x3507480", Offset = "0x3507480", VA = "0x3507480")]
	public static bool SetInstantAppCookie(string cookie)
	{
		return default(bool);
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0x3507540", Offset = "0x3507540", VA = "0x3507540")]
	public static bool SetInstantAppCookieBytes(byte[] cookie)
	{
		return default(bool);
	}

	[Token(Token = "0x60002E3")]
	[Address(RVA = "0x3507BA8", Offset = "0x3507BA8", VA = "0x3507BA8")]
	private static void VerifyContentProvider()
	{
	}

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0x3506204", Offset = "0x3506204", VA = "0x3506204")]
	private static AndroidJavaObject CallMethod(string methodName, AndroidJavaObject extrasBundle)
	{
		return null;
	}

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0x35072B8", Offset = "0x35072B8", VA = "0x35072B8")]
	private static int ProcessGetMyUid()
	{
		return default(int);
	}
}
