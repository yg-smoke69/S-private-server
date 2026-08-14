using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E21")]
internal class SparkEventData_BattlePassLevel : SparkEventData_Base
{
	[Token(Token = "0x400BE6D")]
	[FieldOffset(Offset = "0x10")]
	public uint pass_level;

	[Token(Token = "0x400BE6E")]
	[FieldOffset(Offset = "0x14")]
	public bool is_elite;

	[Token(Token = "0x6008FE4")]
	[Address(RVA = "0x20F512C", Offset = "0x20F512C", VA = "0x20F512C")]
	public SparkEventData_BattlePassLevel()
	{
	}

	[Token(Token = "0x6008FE5")]
	[Address(RVA = "0x20F5134", Offset = "0x20F5134", VA = "0x20F5134", Slot = "4")]
	public override string GetEventType()
	{
		return null;
	}
}
