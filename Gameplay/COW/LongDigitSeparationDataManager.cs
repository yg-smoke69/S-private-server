using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200018F")]
public class LongDigitSeparationDataManager : SingletonModule<LongDigitSeparationDataManager>
{
	[Token(Token = "0x2000190")]
	private sealed class _003CGetLongDigitSeparationDataByLanguage_003Ec__AnonStorey0
	{
		[Token(Token = "0x40009A9")]
		[FieldOffset(Offset = "0x8")]
		internal string language;

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x152E454", Offset = "0x152E454", VA = "0x152E454")]
		public _003CGetLongDigitSeparationDataByLanguage_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x152E504", Offset = "0x152E504", VA = "0x152E504")]
		internal bool _003C_003Em__0(LongDigitSeparationData x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40009A4")]
	public const string DEFAULT_LANGUAGE_SPLIT = "default";

	[Token(Token = "0x40009A5")]
	[FieldOffset(Offset = "0xC")]
	public string CurrentCultureCode;

	[Token(Token = "0x40009A6")]
	[FieldOffset(Offset = "0x10")]
	private List<FormatCultureInfoData> m_FormateCultureInfoData;

	[Token(Token = "0x40009A7")]
	[FieldOffset(Offset = "0x14")]
	public List<LongDigitSeparationData> m_LongDigitSeparationDataList;

	[Token(Token = "0x40009A8")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<LongDigitSeparationData> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x60008D6")]
	[Address(RVA = "0x152DB94", Offset = "0x152DB94", VA = "0x152DB94")]
	public LongDigitSeparationDataManager()
	{
	}

	[Token(Token = "0x60008D7")]
	[Address(RVA = "0x152DCA0", Offset = "0x152DCA0", VA = "0x152DCA0", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x60008D8")]
	[Address(RVA = "0x152E108", Offset = "0x152E108", VA = "0x152E108", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x60008D9")]
	[Address(RVA = "0x152E168", Offset = "0x152E168", VA = "0x152E168")]
	public LongDigitSeparationData GetLongDigitSeparationDataByLanguage(string language)
	{
		return null;
	}

	[Token(Token = "0x60008DA")]
	[Address(RVA = "0x152E45C", Offset = "0x152E45C", VA = "0x152E45C")]
	private static bool _003CGetLongDigitSeparationDataByLanguage_003Em__0(LongDigitSeparationData x)
	{
		return default(bool);
	}
}
