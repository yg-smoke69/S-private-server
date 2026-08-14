using GCommon;
using Il2CppDummyDll;
using WwiseGameSyncs;

namespace COW;

[Token(Token = "0x2000157")]
public class ImpactPerformaceData : CSVBaseData
{
	[Token(Token = "0x40008A9")]
	[FieldOffset(Offset = "0x8")]
	public string MaterialType;

	[Token(Token = "0x40008AA")]
	[FieldOffset(Offset = "0xC")]
	public ResourceID EffectRes;

	[Token(Token = "0x40008AB")]
	[FieldOffset(Offset = "0x10")]
	public ResourceID SoundRes;

	[Token(Token = "0x40008AC")]
	[FieldOffset(Offset = "0x14")]
	public ResourceID DecalRes;

	[Token(Token = "0x40008AD")]
	[FieldOffset(Offset = "0x18")]
	public ResourceID DecalRes_1;

	[Token(Token = "0x40008AE")]
	[FieldOffset(Offset = "0x1C")]
	public ResourceID DecalRes_2;

	[Token(Token = "0x40008AF")]
	[FieldOffset(Offset = "0x20")]
	public SwitchBase ImpactSwitch;

	[Token(Token = "0x6000811")]
	[Address(RVA = "0x2C71584", Offset = "0x2C71584", VA = "0x2C71584")]
	public ImpactPerformaceData()
	{
	}

	[Token(Token = "0x6000812")]
	[Address(RVA = "0x2C71608", Offset = "0x2C71608", VA = "0x2C71608", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000813")]
	[Address(RVA = "0x2C71660", Offset = "0x2C71660", VA = "0x2C71660", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
