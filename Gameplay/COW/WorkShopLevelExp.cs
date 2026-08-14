using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200027A")]
public class WorkShopLevelExp : CSVBaseData
{
	[Token(Token = "0x4000F0A")]
	[FieldOffset(Offset = "0x8")]
	public uint Level;

	[Token(Token = "0x4000F0B")]
	[FieldOffset(Offset = "0xC")]
	public uint Exp;

	[Token(Token = "0x4000F0C")]
	[FieldOffset(Offset = "0x10")]
	public string Name;

	[Token(Token = "0x4000F0D")]
	[FieldOffset(Offset = "0x14")]
	public string Icon;

	[Token(Token = "0x4000F0E")]
	[FieldOffset(Offset = "0x18")]
	public uint MaxCost;

	[Token(Token = "0x4000F0F")]
	[FieldOffset(Offset = "0x1C")]
	public string explain;

	[Token(Token = "0x4000F10")]
	[FieldOffset(Offset = "0x20")]
	public uint RewardType1;

	[Token(Token = "0x4000F11")]
	[FieldOffset(Offset = "0x24")]
	public uint RewardId1;

	[Token(Token = "0x4000F12")]
	[FieldOffset(Offset = "0x28")]
	public uint RewardCnt1;

	[Token(Token = "0x4000F13")]
	[FieldOffset(Offset = "0x2C")]
	public uint RewardType2;

	[Token(Token = "0x4000F14")]
	[FieldOffset(Offset = "0x30")]
	public uint RewardId2;

	[Token(Token = "0x4000F15")]
	[FieldOffset(Offset = "0x34")]
	public uint RewardCnt2;

	[Token(Token = "0x4000F16")]
	[FieldOffset(Offset = "0x38")]
	public uint RewardType3;

	[Token(Token = "0x4000F17")]
	[FieldOffset(Offset = "0x3C")]
	public uint RewardId3;

	[Token(Token = "0x4000F18")]
	[FieldOffset(Offset = "0x40")]
	public uint RewardCnt3;

	[Token(Token = "0x6000C1E")]
	[Address(RVA = "0x21BBE58", Offset = "0x21BBE58", VA = "0x21BBE58")]
	public WorkShopLevelExp()
	{
	}

	[Token(Token = "0x6000C1F")]
	[Address(RVA = "0x21BBEDC", Offset = "0x21BBEDC", VA = "0x21BBEDC", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000C20")]
	[Address(RVA = "0x21BBF40", Offset = "0x21BBF40", VA = "0x21BBF40", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x6000C21")]
	[Address(RVA = "0x21BC2E4", Offset = "0x21BC2E4", VA = "0x21BC2E4")]
	public List<BaseItemInfo> GetAwardList()
	{
		return null;
	}
}
