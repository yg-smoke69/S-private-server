using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E15")]
internal class SparkEventData_ReviveTeammate : SparkEventData_Base
{
	[Token(Token = "0x400BE5B")]
	[FieldOffset(Offset = "0x10")]
	public ulong reviver_account_id;

	[Token(Token = "0x400BE5C")]
	[FieldOffset(Offset = "0x18")]
	public ulong revived_account_id;

	[Token(Token = "0x6008FCC")]
	[Address(RVA = "0x20F5DF0", Offset = "0x20F5DF0", VA = "0x20F5DF0")]
	public SparkEventData_ReviveTeammate()
	{
	}

	[Token(Token = "0x6008FCD")]
	[Address(RVA = "0x20F5DF8", Offset = "0x20F5DF8", VA = "0x20F5DF8", Slot = "4")]
	public override string GetEventType()
	{
		return null;
	}
}
