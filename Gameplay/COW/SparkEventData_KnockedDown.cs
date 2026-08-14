using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E18")]
internal class SparkEventData_KnockedDown : SparkEventData_Base
{
	[Token(Token = "0x400BE60")]
	[FieldOffset(Offset = "0x10")]
	public ulong from_account_id;

	[Token(Token = "0x400BE61")]
	[FieldOffset(Offset = "0x18")]
	public int weapon_id;

	[Token(Token = "0x6008FD2")]
	[Address(RVA = "0x20F593C", Offset = "0x20F593C", VA = "0x20F593C")]
	public SparkEventData_KnockedDown()
	{
	}

	[Token(Token = "0x6008FD3")]
	[Address(RVA = "0x20F5944", Offset = "0x20F5944", VA = "0x20F5944", Slot = "4")]
	public override string GetEventType()
	{
		return null;
	}
}
