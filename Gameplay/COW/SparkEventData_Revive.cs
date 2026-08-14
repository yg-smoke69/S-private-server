using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E14")]
internal class SparkEventData_Revive : SparkEventData_Base
{
	[Token(Token = "0x400BE5A")]
	[FieldOffset(Offset = "0x10")]
	public ulong account_id;

	[Token(Token = "0x6008FCA")]
	[Address(RVA = "0x20F5D44", Offset = "0x20F5D44", VA = "0x20F5D44")]
	public SparkEventData_Revive()
	{
	}

	[Token(Token = "0x6008FCB")]
	[Address(RVA = "0x20F5D4C", Offset = "0x20F5D4C", VA = "0x20F5D4C", Slot = "4")]
	public override string GetEventType()
	{
		return null;
	}
}
