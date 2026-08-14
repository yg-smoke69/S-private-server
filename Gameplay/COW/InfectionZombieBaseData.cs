using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000158")]
public class InfectionZombieBaseData : CSVBaseData
{
	[Token(Token = "0x40008B0")]
	[FieldOffset(Offset = "0x8")]
	public uint ZombieType;

	[Token(Token = "0x40008B1")]
	[FieldOffset(Offset = "0xC")]
	public string Name;

	[Token(Token = "0x40008B2")]
	[FieldOffset(Offset = "0x10")]
	public ResourceID IconRes;

	[Token(Token = "0x40008B3")]
	[FieldOffset(Offset = "0x14")]
	public ResourceID EffectRes;

	[Token(Token = "0x6000814")]
	[Address(RVA = "0x2C77DE4", Offset = "0x2C77DE4", VA = "0x2C77DE4")]
	public InfectionZombieBaseData()
	{
	}

	[Token(Token = "0x6000815")]
	[Address(RVA = "0x2C77E68", Offset = "0x2C77E68", VA = "0x2C77E68", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000816")]
	[Address(RVA = "0x2C77ECC", Offset = "0x2C77ECC", VA = "0x2C77ECC", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
