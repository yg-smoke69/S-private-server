using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000C9")]
public class BombModeConfigData : CSVBaseData
{
	[Token(Token = "0x40004BF")]
	[FieldOffset(Offset = "0x8")]
	public uint BombPlantCastingTime;

	[Token(Token = "0x40004C0")]
	[FieldOffset(Offset = "0xC")]
	public uint BombRemoveCastingTime;

	[Token(Token = "0x40004C1")]
	[FieldOffset(Offset = "0x10")]
	public uint PliersRemoveCastingTime;

	[Token(Token = "0x40004C2")]
	[FieldOffset(Offset = "0x14")]
	public uint PliersID;

	[Token(Token = "0x40004C3")]
	[FieldOffset(Offset = "0x18")]
	public uint BombAliveTimeAfterSettle;

	[Token(Token = "0x40004C4")]
	[FieldOffset(Offset = "0x1C")]
	public int[] RoundCountConfig;

	[Token(Token = "0x40004C5")]
	[FieldOffset(Offset = "0x20")]
	public uint BombMatchMaxTime;

	[Token(Token = "0x600057F")]
	[Address(RVA = "0x180CE98", Offset = "0x180CE98", VA = "0x180CE98")]
	public BombModeConfigData()
	{
	}

	[Token(Token = "0x6000580")]
	[Address(RVA = "0x180CF1C", Offset = "0x180CF1C", VA = "0x180CF1C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000581")]
	[Address(RVA = "0x180CF94", Offset = "0x180CF94", VA = "0x180CF94", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
