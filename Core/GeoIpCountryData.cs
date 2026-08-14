using GCommon;
using Il2CppDummyDll;

[Token(Token = "0x2000143")]
public class GeoIpCountryData : CSVBaseData
{
	[Token(Token = "0x4000830")]
	[FieldOffset(Offset = "0x8")]
	public string CountryCode;

	[Token(Token = "0x4000831")]
	[FieldOffset(Offset = "0xC")]
	public bool IsBlackBlood;

	[Token(Token = "0x4000832")]
	[FieldOffset(Offset = "0xD")]
	public bool IsNoBlood;

	[Token(Token = "0x4000833")]
	[FieldOffset(Offset = "0xE")]
	public bool IsNoGacha;

	[Token(Token = "0x4000834")]
	[FieldOffset(Offset = "0xF")]
	public bool Is18AgeShow;

	[Token(Token = "0x4000835")]
	[FieldOffset(Offset = "0x10")]
	public bool IsNotPPTOP;

	[Token(Token = "0x4000836")]
	[FieldOffset(Offset = "0x14")]
	public int DefaultBlood;

	[Token(Token = "0x60007B2")]
	[Address(RVA = "0x350218C", Offset = "0x350218C", VA = "0x350218C")]
	public GeoIpCountryData()
	{
	}

	[Token(Token = "0x60007B3")]
	[Address(RVA = "0x3502210", Offset = "0x3502210", VA = "0x3502210", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60007B4")]
	[Address(RVA = "0x3502218", Offset = "0x3502218", VA = "0x3502218", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
