using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20032F7")]
public static class OpenUrl
{
	[Token(Token = "0x20032F8")]
	private delegate string ReplaceDelegate(string url);

	[Token(Token = "0x40135F6")]
	private const string PLACEHOLDER_FORMAT = "<{0}>";

	[Token(Token = "0x40135F7")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Dictionary<string, ReplaceDelegate> Replacements;

	[Token(Token = "0x40135F8")]
	[FieldOffset(Offset = "0x4")]
	private static readonly AES.AESOption aesOption;

	[Token(Token = "0x60157C0")]
	[Address(RVA = "0x28BCC08", Offset = "0x28BCC08", VA = "0x28BCC08")]
	public static string GetEncryptedToken()
	{
		return null;
	}

	[Token(Token = "0x60157C1")]
	[Address(RVA = "0x28BCDE0", Offset = "0x28BCDE0", VA = "0x28BCDE0")]
	public static string Get(string key)
	{
		return null;
	}

	[Token(Token = "0x60157C2")]
	[Address(RVA = "0x28BD004", Offset = "0x28BD004", VA = "0x28BD004")]
	public static void Open(string url)
	{
	}

	[Token(Token = "0x60157C3")]
	[Address(RVA = "0x28BD0D4", Offset = "0x28BD0D4", VA = "0x28BD0D4")]
	public static string Modify(string url)
	{
		return null;
	}

	[Token(Token = "0x60157C5")]
	[Address(RVA = "0x28BDDFC", Offset = "0x28BDDFC", VA = "0x28BDDFC")]
	private static string _003CReplacements_003Em__0(string url)
	{
		return null;
	}

	[Token(Token = "0x60157C6")]
	[Address(RVA = "0x28BDE98", Offset = "0x28BDE98", VA = "0x28BDE98")]
	private static string _003CReplacements_003Em__1(string url)
	{
		return null;
	}

	[Token(Token = "0x60157C7")]
	[Address(RVA = "0x28BE02C", Offset = "0x28BE02C", VA = "0x28BE02C")]
	private static string _003CReplacements_003Em__2(string url)
	{
		return null;
	}

	[Token(Token = "0x60157C8")]
	[Address(RVA = "0x28BE0B8", Offset = "0x28BE0B8", VA = "0x28BE0B8")]
	private static string _003CReplacements_003Em__3(string url)
	{
		return null;
	}

	[Token(Token = "0x60157C9")]
	[Address(RVA = "0x28BE170", Offset = "0x28BE170", VA = "0x28BE170")]
	private static string _003CReplacements_003Em__4(string url)
	{
		return null;
	}

	[Token(Token = "0x60157CA")]
	[Address(RVA = "0x28BE210", Offset = "0x28BE210", VA = "0x28BE210")]
	private static string _003CReplacements_003Em__5(string url)
	{
		return null;
	}

	[Token(Token = "0x60157CB")]
	[Address(RVA = "0x28BE28C", Offset = "0x28BE28C", VA = "0x28BE28C")]
	private static string _003CReplacements_003Em__6(string url)
	{
		return null;
	}
}
