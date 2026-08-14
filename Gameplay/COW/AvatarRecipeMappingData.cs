using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000AD")]
public class AvatarRecipeMappingData : CSVBaseData
{
	[Token(Token = "0x40003F2")]
	[FieldOffset(Offset = "0x8")]
	public int ID;

	[Token(Token = "0x40003F3")]
	[FieldOffset(Offset = "0xC")]
	public int TargetRecipeSlot;

	[Token(Token = "0x40003F4")]
	[FieldOffset(Offset = "0x10")]
	public string TargetRecipe;

	[Token(Token = "0x40003F5")]
	[FieldOffset(Offset = "0x14")]
	public int ConditionRecipeSlot;

	[Token(Token = "0x40003F6")]
	[FieldOffset(Offset = "0x18")]
	public string ConditionRecipe;

	[Token(Token = "0x40003F7")]
	[FieldOffset(Offset = "0x1C")]
	public string ResultRecipe;

	[Token(Token = "0x600047D")]
	[Address(RVA = "0x2358974", Offset = "0x2358974", VA = "0x2358974")]
	public AvatarRecipeMappingData()
	{
	}

	[Token(Token = "0x600047E")]
	[Address(RVA = "0x23589F8", Offset = "0x23589F8", VA = "0x23589F8", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x600047F")]
	[Address(RVA = "0x2358A5C", Offset = "0x2358A5C", VA = "0x2358A5C", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
