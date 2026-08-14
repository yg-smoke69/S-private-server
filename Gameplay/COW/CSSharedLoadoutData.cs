using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200010A")]
public class CSSharedLoadoutData : CSVBaseData, _Attribute
{
	[Token(Token = "0x40006BF")]
	[FieldOffset(Offset = "0x8")]
	public uint iID;

	[Token(Token = "0x40006C0")]
	[FieldOffset(Offset = "0xC")]
	public uint itemType;

	[Token(Token = "0x40006C1")]
	[FieldOffset(Offset = "0x10")]
	public int pageID;

	[Token(Token = "0x40006C2")]
	[FieldOffset(Offset = "0x14")]
	public bool isSold;

	[Token(Token = "0x40006C3")]
	[FieldOffset(Offset = "0x18")]
	public uint playCardID;

	[Token(Token = "0x40006C4")]
	[FieldOffset(Offset = "0x1C")]
	public string playCardSprite;

	[Token(Token = "0x60006A8")]
	[Address(RVA = "0x182B7FC", Offset = "0x182B7FC", VA = "0x182B7FC")]
	public CSSharedLoadoutData()
	{
	}

	[Token(Token = "0x60006A9")]
	[Address(RVA = "0x182B880", Offset = "0x182B880", VA = "0x182B880", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60006AA")]
	[Address(RVA = "0x182B8E4", Offset = "0x182B8E4", VA = "0x182B8E4", Slot = "9")]
	public uint GetId()
	{
		return default(uint);
	}

	[Token(Token = "0x60006AB")]
	[Address(RVA = "0x182B93C", Offset = "0x182B93C", VA = "0x182B93C", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
