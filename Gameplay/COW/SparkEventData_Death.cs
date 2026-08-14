using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E17")]
internal class SparkEventData_Death : SparkEventData_Base
{
	[Token(Token = "0x400BE5E")]
	[FieldOffset(Offset = "0x10")]
	public ulong from_account_id;

	[Token(Token = "0x400BE5F")]
	[FieldOffset(Offset = "0x18")]
	public int weapon_id;

	[Token(Token = "0x6008FD0")]
	[Address(RVA = "0x20F5330", Offset = "0x20F5330", VA = "0x20F5330")]
	public SparkEventData_Death()
	{
	}

	[Token(Token = "0x6008FD1")]
	[Address(RVA = "0x20F5338", Offset = "0x20F5338", VA = "0x20F5338", Slot = "4")]
	public override string GetEventType()
	{
		return null;
	}
}
