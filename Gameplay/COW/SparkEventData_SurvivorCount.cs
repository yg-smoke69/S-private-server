using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E22")]
internal class SparkEventData_SurvivorCount : SparkEventData_Base
{
	[Token(Token = "0x400BE6F")]
	[FieldOffset(Offset = "0x10")]
	public int survivor_count;

	[Token(Token = "0x6008FE6")]
	[Address(RVA = "0x20F5F48", Offset = "0x20F5F48", VA = "0x20F5F48")]
	public SparkEventData_SurvivorCount()
	{
	}

	[Token(Token = "0x6008FE7")]
	[Address(RVA = "0x20F5F50", Offset = "0x20F5F50", VA = "0x20F5F50", Slot = "4")]
	public override string GetEventType()
	{
		return null;
	}
}
