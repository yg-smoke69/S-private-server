using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TsiU;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2003F05")]
public class LocManager : TSingleton<LocManager>
{
	[Token(Token = "0x2003F06")]
	public enum LocUseCase : byte
	{
		[Token(Token = "0x401A9A6")]
		Both,
		[Token(Token = "0x401A9A7")]
		LobbyOnly,
		[Token(Token = "0x401A9A8")]
		IngameOnly,
		[Token(Token = "0x401A9A9")]
		HotFix
	}

	[Token(Token = "0x2003F07")]
	public enum ImageLocalizeType
	{
		[Token(Token = "0x401A9AB")]
		Sprite,
		[Token(Token = "0x401A9AC")]
		Atlas
	}

	[Token(Token = "0x2003F08")]
	public class LocOptions
	{
		[Token(Token = "0x401A9AD")]
		[FieldOffset(Offset = "0x8")]
		public bool NoArabic;

		[Token(Token = "0x6019AB3")]
		[Address(RVA = "0x29613D8", Offset = "0x29613D8", VA = "0x29613D8")]
		public LocOptions()
		{
		}
	}

	[Token(Token = "0x401A991")]
	[FieldOffset(Offset = "0x8")]
	private bool m_Inited;

	[Token(Token = "0x401A992")]
	private const int CapacityLocTextHash = 52361;

	[Token(Token = "0x401A993")]
	private const int CapacityLocTextName = 1000;

	[Token(Token = "0x401A994")]
	[FieldOffset(Offset = "0xC")]
	private LocGlobalComponent m_LocGlobal;

	[Token(Token = "0x401A995")]
	[FieldOffset(Offset = "0x10")]
	private LocLang m_CurrentLang;

	[Token(Token = "0x401A996")]
	[FieldOffset(Offset = "0x14")]
	private string m_CurrentLangAbbr;

	[Token(Token = "0x401A997")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<int, LocGlobalComponent.Language> m_Fonts;

	[Token(Token = "0x401A998")]
	public const ushort INVALID_TRANS_INDEX = ushort.MaxValue;

	[Token(Token = "0x401A999")]
	private const uint LocTextIdxMask = 65535u;

	[Token(Token = "0x401A99A")]
	private const uint LocTextFlagCleared = 2147483648u;

	[Token(Token = "0x401A99B")]
	private const int LocTextFlagsShift = 24;

	[Token(Token = "0x401A99C")]
	private const uint LocTextFlagsMask = 4278190080u;

	[Token(Token = "0x401A99D")]
	[FieldOffset(Offset = "0x1C")]
	private Dictionary<int, uint> m_LocTextHash;

	[Token(Token = "0x401A99E")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<string, uint> m_LocTextName;

	[Token(Token = "0x401A99F")]
	[FieldOffset(Offset = "0x24")]
	private List<string> m_LocTextTranslations;

	[Token(Token = "0x401A9A0")]
	[FieldOffset(Offset = "0x28")]
	public bool FlagFixArabicNameInOtherLanguage;

	[Token(Token = "0x401A9A1")]
	[FieldOffset(Offset = "0x29")]
	public bool HasLobbyOnlyStrings;

	[Token(Token = "0x401A9A2")]
	[FieldOffset(Offset = "0x2C")]
	private string[] m_xmlStrings;

	[Token(Token = "0x401A9A3")]
	[FieldOffset(Offset = "0x30")]
	public readonly LocOptions NoArabicSupport;

	[Token(Token = "0x401A9A4")]
	[FieldOffset(Offset = "0x0")]
	private static Func<UIInput, string> _003C_003Ef__mg_0024cache0;

	[Token(Token = "0x17001C16")]
	public LocLang CurrentLanguage
	{
		[Token(Token = "0x6019A9A")]
		[Address(RVA = "0x32BDFF8", Offset = "0x32BDFF8", VA = "0x32BDFF8")]
		get
		{
			return default(LocLang);
		}
	}

	[Token(Token = "0x6019A8D")]
	[Address(RVA = "0x32C0CF8", Offset = "0x32C0CF8", VA = "0x32C0CF8")]
	public LocManager()
	{
	}

	[Token(Token = "0x6019A8E")]
	[Address(RVA = "0x32C134C", Offset = "0x32C134C", VA = "0x32C134C")]
	public string Fix(string text, bool all = false)
	{
		return null;
	}

	[Token(Token = "0x6019A8F")]
	[Address(RVA = "0x32C138C", Offset = "0x32C138C", VA = "0x32C138C")]
	public string FixArabicInOthersLang(string text, bool needReverse = true)
	{
		return null;
	}

	[Token(Token = "0x6019A90")]
	[Address(RVA = "0x32C13F4", Offset = "0x32C13F4", VA = "0x32C13F4")]
	public string FixArabicCustomInput(string text, bool noRegion)
	{
		return null;
	}

	[Token(Token = "0x6019A91")]
	[Address(RVA = "0x32C13B8", Offset = "0x32C13B8", VA = "0x32C13B8")]
	public static string FixArabicWhenIsArabic(string text, bool needReverse)
	{
		return null;
	}

	[Token(Token = "0x6019A92")]
	[Address(RVA = "0x32C137C", Offset = "0x32C137C", VA = "0x32C137C")]
	private static string FixArabic(string text, bool needReverse = false)
	{
		return null;
	}

	[Token(Token = "0x6019A93")]
	[Address(RVA = "0x32C1464", Offset = "0x32C1464", VA = "0x32C1464")]
	private static string GetUnfixedLocText(UIInput input)
	{
		return null;
	}

	[Token(Token = "0x6019A94")]
	[Address(RVA = "0x32C16BC", Offset = "0x32C16BC", VA = "0x32C16BC")]
	public void Init(LocLang currentLang)
	{
	}

	[Token(Token = "0x6019A95")]
	[Address(RVA = "0x32C1A4C", Offset = "0x32C1A4C", VA = "0x32C1A4C")]
	public void RefreshCurrLang(LocLang currentLang)
	{
	}

	[Token(Token = "0x6019A96")]
	[Address(RVA = "0x32C1AE0", Offset = "0x32C1AE0", VA = "0x32C1AE0")]
	public void RefreshFont(LocLang currentLang)
	{
	}

	[Token(Token = "0x6019A97")]
	[Address(RVA = "0x32C1D78", Offset = "0x32C1D78", VA = "0x32C1D78")]
	public void AddTranslation(string translation, bool use_new = true, bool is_hotfix = false)
	{
	}

	[Token(Token = "0x6019A98")]
	[Address(RVA = "0x32C23E8", Offset = "0x32C23E8", VA = "0x32C23E8")]
	public void AddCurrentTranslation(string idStr, string transStr, bool needOverWrite = true)
	{
	}

	[Token(Token = "0x6019A99")]
	[Address(RVA = "0x32C31D4", Offset = "0x32C31D4", VA = "0x32C31D4")]
	public void AfterTranslationsAdded()
	{
	}

	[Token(Token = "0x6019A9B")]
	[Address(RVA = "0x32C3588", Offset = "0x32C3588", VA = "0x32C3588")]
	private bool TryGetTranslationFlagIndex(string stringID, out uint flagIdx)
	{
		return default(bool);
	}

	[Token(Token = "0x6019A9C")]
	[Address(RVA = "0x32C3664", Offset = "0x32C3664", VA = "0x32C3664")]
	public bool GetRawTranslation(string stringID, out string trans)
	{
		return default(bool);
	}

	[Token(Token = "0x6019A9D")]
	[Address(RVA = "0x32C3744", Offset = "0x32C3744", VA = "0x32C3744")]
	private string GetTranslationByFlagIndex(uint flagIdx)
	{
		return null;
	}

	[Token(Token = "0x6019A9E")]
	[Address(RVA = "0x32C374C", Offset = "0x32C374C", VA = "0x32C374C")]
	public string GetTranslationByIndex(ushort idx)
	{
		return null;
	}

	[Token(Token = "0x6019A9F")]
	[Address(RVA = "0x32C3890", Offset = "0x32C3890", VA = "0x32C3890")]
	public ushort GetTranslationIndex(string stringID)
	{
		return default(ushort);
	}

	[Token(Token = "0x6019AA0")]
	[Address(RVA = "0x32C38C4", Offset = "0x32C38C4", VA = "0x32C38C4")]
	public void DoLoc(UILabel label, string stringID, object[] param)
	{
	}

	[Token(Token = "0x6019AA1")]
	[Address(RVA = "0x32C3904", Offset = "0x32C3904", VA = "0x32C3904")]
	public void DoLocWithOptions(UILabel label, string stringID, LocOptions locOptions, object[] param)
	{
	}

	[Token(Token = "0x6019AA2")]
	[Address(RVA = "0x32BDF8C", Offset = "0x32BDF8C", VA = "0x32BDF8C")]
	public void DoLocWithOptions(UILabel label, string stringID, bool noArabic, object[] param)
	{
	}

	[Token(Token = "0x6019AA3")]
	[Address(RVA = "0x32C39B0", Offset = "0x32C39B0", VA = "0x32C39B0")]
	public string DoLoc(string stringID, Dictionary<string, string> dic, object[] param)
	{
		return null;
	}

	[Token(Token = "0x6019AA4")]
	[Address(RVA = "0x32C3B40", Offset = "0x32C3B40", VA = "0x32C3B40")]
	private string _DoLoc(string stringID, out bool needFix, object[] param)
	{
		return null;
	}

	[Token(Token = "0x6019AA5")]
	[Address(RVA = "0x32C3CB8", Offset = "0x32C3CB8", VA = "0x32C3CB8")]
	private bool _HasLoc(string stringID)
	{
		return default(bool);
	}

	[Token(Token = "0x6019AA6")]
	[Address(RVA = "0x32BFF30", Offset = "0x32BFF30", VA = "0x32BFF30")]
	public string DoLoc(string stringID, object[] param)
	{
		return null;
	}

	[Token(Token = "0x6019AA7")]
	[Address(RVA = "0x32C3D88", Offset = "0x32C3D88", VA = "0x32C3D88")]
	public string LocOrFix(string stringID, object[] param)
	{
		return null;
	}

	[Token(Token = "0x6019AA8")]
	[Address(RVA = "0x32C3968", Offset = "0x32C3968", VA = "0x32C3968")]
	public string DoLocWithOptions(string stringID, LocOptions options, object[] param)
	{
		return null;
	}

	[Token(Token = "0x6019AA9")]
	[Address(RVA = "0x32C1694", Offset = "0x32C1694", VA = "0x32C1694")]
	public string DoLocOriginal(string stringID, object[] param)
	{
		return null;
	}

	[Token(Token = "0x6019AAA")]
	[Address(RVA = "0x32C1D90", Offset = "0x32C1D90", VA = "0x32C1D90")]
	private void ParseTranslation(string translation, bool use_new, bool is_hotfix = false)
	{
	}

	[Token(Token = "0x6019AAB")]
	[Address(RVA = "0x32C2790", Offset = "0x32C2790", VA = "0x32C2790")]
	private void ParseTranslation(string idStr, string transStr, bool needOverWrite = true)
	{
	}

	[Token(Token = "0x6019AAC")]
	[Address(RVA = "0x32C400C", Offset = "0x32C400C", VA = "0x32C400C")]
	private void AddTranslation(string id, string trans, LocUseCase useCase, bool needOverWrite, bool nameHashCollided)
	{
	}

	[Token(Token = "0x6019AAD")]
	[Address(RVA = "0x32C407C", Offset = "0x32C407C", VA = "0x32C407C")]
	private void AddTranslation(int hashKey, string trans, LocUseCase useCase, bool needOverWrite)
	{
	}

	[Token(Token = "0x6019AAE")]
	[Address(RVA = "0x32C3DD8", Offset = "0x32C3DD8", VA = "0x32C3DD8")]
	private void AddTranslation(string id, string trans, LocUseCase useCase, bool needOverWrite)
	{
	}

	[Token(Token = "0x6019AAF")]
	[Address(RVA = "0x32C4274", Offset = "0x32C4274", VA = "0x32C4274")]
	public void UnloadUselessData()
	{
	}

	[Token(Token = "0x6019AB0")]
	[Address(RVA = "0x32BDE14", Offset = "0x32BDE14", VA = "0x32BDE14")]
	public bool IsRTLLanguage()
	{
		return default(bool);
	}

	[Token(Token = "0x6019AB1")]
	[Address(RVA = "0x32BDE2C", Offset = "0x32BDE2C", VA = "0x32BDE2C")]
	public Font GetFont(FontWeight fontWeight = FontWeight.Normal)
	{
		return null;
	}

	[Token(Token = "0x6019AB2")]
	[Address(RVA = "0x32C50F8", Offset = "0x32C50F8", VA = "0x32C50F8")]
	public Font GetDefaultFont(FontWeight fontWeight = FontWeight.Normal)
	{
		return null;
	}
}
