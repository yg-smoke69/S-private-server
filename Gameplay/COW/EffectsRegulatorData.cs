using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000115")]
public class EffectsRegulatorData : CSVBaseData
{
	[Token(Token = "0x40006FD")]
	[FieldOffset(Offset = "0x8")]
	public ResourceID effectID;

	[Token(Token = "0x40006FE")]
	[FieldOffset(Offset = "0xC")]
	public uint trigger;

	[Token(Token = "0x60006D3")]
	[Address(RVA = "0x25218DC", Offset = "0x25218DC", VA = "0x25218DC")]
	public EffectsRegulatorData()
	{
	}

	[Token(Token = "0x60006D4")]
	[Address(RVA = "0x2521960", Offset = "0x2521960", VA = "0x2521960", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60006D5")]
	[Address(RVA = "0x25219D8", Offset = "0x25219D8", VA = "0x25219D8", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
