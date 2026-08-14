using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000181")]
public class LoadingTipsData : CSVBaseData
{
	[Token(Token = "0x4000985")]
	[FieldOffset(Offset = "0x8")]
	public uint iID;

	[Token(Token = "0x4000986")]
	[FieldOffset(Offset = "0xC")]
	public uint minLevel;

	[Token(Token = "0x4000987")]
	[FieldOffset(Offset = "0x10")]
	public uint maxLevel;

	[Token(Token = "0x4000988")]
	[FieldOffset(Offset = "0x14")]
	public uint modeId;

	[Token(Token = "0x4000989")]
	[FieldOffset(Offset = "0x18")]
	public string tipsContent;

	[Token(Token = "0x400098A")]
	[FieldOffset(Offset = "0x1C")]
	public uint[] matchMode;

	[Token(Token = "0x60008AC")]
	[Address(RVA = "0xEC9B2C", Offset = "0xEC9B2C", VA = "0xEC9B2C")]
	public LoadingTipsData()
	{
	}

	[Token(Token = "0x60008AD")]
	[Address(RVA = "0xEC9BB0", Offset = "0xEC9BB0", VA = "0xEC9BB0")]
	public uint GetId()
	{
		return default(uint);
	}

	[Token(Token = "0x60008AE")]
	[Address(RVA = "0xEC9C08", Offset = "0xEC9C08", VA = "0xEC9C08", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60008AF")]
	[Address(RVA = "0xEC9C6C", Offset = "0xEC9C6C", VA = "0xEC9C6C", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x60008B0")]
	[Address(RVA = "0xEC9E58", Offset = "0xEC9E58", VA = "0xEC9E58")]
	public bool FitMatchMode(uint iMatchMode)
	{
		return default(bool);
	}
}
