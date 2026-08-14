using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000279")]
public class WorkShopLevelDescriptionData : CSVBaseData
{
	[Token(Token = "0x4000F06")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x4000F07")]
	[FieldOffset(Offset = "0xC")]
	public uint GameMode;

	[Token(Token = "0x4000F08")]
	[FieldOffset(Offset = "0x10")]
	public string TagText;

	[Token(Token = "0x4000F09")]
	[FieldOffset(Offset = "0x14")]
	public string ImageUrl;

	[Token(Token = "0x6000C1B")]
	[Address(RVA = "0x21BB57C", Offset = "0x21BB57C", VA = "0x21BB57C")]
	public WorkShopLevelDescriptionData()
	{
	}

	[Token(Token = "0x6000C1C")]
	[Address(RVA = "0x21BB600", Offset = "0x21BB600", VA = "0x21BB600", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000C1D")]
	[Address(RVA = "0x21BB664", Offset = "0x21BB664", VA = "0x21BB664", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
