using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000471")]
public class SingersBClothDanceConfigData : CSVBaseData
{
	[Token(Token = "0x4003D10")]
	[FieldOffset(Offset = "0x8")]
	public string ClothID;

	[Token(Token = "0x4003D11")]
	[FieldOffset(Offset = "0xC")]
	public uint[] ClothIDs;

	[Token(Token = "0x4003D12")]
	[FieldOffset(Offset = "0x10")]
	public uint Sex;

	[Token(Token = "0x4003D13")]
	[FieldOffset(Offset = "0x14")]
	public bool IsDefault;

	[Token(Token = "0x4003D14")]
	[FieldOffset(Offset = "0x18")]
	public uint AvatartID;

	[Token(Token = "0x6001657")]
	[Address(RVA = "0x20EE684", Offset = "0x20EE684", VA = "0x20EE684")]
	public SingersBClothDanceConfigData()
	{
	}

	[Token(Token = "0x6001658")]
	[Address(RVA = "0x20EE708", Offset = "0x20EE708", VA = "0x20EE708", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6001659")]
	[Address(RVA = "0x20EE814", Offset = "0x20EE814", VA = "0x20EE814", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
