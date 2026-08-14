using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E1A")]
internal class SparkEventData_PickUpItem : SparkEventData_Base
{
	[Token(Token = "0x400BE63")]
	[FieldOffset(Offset = "0x10")]
	public uint item_id;

	[Token(Token = "0x400BE64")]
	[FieldOffset(Offset = "0x14")]
	public uint skin_id;

	[Token(Token = "0x6008FD6")]
	[Address(RVA = "0x20F5BEC", Offset = "0x20F5BEC", VA = "0x20F5BEC")]
	public SparkEventData_PickUpItem()
	{
	}

	[Token(Token = "0x6008FD7")]
	[Address(RVA = "0x20F5BF4", Offset = "0x20F5BF4", VA = "0x20F5BF4", Slot = "4")]
	public override string GetEventType()
	{
		return null;
	}
}
