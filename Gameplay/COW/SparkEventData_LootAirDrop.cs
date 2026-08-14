using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E1B")]
internal class SparkEventData_LootAirDrop : SparkEventData_Base
{
	[Token(Token = "0x400BE65")]
	[FieldOffset(Offset = "0x10")]
	public uint[] item_ids;

	[Token(Token = "0x6008FD8")]
	[Address(RVA = "0x20F5A94", Offset = "0x20F5A94", VA = "0x20F5A94")]
	public SparkEventData_LootAirDrop()
	{
	}

	[Token(Token = "0x6008FD9")]
	[Address(RVA = "0x20F5A9C", Offset = "0x20F5A9C", VA = "0x20F5A9C", Slot = "4")]
	public override string GetEventType()
	{
		return null;
	}
}
