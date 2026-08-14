using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace GCommon;

[Token(Token = "0x2003F03")]
public static class LocLangConvert
{
	[Token(Token = "0x401A98C")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<string, LocLang> langsDic;

	[Token(Token = "0x401A98D")]
	[FieldOffset(Offset = "0x4")]
	private static Dictionary<string, int> _003C_003Ef__switch_0024map17;

	[Token(Token = "0x6019A80")]
	[Address(RVA = "0x32AEA94", Offset = "0x32AEA94", VA = "0x32AEA94")]
	public static string GetAbbr(LocLang lang)
	{
		return null;
	}

	[Token(Token = "0x6019A81")]
	[Address(RVA = "0x32BE414", Offset = "0x32BE414", VA = "0x32BE414")]
	public static string GetAbbrForVoice(LocLang lang)
	{
		return null;
	}

	[Token(Token = "0x6019A82")]
	[Address(RVA = "0x32BE490", Offset = "0x32BE490", VA = "0x32BE490")]
	public static LocLang GetLocLang(string abbr)
	{
		return default(LocLang);
	}

	[Token(Token = "0x6019A83")]
	[Address(RVA = "0x32BEC80", Offset = "0x32BEC80", VA = "0x32BEC80")]
	public static LocLang GetLocLang(SystemLanguage systemLan)
	{
		return default(LocLang);
	}

	[Token(Token = "0x6019A84")]
	[Address(RVA = "0x32BEF10", Offset = "0x32BEF10", VA = "0x32BEF10")]
	private static LocLang GetAdvanceLang()
	{
		return default(LocLang);
	}

	[Token(Token = "0x6019A85")]
	[Address(RVA = "0x32BF404", Offset = "0x32BF404", VA = "0x32BF404")]
	public static LocLang GetLang(ESocial.Language loc)
	{
		return default(LocLang);
	}

	[Token(Token = "0x6019A86")]
	[Address(RVA = "0x32BF424", Offset = "0x32BF424", VA = "0x32BF424")]
	public static string GetLocLangName(LocLang loc)
	{
		return null;
	}

	[Token(Token = "0x6019A87")]
	[Address(RVA = "0x32BFF8C", Offset = "0x32BFF8C", VA = "0x32BFF8C")]
	public static string GetLocLangName(ESocial.Language loc)
	{
		return null;
	}

	[Token(Token = "0x6019A88")]
	[Address(RVA = "0x32C00AC", Offset = "0x32C00AC", VA = "0x32C00AC")]
	public static string GetLocLangNamePic(LocLang loc)
	{
		return null;
	}

	[Token(Token = "0x6019A89")]
	[Address(RVA = "0x32C015C", Offset = "0x32C015C", VA = "0x32C015C")]
	public static string GetLocLangNamePic(ESocial.Language loc)
	{
		return null;
	}

	[Token(Token = "0x6019A8A")]
	[Address(RVA = "0x32C01E0", Offset = "0x32C01E0", VA = "0x32C01E0")]
	public static List<int> GetLanguageList()
	{
		return null;
	}

	[Token(Token = "0x6019A8B")]
	[Address(RVA = "0x32C05BC", Offset = "0x32C05BC", VA = "0x32C05BC")]
	public static List<uint> GetServerLanguageList()
	{
		return null;
	}
}
