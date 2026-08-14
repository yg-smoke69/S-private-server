using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E19")]
internal class SparkEventData_Revived : SparkEventData_Base
{
	[Token(Token = "0x400BE62")]
	[FieldOffset(Offset = "0x10")]
	public ulong from_account_id;

	[Token(Token = "0x6008FD4")]
	[Address(RVA = "0x20F5E9C", Offset = "0x20F5E9C", VA = "0x20F5E9C")]
	public SparkEventData_Revived()
	{
	}

	[Token(Token = "0x6008FD5")]
	[Address(RVA = "0x20F5EA4", Offset = "0x20F5EA4", VA = "0x20F5EA4", Slot = "4")]
	public override string GetEventType()
	{
		return null;
	}
}
