using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2000122")]
public class EPPreorderData : CSVBaseData
{
	[Token(Token = "0x400075C")]
	[FieldOffset(Offset = "0x8")]
	public DateTime StartTime;

	[Token(Token = "0x400075D")]
	[FieldOffset(Offset = "0x18")]
	public DateTime EndTime;

	[Token(Token = "0x400075E")]
	[FieldOffset(Offset = "0x28")]
	public string Region;

	[Token(Token = "0x400075F")]
	[FieldOffset(Offset = "0x2C")]
	public uint[] PreviewItem;

	[Token(Token = "0x4000760")]
	[FieldOffset(Offset = "0x30")]
	public uint EPID;

	[Token(Token = "0x4000761")]
	[FieldOffset(Offset = "0x34")]
	public EInventory.AwardType ExAwardType1;

	[Token(Token = "0x4000762")]
	[FieldOffset(Offset = "0x38")]
	public uint ExAwardID1;

	[Token(Token = "0x4000763")]
	[FieldOffset(Offset = "0x3C")]
	public uint ExAwardCnt1;

	[Token(Token = "0x4000764")]
	[FieldOffset(Offset = "0x40")]
	public uint ExAwardTime1;

	[Token(Token = "0x4000765")]
	[FieldOffset(Offset = "0x44")]
	public EInventory.AwardType ExAwardType2;

	[Token(Token = "0x4000766")]
	[FieldOffset(Offset = "0x48")]
	public uint ExAwardID2;

	[Token(Token = "0x4000767")]
	[FieldOffset(Offset = "0x4C")]
	public uint ExAwardCnt2;

	[Token(Token = "0x4000768")]
	[FieldOffset(Offset = "0x50")]
	public uint ExAwardTime2;

	[Token(Token = "0x4000769")]
	[FieldOffset(Offset = "0x54")]
	public ResourceID PreorderIcon;

	[Token(Token = "0x6000716")]
	[Address(RVA = "0x2518F3C", Offset = "0x2518F3C", VA = "0x2518F3C")]
	public EPPreorderData()
	{
	}

	[Token(Token = "0x6000717")]
	[Address(RVA = "0x2518FC0", Offset = "0x2518FC0", VA = "0x2518FC0", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000718")]
	[Address(RVA = "0x25190A4", Offset = "0x25190A4", VA = "0x25190A4", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x6000719")]
	[Address(RVA = "0x251957C", Offset = "0x251957C", VA = "0x251957C")]
	public static bool IsNextEPPreorder(uint curEPID)
	{
		return default(bool);
	}

	[Token(Token = "0x600071A")]
	[Address(RVA = "0x25196BC", Offset = "0x25196BC", VA = "0x25196BC")]
	public static EPPreorderData GetPreorderData(uint epid)
	{
		return null;
	}

	[Token(Token = "0x600071B")]
	[Address(RVA = "0x2519938", Offset = "0x2519938", VA = "0x2519938")]
	public List<BaseItemInfo> GetPreviewItem()
	{
		return null;
	}
}
