using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20001CC")]
public class PartyShootingMusicTargetData : CSVBaseData
{
	[Token(Token = "0x4000AFB")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x4000AFC")]
	[FieldOffset(Offset = "0xC")]
	public float checktime1;

	[Token(Token = "0x4000AFD")]
	[FieldOffset(Offset = "0x10")]
	public float checktime2;

	[Token(Token = "0x4000AFE")]
	[FieldOffset(Offset = "0x14")]
	public uint iidex;

	[Token(Token = "0x4000AFF")]
	[FieldOffset(Offset = "0x18")]
	public string modelid;

	[Token(Token = "0x600099F")]
	[Address(RVA = "0x28D17B8", Offset = "0x28D17B8", VA = "0x28D17B8")]
	public PartyShootingMusicTargetData()
	{
	}

	[Token(Token = "0x60009A0")]
	[Address(RVA = "0x28D183C", Offset = "0x28D183C", VA = "0x28D183C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60009A1")]
	[Address(RVA = "0x28D18A0", Offset = "0x28D18A0", VA = "0x28D18A0", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
