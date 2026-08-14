using System;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2003F39")]
public static class DateTimeUtil
{
	[Token(Token = "0x401AA56")]
	[FieldOffset(Offset = "0x0")]
	public static readonly int SECONDS_DAILY;

	[Token(Token = "0x401AA57")]
	[FieldOffset(Offset = "0x4")]
	public static readonly int SECONDS_HOUR;

	[Token(Token = "0x401AA58")]
	[FieldOffset(Offset = "0x8")]
	public static readonly int SECONDS_MINUTE;

	[Token(Token = "0x401AA59")]
	[FieldOffset(Offset = "0xC")]
	public static readonly int MICROSECONDS_PER_SECOND;

	[Token(Token = "0x401AA5A")]
	[FieldOffset(Offset = "0x10")]
	public static readonly int MILLISECONDS_PER_SECOND;

	[Token(Token = "0x401AA5B")]
	private const string TIME_FORMAT_MD = "{0:D2}.{1:D2}";

	[Token(Token = "0x401AA5C")]
	private const string TIME_FORMAT_YMD = "{0:D2}.{1:D2}.{2:D2}";

	[Token(Token = "0x401AA5D")]
	private const string TIME_FORMAT_HMS = "{0:D2}:{1:D2}:{2:D2}";

	[Token(Token = "0x401AA5E")]
	private const string TIME_FORMAT_HM = "{0:D2}:{1:D2}";

	[Token(Token = "0x401AA5F")]
	private const string DAY_STRING = "TXT_IVENTORY_OUTEXPIRE_TIME_3";

	[Token(Token = "0x401AA60")]
	private const string MINUTES_AGO_STRING = "TXT_OB5_TIME_MINUTE";

	[Token(Token = "0x401AA61")]
	private const string HOURS_AGO_STRING = "TXT_OB5_TIME_HOUR";

	[Token(Token = "0x401AA62")]
	private const string DAYS_AGO_STRING = "TXT_OB5_TIME_WEEK";

	[Token(Token = "0x401AA63")]
	private const string ONE_WEEKS_AGO_STRING = "TXT_OB5_TIME_LONGTIME";

	[Token(Token = "0x401AA64")]
	private const string TODAY_STRING = "TXT_CHAT_TIME_TODAY";

	[Token(Token = "0x401AA65")]
	private const string YESTERDAY_STRING = "TXT_CHAT_TIME_YESTERDAY";

	[Token(Token = "0x401AA66")]
	private const string BEFORE_STRING = "TXT_CHAT_TIME_BEFORE";

	[Token(Token = "0x401AA67")]
	[FieldOffset(Offset = "0x18")]
	private static DateTime utcStartDataTime;

	[Token(Token = "0x401AA68")]
	[FieldOffset(Offset = "0x28")]
	private static ulong serverTimeDelta;

	[Token(Token = "0x17001C27")]
	public static DateTime UTCStartDateTime
	{
		[Token(Token = "0x6019BF7")]
		[Address(RVA = "0x308A6D4", Offset = "0x308A6D4", VA = "0x308A6D4")]
		get
		{
			return default(DateTime);
		}
	}

	[Token(Token = "0x6019BF8")]
	[Address(RVA = "0x308A8C0", Offset = "0x308A8C0", VA = "0x308A8C0")]
	public static ulong GetCurrentLocalTimeStampSeconds()
	{
		return default(ulong);
	}

	[Token(Token = "0x6019BF9")]
	[Address(RVA = "0x308AA90", Offset = "0x308AA90", VA = "0x308AA90")]
	public static double GetCurrentLocalTimeStampMilliseconds()
	{
		return default(double);
	}

	[Token(Token = "0x6019BFA")]
	[Address(RVA = "0x308AC50", Offset = "0x308AC50", VA = "0x308AC50")]
	public static ulong GetCurrentTimeStamp()
	{
		return default(ulong);
	}

	[Token(Token = "0x6019BFB")]
	[Address(RVA = "0x308ACE8", Offset = "0x308ACE8", VA = "0x308ACE8")]
	public static DateTime GetCurrentDateTime()
	{
		return default(DateTime);
	}

	[Token(Token = "0x6019BFC")]
	[Address(RVA = "0x308ADC0", Offset = "0x308ADC0", VA = "0x308ADC0")]
	public static DateTime GetDateTime(ulong timestamp)
	{
		return default(DateTime);
	}

	[Token(Token = "0x6019BFD")]
	[Address(RVA = "0x308AE94", Offset = "0x308AE94", VA = "0x308AE94")]
	public static DateTime GetCurrentChinaStandardDateTime()
	{
		return default(DateTime);
	}

	[Token(Token = "0x6019BFE")]
	[Address(RVA = "0x308B020", Offset = "0x308B020", VA = "0x308B020")]
	public static DateTime GetRegionServerDateTime(long region_timezone_offset_secs)
	{
		return default(DateTime);
	}

	[Token(Token = "0x6019BFF")]
	[Address(RVA = "0x308B124", Offset = "0x308B124", VA = "0x308B124")]
	public static ulong GetRegionServerDateTimeStamp(long region_timezone_offset_secs, DateTime dateTime)
	{
		return default(ulong);
	}

	[Token(Token = "0x6019C00")]
	[Address(RVA = "0x308B1F4", Offset = "0x308B1F4", VA = "0x308B1F4")]
	public static void SetServerTimeDelta(ulong serverTime)
	{
	}

	[Token(Token = "0x6019C01")]
	[Address(RVA = "0x308A984", Offset = "0x308A984", VA = "0x308A984")]
	public static int ConvertDateTimeToTimeStamp(DateTime dateTime)
	{
		return default(int);
	}

	[Token(Token = "0x6019C02")]
	[Address(RVA = "0x308AB50", Offset = "0x308AB50", VA = "0x308AB50")]
	public static double ConvertDataTimeToTimsStampMilliseconds(DateTime dateTime)
	{
		return default(double);
	}

	[Token(Token = "0x6019C03")]
	[Address(RVA = "0x308B294", Offset = "0x308B294", VA = "0x308B294")]
	public static DateTime CovertUtcDateTimeToCurrentTimeZoneDateTime(DateTime utcTime)
	{
		return default(DateTime);
	}

	[Token(Token = "0x6019C04")]
	[Address(RVA = "0x308B2C4", Offset = "0x308B2C4", VA = "0x308B2C4")]
	public static string ConvertDateTimeToYMD(DateTime time)
	{
		return null;
	}

	[Token(Token = "0x6019C05")]
	[Address(RVA = "0x308B3F0", Offset = "0x308B3F0", VA = "0x308B3F0")]
	public static string ConvertDateTimeToYM(DateTime time)
	{
		return null;
	}

	[Token(Token = "0x6019C06")]
	[Address(RVA = "0x308B4F0", Offset = "0x308B4F0", VA = "0x308B4F0")]
	public static string ConvertDateTimeToMD(DateTime time)
	{
		return null;
	}

	[Token(Token = "0x6019C07")]
	[Address(RVA = "0x308B5F0", Offset = "0x308B5F0", VA = "0x308B5F0")]
	public static string ConvertDateTimeToHM(DateTime time)
	{
		return null;
	}

	[Token(Token = "0x6019C08")]
	[Address(RVA = "0x308B6F0", Offset = "0x308B6F0", VA = "0x308B6F0")]
	public static DateTime CovertChinaStandardDateTimeToCurrentTimeZoneDateTime(DateTime chinaTime)
	{
		return default(DateTime);
	}

	[Token(Token = "0x6019C09")]
	[Address(RVA = "0x308B818", Offset = "0x308B818", VA = "0x308B818")]
	public static DateTime CovertUtcDateTimeToChinaStandardDateTime(DateTime utcTime)
	{
		return default(DateTime);
	}

	[Token(Token = "0x6019C0A")]
	[Address(RVA = "0x308B7D0", Offset = "0x308B7D0", VA = "0x308B7D0")]
	public static DateTime CovertChinaStandardDateTimeToUtcDateTime(DateTime chinaTime)
	{
		return default(DateTime);
	}

	[Token(Token = "0x6019C0B")]
	[Address(RVA = "0x308AF2C", Offset = "0x308AF2C", VA = "0x308AF2C")]
	public static DateTime CovertTimeSpanToChinaStandardDateTime(double timeSpan)
	{
		return default(DateTime);
	}

	[Token(Token = "0x6019C0C")]
	[Address(RVA = "0x308B860", Offset = "0x308B860", VA = "0x308B860")]
	public static DateTime CovertTimeSpanToDateTime(double timeSpan)
	{
		return default(DateTime);
	}

	[Token(Token = "0x6019C0D")]
	[Address(RVA = "0x308B8E4", Offset = "0x308B8E4", VA = "0x308B8E4")]
	public static string FormatTimeStampShort(double timeStamp)
	{
		return null;
	}

	[Token(Token = "0x6019C0E")]
	[Address(RVA = "0x308BC6C", Offset = "0x308BC6C", VA = "0x308BC6C")]
	public static string FormatTimeStampItem(double timeStamp, bool isBefore = false)
	{
		return null;
	}

	[Token(Token = "0x6019C0F")]
	[Address(RVA = "0x308C140", Offset = "0x308C140", VA = "0x308C140")]
	public static string FormatTimeStampCD(double timeStamp, bool isBefore = false, bool needSec = true)
	{
		return null;
	}

	[Token(Token = "0x6019C10")]
	[Address(RVA = "0x308CAFC", Offset = "0x308CAFC", VA = "0x308CAFC")]
	public static string FormatShortTimeStampCD(double timeStamp)
	{
		return null;
	}

	[Token(Token = "0x6019C11")]
	[Address(RVA = "0x308CF88", Offset = "0x308CF88", VA = "0x308CF88")]
	public static string FormatFuzzyTimeStampCD(double timeStamp)
	{
		return null;
	}

	[Token(Token = "0x6019C12")]
	[Address(RVA = "0x308D458", Offset = "0x308D458", VA = "0x308D458")]
	public static int GetCurrentWeekNum()
	{
		return default(int);
	}

	[Token(Token = "0x6019C13")]
	[Address(RVA = "0x308D61C", Offset = "0x308D61C", VA = "0x308D61C")]
	public static string TimeStampCD(double timeStamp)
	{
		return null;
	}

	[Token(Token = "0x6019C14")]
	[Address(RVA = "0x308D6E4", Offset = "0x308D6E4", VA = "0x308D6E4")]
	public static string ChatSendTime(ulong timeStamp)
	{
		return null;
	}

	[Token(Token = "0x6019C15")]
	[Address(RVA = "0x308DC74", Offset = "0x308DC74", VA = "0x308DC74")]
	public static bool IsBetweenStartEndTime(ulong startStamp, ulong endStamp, bool both0 = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6019C16")]
	[Address(RVA = "0x308DD70", Offset = "0x308DD70", VA = "0x308DD70")]
	public static string ToString(DateTime dateTime, string formatStr)
	{
		return null;
	}

	[Token(Token = "0x6019C17")]
	[Address(RVA = "0x308DE14", Offset = "0x308DE14", VA = "0x308DE14")]
	public static DateTime ConverToDateTime(string formatStr)
	{
		return default(DateTime);
	}

	[Token(Token = "0x6019C18")]
	[Address(RVA = "0x308DEDC", Offset = "0x308DEDC", VA = "0x308DEDC")]
	public static uint GetTomorrowServerTimeOffset(int hour, bool adjust = false)
	{
		return default(uint);
	}
}
