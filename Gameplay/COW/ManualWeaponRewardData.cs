using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200019D")]
public class ManualWeaponRewardData : CSVBaseData
{
	[Token(Token = "0x40009FE")]
	[FieldOffset(Offset = "0x8")]
	public uint QuantityPeriod;

	[Token(Token = "0x40009FF")]
	[FieldOffset(Offset = "0xC")]
	public uint AwardType1;

	[Token(Token = "0x4000A00")]
	[FieldOffset(Offset = "0x10")]
	public uint AwardId1;

	[Token(Token = "0x4000A01")]
	[FieldOffset(Offset = "0x14")]
	public uint AwardNum1;

	[Token(Token = "0x4000A02")]
	[FieldOffset(Offset = "0x18")]
	public uint AwardTime1;

	[Token(Token = "0x4000A03")]
	[FieldOffset(Offset = "0x1C")]
	public uint AwardType2;

	[Token(Token = "0x4000A04")]
	[FieldOffset(Offset = "0x20")]
	public uint AwardId2;

	[Token(Token = "0x4000A05")]
	[FieldOffset(Offset = "0x24")]
	public uint AwardNum2;

	[Token(Token = "0x4000A06")]
	[FieldOffset(Offset = "0x28")]
	public uint AwardTime2;

	[Token(Token = "0x4000A07")]
	[FieldOffset(Offset = "0x2C")]
	public uint AwardType3;

	[Token(Token = "0x4000A08")]
	[FieldOffset(Offset = "0x30")]
	public uint AwardId3;

	[Token(Token = "0x4000A09")]
	[FieldOffset(Offset = "0x34")]
	public uint AwardNum3;

	[Token(Token = "0x4000A0A")]
	[FieldOffset(Offset = "0x38")]
	public uint AwardTime3;

	[Token(Token = "0x4000A0B")]
	[FieldOffset(Offset = "0x3C")]
	public string AwardName1;

	[Token(Token = "0x4000A0C")]
	[FieldOffset(Offset = "0x40")]
	public string AwardName2;

	[Token(Token = "0x4000A0D")]
	[FieldOffset(Offset = "0x44")]
	public string AwardName3;

	[Token(Token = "0x6000901")]
	[Address(RVA = "0x1533D18", Offset = "0x1533D18", VA = "0x1533D18")]
	public ManualWeaponRewardData()
	{
	}

	[Token(Token = "0x6000902")]
	[Address(RVA = "0x1533D9C", Offset = "0x1533D9C", VA = "0x1533D9C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000903")]
	[Address(RVA = "0x1533E00", Offset = "0x1533E00", VA = "0x1533E00", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
