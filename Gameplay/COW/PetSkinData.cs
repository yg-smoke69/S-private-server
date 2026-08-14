using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20001FC")]
public class PetSkinData : CSVBaseData
{
	[Token(Token = "0x4000BDE")]
	[FieldOffset(Offset = "0x8")]
	public uint SkinID;

	[Token(Token = "0x4000BDF")]
	[FieldOffset(Offset = "0xC")]
	public int PetID;

	[Token(Token = "0x4000BE0")]
	[FieldOffset(Offset = "0x10")]
	public int PetLevel;

	[Token(Token = "0x4000BE1")]
	[FieldOffset(Offset = "0x14")]
	public ResourceID UISkinPrefab;

	[Token(Token = "0x4000BE2")]
	[FieldOffset(Offset = "0x18")]
	public ResourceID IngameSkinPrefab;

	[Token(Token = "0x4000BE3")]
	[FieldOffset(Offset = "0x1C")]
	public ResourceID IngameSkinPrefab3P;

	[Token(Token = "0x4000BE4")]
	[FieldOffset(Offset = "0x20")]
	public ResourceID IngameSkinPrefabMode;

	[Token(Token = "0x4000BE5")]
	[FieldOffset(Offset = "0x24")]
	public ResourceID IngameSkinPrefab3PMode;

	[Token(Token = "0x4000BE6")]
	[FieldOffset(Offset = "0x28")]
	public bool OverrideShowHideEffect;

	[Token(Token = "0x4000BE7")]
	[FieldOffset(Offset = "0x2C")]
	public ResourceID ShowHideEffect;

	[Token(Token = "0x6000A51")]
	[Address(RVA = "0x1C00FC0", Offset = "0x1C00FC0", VA = "0x1C00FC0")]
	public PetSkinData()
	{
	}

	[Token(Token = "0x6000A52")]
	[Address(RVA = "0x1C01044", Offset = "0x1C01044", VA = "0x1C01044", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000A53")]
	[Address(RVA = "0x1C010A8", Offset = "0x1C010A8", VA = "0x1C010A8", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
