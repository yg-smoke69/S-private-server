using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200021D")]
public class RoomCreateCSShopData : CSVBaseData
{
	[Token(Token = "0x4000C94")]
	[FieldOffset(Offset = "0x8")]
	public uint Index;

	[Token(Token = "0x4000C95")]
	[FieldOffset(Offset = "0xC")]
	public uint ItemId;

	[Token(Token = "0x4000C96")]
	[FieldOffset(Offset = "0x10")]
	public int Price;

	[Token(Token = "0x4000C97")]
	[FieldOffset(Offset = "0x14")]
	public uint TypeTab;

	[Token(Token = "0x4000C98")]
	[FieldOffset(Offset = "0x18")]
	public bool IsOpen;

	[Token(Token = "0x4000C99")]
	[FieldOffset(Offset = "0x19")]
	public bool Selected;

	[Token(Token = "0x6000AC5")]
	[Address(RVA = "0x240F170", Offset = "0x240F170", VA = "0x240F170")]
	public RoomCreateCSShopData()
	{
	}

	[Token(Token = "0x6000AC6")]
	[Address(RVA = "0x240F1F4", Offset = "0x240F1F4", VA = "0x240F1F4", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000AC7")]
	[Address(RVA = "0x240F258", Offset = "0x240F258", VA = "0x240F258", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
