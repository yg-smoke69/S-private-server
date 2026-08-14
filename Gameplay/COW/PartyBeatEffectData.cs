using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20001CA")]
public class PartyBeatEffectData : CSVBaseData
{
	[Token(Token = "0x4000AF6")]
	[FieldOffset(Offset = "0x8")]
	public uint EffectLevel;

	[Token(Token = "0x4000AF7")]
	[FieldOffset(Offset = "0xC")]
	public uint NeedCombo;

	[Token(Token = "0x4000AF8")]
	[FieldOffset(Offset = "0x10")]
	public ResourceID EffectResID;

	[Token(Token = "0x6000999")]
	[Address(RVA = "0x28CFB18", Offset = "0x28CFB18", VA = "0x28CFB18")]
	public PartyBeatEffectData()
	{
	}

	[Token(Token = "0x600099A")]
	[Address(RVA = "0x28CFB9C", Offset = "0x28CFB9C", VA = "0x28CFB9C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x600099B")]
	[Address(RVA = "0x28CFC00", Offset = "0x28CFC00", VA = "0x28CFC00", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
