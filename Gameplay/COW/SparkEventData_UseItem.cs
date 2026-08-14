using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E1E")]
internal class SparkEventData_UseItem : SparkEventData_Base
{
	[Token(Token = "0x400BE68")]
	[FieldOffset(Offset = "0x10")]
	public uint item_id;

	[Token(Token = "0x6008FDE")]
	[Address(RVA = "0x20F60A0", Offset = "0x20F60A0", VA = "0x20F60A0")]
	public SparkEventData_UseItem()
	{
	}

	[Token(Token = "0x6008FDF")]
	[Address(RVA = "0x20F60A8", Offset = "0x20F60A8", VA = "0x20F60A8", Slot = "4")]
	public override string GetEventType()
	{
		return null;
	}
}
