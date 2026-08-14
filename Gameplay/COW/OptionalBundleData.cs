using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20001C1")]
public class OptionalBundleData : CsvDataIndexedReading
{
	[Token(Token = "0x4000AD3")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x4000AD4")]
	[FieldOffset(Offset = "0xC")]
	public uint Order;

	[Token(Token = "0x4000AD5")]
	[FieldOffset(Offset = "0x10")]
	public EInventory.AwardType AwardType;

	[Token(Token = "0x4000AD6")]
	[FieldOffset(Offset = "0x14")]
	public uint AwardID;

	[Token(Token = "0x4000AD7")]
	[FieldOffset(Offset = "0x18")]
	public uint AwardNum;

	[Token(Token = "0x4000AD8")]
	[FieldOffset(Offset = "0x1C")]
	public uint AwardTime;

	[Token(Token = "0x4000AD9")]
	[FieldOffset(Offset = "0x20")]
	public EInventory.AwardType ReturnType;

	[Token(Token = "0x4000ADA")]
	[FieldOffset(Offset = "0x24")]
	public uint ReturnID;

	[Token(Token = "0x4000ADB")]
	[FieldOffset(Offset = "0x28")]
	public uint ReturnNum;

	[Token(Token = "0x4000ADC")]
	[FieldOffset(Offset = "0x2C")]
	public bool IsPreview;

	[Token(Token = "0x4000ADD")]
	[FieldOffset(Offset = "0x30")]
	public uint PreviewAvatar;

	[Token(Token = "0x4000ADE")]
	[FieldOffset(Offset = "0x34")]
	public uint DefaultMaleRole;

	[Token(Token = "0x4000ADF")]
	[FieldOffset(Offset = "0x38")]
	public uint DefaultFemaleRole;

	[Token(Token = "0x4000AE0")]
	[FieldOffset(Offset = "0x3C")]
	public uint OriginalPrice;

	[Token(Token = "0x6000974")]
	[Address(RVA = "0x28C7B38", Offset = "0x28C7B38", VA = "0x28C7B38")]
	public OptionalBundleData()
	{
	}

	[Token(Token = "0x6000975")]
	[Address(RVA = "0x28C7B40", Offset = "0x28C7B40", VA = "0x28C7B40", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000976")]
	[Address(RVA = "0x28C7BA4", Offset = "0x28C7BA4", VA = "0x28C7BA4", Slot = "7")]
	public override string[] GetHeadColNames()
	{
		return null;
	}

	[Token(Token = "0x6000977")]
	[Address(RVA = "0x28C8250", Offset = "0x28C8250", VA = "0x28C8250", Slot = "8")]
	public override void ParseData(IIndexString ss, int[] index)
	{
	}

	[Token(Token = "0x6000978")]
	[Address(RVA = "0x28C8E30", Offset = "0x28C8E30", VA = "0x28C8E30")]
	public string[] _003C_003EiFixBaseProxy_GetHeadColNames()
	{
		return null;
	}

	[Token(Token = "0x6000979")]
	[Address(RVA = "0x28C8E38", Offset = "0x28C8E38", VA = "0x28C8E38")]
	public void _003C_003EiFixBaseProxy_ParseData(IIndexString P0, int[] P1)
	{
	}
}
