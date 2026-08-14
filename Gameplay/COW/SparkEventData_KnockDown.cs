using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E13")]
internal class SparkEventData_KnockDown : SparkEventData_Base
{
	[Token(Token = "0x400BE58")]
	[FieldOffset(Offset = "0x10")]
	public ulong account_id;

	[Token(Token = "0x400BE59")]
	[FieldOffset(Offset = "0x18")]
	public int weapon_id;

	[Token(Token = "0x6008FC8")]
	[Address(RVA = "0x20F5890", Offset = "0x20F5890", VA = "0x20F5890")]
	public SparkEventData_KnockDown()
	{
	}

	[Token(Token = "0x6008FC9")]
	[Address(RVA = "0x20F5898", Offset = "0x20F5898", VA = "0x20F5898", Slot = "4")]
	public override string GetEventType()
	{
		return null;
	}
}
