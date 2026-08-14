using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E12")]
internal class SparkEventData_KillTeamLastOne : SparkEventData_Base
{
	[Token(Token = "0x400BE56")]
	[FieldOffset(Offset = "0x10")]
	public ulong account_id;

	[Token(Token = "0x400BE57")]
	[FieldOffset(Offset = "0x18")]
	public int weapon_id;

	[Token(Token = "0x6008FC6")]
	[Address(RVA = "0x20F57E4", Offset = "0x20F57E4", VA = "0x20F57E4")]
	public SparkEventData_KillTeamLastOne()
	{
	}

	[Token(Token = "0x6008FC7")]
	[Address(RVA = "0x20F57EC", Offset = "0x20F57EC", VA = "0x20F57EC", Slot = "4")]
	public override string GetEventType()
	{
		return null;
	}
}
