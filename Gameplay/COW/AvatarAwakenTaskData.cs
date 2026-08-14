using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000A6")]
public class AvatarAwakenTaskData : CSVBaseData
{
	[Token(Token = "0x40003AE")]
	[FieldOffset(Offset = "0x8")]
	public uint IID;

	[Token(Token = "0x40003AF")]
	[FieldOffset(Offset = "0xC")]
	public uint AvatarId;

	[Token(Token = "0x40003B0")]
	[FieldOffset(Offset = "0x10")]
	public uint TaskType;

	[Token(Token = "0x40003B1")]
	[FieldOffset(Offset = "0x14")]
	public uint TaskNeedValue;

	[Token(Token = "0x40003B2")]
	[FieldOffset(Offset = "0x18")]
	public string TaskDesc;

	[Token(Token = "0x40003B3")]
	[FieldOffset(Offset = "0x1C")]
	public bool NeedChangeValType;

	[Token(Token = "0x40003B4")]
	[FieldOffset(Offset = "0x20")]
	public uint RewardType1;

	[Token(Token = "0x40003B5")]
	[FieldOffset(Offset = "0x24")]
	public uint RewardId1;

	[Token(Token = "0x40003B6")]
	[FieldOffset(Offset = "0x28")]
	public uint RewardCnt1;

	[Token(Token = "0x40003B7")]
	[FieldOffset(Offset = "0x2C")]
	public uint RewardType2;

	[Token(Token = "0x40003B8")]
	[FieldOffset(Offset = "0x30")]
	public uint RewardId2;

	[Token(Token = "0x40003B9")]
	[FieldOffset(Offset = "0x34")]
	public uint RewardCnt2;

	[Token(Token = "0x40003BA")]
	[FieldOffset(Offset = "0x38")]
	public uint RewardType3;

	[Token(Token = "0x40003BB")]
	[FieldOffset(Offset = "0x3C")]
	public uint RewardId3;

	[Token(Token = "0x40003BC")]
	[FieldOffset(Offset = "0x40")]
	public uint RewardCnt3;

	[Token(Token = "0x40003BD")]
	[FieldOffset(Offset = "0x44")]
	public string ComicCDNLink;

	[Token(Token = "0x40003BE")]
	[FieldOffset(Offset = "0x48")]
	public string ComicDesc;

	[Token(Token = "0x40003BF")]
	[FieldOffset(Offset = "0x4C")]
	public string ComicLockCDN;

	[Token(Token = "0x40003C0")]
	[FieldOffset(Offset = "0x50")]
	public string ComicUnLockCDN;

	[Token(Token = "0x6000438")]
	[Address(RVA = "0x10FB6BC", Offset = "0x10FB6BC", VA = "0x10FB6BC")]
	public AvatarAwakenTaskData()
	{
	}

	[Token(Token = "0x6000439")]
	[Address(RVA = "0x10FB740", Offset = "0x10FB740", VA = "0x10FB740", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x600043A")]
	[Address(RVA = "0x10FB7A4", Offset = "0x10FB7A4", VA = "0x10FB7A4", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x600043B")]
	[Address(RVA = "0x10FBB70", Offset = "0x10FBB70", VA = "0x10FBB70")]
	public List<BaseItemInfo> GetAwardList()
	{
		return null;
	}
}
