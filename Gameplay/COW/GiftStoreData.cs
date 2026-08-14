using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000144")]
public class GiftStoreData : CSVBaseData
{
	[Token(Token = "0x4000837")]
	[FieldOffset(Offset = "0x8")]
	public uint StoreID;

	[Token(Token = "0x4000838")]
	[FieldOffset(Offset = "0xC")]
	public string StoreIcon;

	[Token(Token = "0x4000839")]
	[FieldOffset(Offset = "0x10")]
	public string StoreTab;

	[Token(Token = "0x60007B5")]
	[Address(RVA = "0x2591778", Offset = "0x2591778", VA = "0x2591778")]
	public GiftStoreData()
	{
	}

	[Token(Token = "0x60007B6")]
	[Address(RVA = "0x25917FC", Offset = "0x25917FC", VA = "0x25917FC", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60007B7")]
	[Address(RVA = "0x2591860", Offset = "0x2591860", VA = "0x2591860", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
