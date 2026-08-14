using GCommon;
using Il2CppDummyDll;

[Token(Token = "0x20001C0")]
public class NotifyData : CSVBaseData
{
	[Token(Token = "0x4000ACF")]
	[FieldOffset(Offset = "0x8")]
	public string ID;

	[Token(Token = "0x4000AD0")]
	[FieldOffset(Offset = "0xC")]
	public string NotifyType;

	[Token(Token = "0x4000AD1")]
	[FieldOffset(Offset = "0x10")]
	public string NotifyContentString;

	[Token(Token = "0x4000AD2")]
	[FieldOffset(Offset = "0x14")]
	public string NotifyTypePic;

	[Token(Token = "0x6000971")]
	[Address(RVA = "0x1C73F7C", Offset = "0x1C73F7C", VA = "0x1C73F7C")]
	public NotifyData()
	{
	}

	[Token(Token = "0x6000972")]
	[Address(RVA = "0x1C74000", Offset = "0x1C74000", VA = "0x1C74000", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000973")]
	[Address(RVA = "0x1C74008", Offset = "0x1C74008", VA = "0x1C74008", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
