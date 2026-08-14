using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GarenaMSDKUnity.GMSDK;

[Token(Token = "0x2000014")]
internal static class GMSDKUtility
{
	[Token(Token = "0x40000E8")]
	private const string PASSWORD_CHARACTERS = "0123456789abcdefghijklmnopqrstuvwxyz!@#$%^&*()";

	[Token(Token = "0x40000E9")]
	[FieldOffset(Offset = "0x0")]
	private static Func<byte, string> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x3468214", Offset = "0x3468214", VA = "0x3468214")]
	public static string GeneratePassword(int length = 64)
	{
		return null;
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x34684A8", Offset = "0x34684A8", VA = "0x34684A8")]
	public static string Digest_SHA256(string template)
	{
		return null;
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x34687B4", Offset = "0x34687B4", VA = "0x34687B4")]
	public static string MakeUrlParameters(Dictionary<string, string> data)
	{
		return null;
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x3468B00", Offset = "0x3468B00", VA = "0x3468B00")]
	public static string MakeJsonParameters(Dictionary<string, string> data)
	{
		return null;
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x3468E18", Offset = "0x3468E18", VA = "0x3468E18")]
	private static string _003CDigest_SHA256_003Em__0(byte item)
	{
		return null;
	}
}
