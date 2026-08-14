using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000159")]
public class InfectionZombieGrowUpData : CSVBaseData
{
	[Token(Token = "0x40008B4")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x40008B5")]
	[FieldOffset(Offset = "0xC")]
	public uint ZombieType;

	[Token(Token = "0x40008B6")]
	[FieldOffset(Offset = "0x10")]
	public uint ZombieLevel;

	[Token(Token = "0x40008B7")]
	[FieldOffset(Offset = "0x14")]
	public float Speed;

	[Token(Token = "0x40008B8")]
	[FieldOffset(Offset = "0x18")]
	public float JumpHeight;

	[Token(Token = "0x6000817")]
	[Address(RVA = "0x2C780C4", Offset = "0x2C780C4", VA = "0x2C780C4")]
	public InfectionZombieGrowUpData()
	{
	}

	[Token(Token = "0x6000818")]
	[Address(RVA = "0x2C78148", Offset = "0x2C78148", VA = "0x2C78148", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000819")]
	[Address(RVA = "0x2C781AC", Offset = "0x2C781AC", VA = "0x2C781AC", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
