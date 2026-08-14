using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000211")]
public class RebateCardNotifyData : CSVBaseData
{
	[Token(Token = "0x4000C44")]
	[FieldOffset(Offset = "0x8")]
	public string Region;

	[Token(Token = "0x4000C45")]
	[FieldOffset(Offset = "0xC")]
	public string TimeOfDay;

	[Token(Token = "0x4000C46")]
	[FieldOffset(Offset = "0x10")]
	public int TimeOfDay_Seconds;

	[Token(Token = "0x4000C47")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<string, RebateCardNotifyData> _Data;

	[Token(Token = "0x4000C48")]
	private const string REGION_DEFAULT = "default";

	[Token(Token = "0x6000A99")]
	[Address(RVA = "0x1970298", Offset = "0x1970298", VA = "0x1970298")]
	public RebateCardNotifyData()
	{
	}

	[Token(Token = "0x6000A9A")]
	[Address(RVA = "0x197031C", Offset = "0x197031C", VA = "0x197031C")]
	public static RebateCardNotifyData Get(string region)
	{
		return null;
	}

	[Token(Token = "0x6000A9B")]
	[Address(RVA = "0x1970594", Offset = "0x1970594", VA = "0x1970594", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000A9C")]
	[Address(RVA = "0x19705EC", Offset = "0x19705EC", VA = "0x19705EC", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x6000A9D")]
	[Address(RVA = "0x19707C0", Offset = "0x19707C0", VA = "0x19707C0")]
	private static int ParseTimeOfDayToSeconds(string timeOfDay)
	{
		return default(int);
	}
}
