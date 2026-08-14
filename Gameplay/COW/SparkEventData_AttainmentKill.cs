using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E16")]
internal class SparkEventData_AttainmentKill : SparkEventData_Base
{
	[Token(Token = "0x400BE5D")]
	[FieldOffset(Offset = "0x10")]
	public ulong account_id;

	[Token(Token = "0x6008FCE")]
	[Address(RVA = "0x20F5078", Offset = "0x20F5078", VA = "0x20F5078")]
	public SparkEventData_AttainmentKill()
	{
	}

	[Token(Token = "0x6008FCF")]
	[Address(RVA = "0x20F5088", Offset = "0x20F5088", VA = "0x20F5088", Slot = "4")]
	public override string GetEventType()
	{
		return null;
	}
}
