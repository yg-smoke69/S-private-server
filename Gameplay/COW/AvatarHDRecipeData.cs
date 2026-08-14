using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000A8")]
public class AvatarHDRecipeData : CSVBaseData
{
	[Token(Token = "0x40003C5")]
	[FieldOffset(Offset = "0x8")]
	public string defaultRecipe;

	[Token(Token = "0x40003C6")]
	[FieldOffset(Offset = "0xC")]
	public string HDRecipe;

	[Token(Token = "0x600043F")]
	[Address(RVA = "0x234CE10", Offset = "0x234CE10", VA = "0x234CE10")]
	public AvatarHDRecipeData()
	{
	}

	[Token(Token = "0x6000440")]
	[Address(RVA = "0x234CE94", Offset = "0x234CE94", VA = "0x234CE94", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000441")]
	[Address(RVA = "0x234CEEC", Offset = "0x234CEEC", VA = "0x234CEEC", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
