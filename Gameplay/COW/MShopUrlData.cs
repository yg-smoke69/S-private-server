using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20001AD")]
public class MShopUrlData : CSVBaseData
{
	[Token(Token = "0x4000A5A")]
	[FieldOffset(Offset = "0x8")]
	public uint ProcutionID;

	[Token(Token = "0x4000A5B")]
	[FieldOffset(Offset = "0xC")]
	public int ServerID;

	[Token(Token = "0x4000A5C")]
	[FieldOffset(Offset = "0x10")]
	public string AndroidMSHOPUrl;

	[Token(Token = "0x4000A5D")]
	[FieldOffset(Offset = "0x14")]
	public string AndroidMaxMSHOPUrl;

	[Token(Token = "0x4000A5E")]
	[FieldOffset(Offset = "0x18")]
	public string IOSMSHOPUrl;

	[Token(Token = "0x4000A5F")]
	[FieldOffset(Offset = "0x1C")]
	public string IOSMaxMSHOPUrl;

	[Token(Token = "0x4000A60")]
	[FieldOffset(Offset = "0x20")]
	public string AndroidThirdPartyMSHOPUrl;

	[Token(Token = "0x4000A61")]
	[FieldOffset(Offset = "0x24")]
	public string HuaWeiMSHOPUrl;

	[Token(Token = "0x4000A62")]
	[FieldOffset(Offset = "0x28")]
	public string SamsungMSHOPUrl;

	[Token(Token = "0x6000939")]
	[Address(RVA = "0x1531A7C", Offset = "0x1531A7C", VA = "0x1531A7C")]
	public MShopUrlData()
	{
	}

	[Token(Token = "0x600093A")]
	[Address(RVA = "0x1531B00", Offset = "0x1531B00", VA = "0x1531B00", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x600093B")]
	[Address(RVA = "0x1531B64", Offset = "0x1531B64", VA = "0x1531B64", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
