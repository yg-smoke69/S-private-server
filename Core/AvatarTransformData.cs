using GCommon;
using Il2CppDummyDll;

[Token(Token = "0x20000B3")]
public class AvatarTransformData : CSVBaseData
{
	[Token(Token = "0x20000B4")]
	public enum ShowType
	{
		[Token(Token = "0x4000448")]
		Normal,
		[Token(Token = "0x4000449")]
		Collection
	}

	[Token(Token = "0x4000442")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x4000443")]
	[FieldOffset(Offset = "0xC")]
	public ResourceID TransformerResId_1P;

	[Token(Token = "0x4000444")]
	[FieldOffset(Offset = "0x10")]
	public ResourceID TransformerResId_3P;

	[Token(Token = "0x4000445")]
	[FieldOffset(Offset = "0x14")]
	public bool isfemale;

	[Token(Token = "0x4000446")]
	[FieldOffset(Offset = "0x18")]
	public ShowType showType;

	[Token(Token = "0x6000518")]
	[Address(RVA = "0x2ECF9B4", Offset = "0x2ECF9B4", VA = "0x2ECF9B4")]
	public AvatarTransformData()
	{
	}

	[Token(Token = "0x6000519")]
	[Address(RVA = "0x2ECFA8C", Offset = "0x2ECFA8C", VA = "0x2ECFA8C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x600051A")]
	[Address(RVA = "0x2ECFA98", Offset = "0x2ECFA98", VA = "0x2ECFA98", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
