using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000E1")]
public class BackPackData : CSVBaseData, _Attribute
{
	[Token(Token = "0x4000554")]
	[FieldOffset(Offset = "0x8")]
	public string[] maleRecipes;

	[Token(Token = "0x4000555")]
	[FieldOffset(Offset = "0xC")]
	public string[] maleRecipes_N;

	[Token(Token = "0x4000556")]
	[FieldOffset(Offset = "0x10")]
	public string[] femaleRecipes;

	[Token(Token = "0x4000557")]
	[FieldOffset(Offset = "0x14")]
	public string[] femaleRecipes_N;

	[Token(Token = "0x4000558")]
	[FieldOffset(Offset = "0x18")]
	public uint iID;

	[Token(Token = "0x4000559")]
	[FieldOffset(Offset = "0x1C")]
	public uint sortId;

	[Token(Token = "0x400055A")]
	[FieldOffset(Offset = "0x20")]
	public uint LobbyNumber;

	[Token(Token = "0x400055B")]
	[FieldOffset(Offset = "0x24")]
	public uint IdleNumber;

	[Token(Token = "0x400055C")]
	[FieldOffset(Offset = "0x28")]
	public ResourceID previewResLV1;

	[Token(Token = "0x400055D")]
	[FieldOffset(Offset = "0x2C")]
	public ResourceID previewResLV2;

	[Token(Token = "0x400055E")]
	[FieldOffset(Offset = "0x30")]
	public ResourceID previewResLV3;

	[Token(Token = "0x400055F")]
	[FieldOffset(Offset = "0x34")]
	public ResourceID FeMaleIngameEffectLV3;

	[Token(Token = "0x4000560")]
	[FieldOffset(Offset = "0x38")]
	public ResourceID MaleIngameEffectLV3;

	[Token(Token = "0x4000561")]
	[FieldOffset(Offset = "0x3C")]
	public ResourceID ModleIDM;

	[Token(Token = "0x4000562")]
	[FieldOffset(Offset = "0x40")]
	public ResourceID ModleIDF;

	[Token(Token = "0x4000563")]
	[FieldOffset(Offset = "0x44")]
	public ResourceID LowModleIDM;

	[Token(Token = "0x4000564")]
	[FieldOffset(Offset = "0x48")]
	public ResourceID LowModleIDF;

	[Token(Token = "0x4000565")]
	[FieldOffset(Offset = "0x4C")]
	public ESourceType sourceTypeKey;

	[Token(Token = "0x4000566")]
	[FieldOffset(Offset = "0x4D")]
	public bool IsEffectsTrigger;

	[Token(Token = "0x4000567")]
	[FieldOffset(Offset = "0x4E")]
	public bool IsShow;

	[Token(Token = "0x60005E2")]
	[Address(RVA = "0x2E4D8D8", Offset = "0x2E4D8D8", VA = "0x2E4D8D8")]
	public BackPackData()
	{
	}

	[Token(Token = "0x60005E3")]
	[Address(RVA = "0x2E4D9D4", Offset = "0x2E4D9D4", VA = "0x2E4D9D4", Slot = "9")]
	public uint GetId()
	{
		return default(uint);
	}

	[Token(Token = "0x60005E4")]
	[Address(RVA = "0x2E4DA2C", Offset = "0x2E4DA2C", VA = "0x2E4DA2C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60005E5")]
	[Address(RVA = "0x2E4DA90", Offset = "0x2E4DA90", VA = "0x2E4DA90", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x60005E6")]
	[Address(RVA = "0x2E4F02C", Offset = "0x2E4F02C", VA = "0x2E4F02C")]
	public string GetCollectionRecipe(bool female, bool useHQ, uint level)
	{
		return null;
	}

	[Token(Token = "0x60005E7")]
	[Address(RVA = "0x2E4F190", Offset = "0x2E4F190", VA = "0x2E4F190")]
	public ResourceID GetPreviewResourceIDByLevel(ECollectionLevel level)
	{
		return default(ResourceID);
	}
}
