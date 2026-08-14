using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002DC8")]
public class DateFormatByDiffRegionDataManager : SingletonModule<DateFormatByDiffRegionDataManager>
{
	[Token(Token = "0x2002DC9")]
	public enum DateFormataType
	{
		[Token(Token = "0x4011958")]
		YMD,
		[Token(Token = "0x4011959")]
		MD,
		[Token(Token = "0x401195A")]
		YMDHMS,
		[Token(Token = "0x401195B")]
		MDHMS
	}

	[Token(Token = "0x4011953")]
	[FieldOffset(Offset = "0xC")]
	private string m_DateFormatWithYear;

	[Token(Token = "0x4011954")]
	[FieldOffset(Offset = "0x10")]
	private string m_DateFormatNoYear;

	[Token(Token = "0x4011955")]
	[FieldOffset(Offset = "0x14")]
	private bool m_HasReverse;

	[Token(Token = "0x4011956")]
	private const string DATE_FORMAT_HMS = " HH:mm:ss";

	[Token(Token = "0x170013ED")]
	public string LocalDateFormatWithYear
	{
		[Token(Token = "0x6013345")]
		[Address(RVA = "0x1C891CC", Offset = "0x1C891CC", VA = "0x1C891CC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013EE")]
	public string LocalDateFormatNoYear
	{
		[Token(Token = "0x6013346")]
		[Address(RVA = "0x1C89224", Offset = "0x1C89224", VA = "0x1C89224")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013EF")]
	public bool ReserveMonthAndDay
	{
		[Token(Token = "0x6013347")]
		[Address(RVA = "0x1C8927C", Offset = "0x1C8927C", VA = "0x1C8927C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6013344")]
	[Address(RVA = "0x1C890E8", Offset = "0x1C890E8", VA = "0x1C890E8")]
	public DateFormatByDiffRegionDataManager()
	{
	}

	[Token(Token = "0x6013348")]
	[Address(RVA = "0x1C892D4", Offset = "0x1C892D4", VA = "0x1C892D4", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6013349")]
	[Address(RVA = "0x1C89978", Offset = "0x1C89978", VA = "0x1C89978")]
	public string GetDateStringByTimeSpan(double timeSpan, DateFormataType dateType)
	{
		return null;
	}

	[Token(Token = "0x601334A")]
	[Address(RVA = "0x1C89C50", Offset = "0x1C89C50", VA = "0x1C89C50")]
	public string GetDateStringByOriginalStr(string originalStr, DateFormataType dateType)
	{
		return null;
	}

	[Token(Token = "0x601334B")]
	[Address(RVA = "0x1C89AC8", Offset = "0x1C89AC8", VA = "0x1C89AC8")]
	public string GetDateFormat(DateFormataType dateType)
	{
		return null;
	}

	[Token(Token = "0x601334C")]
	[Address(RVA = "0x1C89D78", Offset = "0x1C89D78", VA = "0x1C89D78", Slot = "7")]
	protected override void OnCleanup()
	{
	}
}
