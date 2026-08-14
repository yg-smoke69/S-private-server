using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E1C")]
internal class SparkEventData_LootPlayer : SparkEventData_Base
{
	[Token(Token = "0x400BE66")]
	[FieldOffset(Offset = "0x10")]
	public uint[] item_ids;

	[Token(Token = "0x6008FDA")]
	[Address(RVA = "0x20F5B40", Offset = "0x20F5B40", VA = "0x20F5B40")]
	public SparkEventData_LootPlayer()
	{
	}

	[Token(Token = "0x6008FDB")]
	[Address(RVA = "0x20F5B48", Offset = "0x20F5B48", VA = "0x20F5B48", Slot = "4")]
	public override string GetEventType()
	{
		return null;
	}
}
