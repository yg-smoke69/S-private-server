using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000173")]
public class LinkActivityData : CSVBaseData
{
	[Token(Token = "0x4000958")]
	[FieldOffset(Offset = "0x8")]
	public uint Id;

	[Token(Token = "0x4000959")]
	[FieldOffset(Offset = "0xC")]
	public uint Type;

	[Token(Token = "0x400095A")]
	[FieldOffset(Offset = "0x10")]
	public DateTime StartTime;

	[Token(Token = "0x400095B")]
	[FieldOffset(Offset = "0x20")]
	public DateTime EndTime;

	[Token(Token = "0x400095C")]
	[FieldOffset(Offset = "0x30")]
	public uint[] ExchangeIds;

	[Token(Token = "0x400095D")]
	[FieldOffset(Offset = "0x34")]
	public uint[] ExchangeAwardTimes;

	[Token(Token = "0x400095E")]
	[FieldOffset(Offset = "0x38")]
	public int ProcessNum;

	[Token(Token = "0x400095F")]
	[FieldOffset(Offset = "0x3C")]
	public int CircleType;

	[Token(Token = "0x4000960")]
	[FieldOffset(Offset = "0x40")]
	public uint AwardId;

	[Token(Token = "0x4000961")]
	[FieldOffset(Offset = "0x44")]
	public string UrlGoPos;

	[Token(Token = "0x4000962")]
	[FieldOffset(Offset = "0x48")]
	public string CdnUrl;

	[Token(Token = "0x4000963")]
	[FieldOffset(Offset = "0x4C")]
	public ResourceID EntrySprite;

	[Token(Token = "0x6000884")]
	[Address(RVA = "0xEC69A4", Offset = "0xEC69A4", VA = "0xEC69A4")]
	public LinkActivityData()
	{
	}

	[Token(Token = "0x6000885")]
	[Address(RVA = "0xEC6A28", Offset = "0xEC6A28", VA = "0xEC6A28", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000886")]
	[Address(RVA = "0xEC6A8C", Offset = "0xEC6A8C", VA = "0xEC6A8C", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x6000887")]
	[Address(RVA = "0xEC6E70", Offset = "0xEC6E70", VA = "0xEC6E70")]
	public int GetTotalDays()
	{
		return default(int);
	}
}
