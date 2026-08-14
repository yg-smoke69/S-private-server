using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BD2")]
public class WorkshopSlotUnlockDesc
{
	[Token(Token = "0x400AF0D")]
	[FieldOffset(Offset = "0x8")]
	public uint slot_id;

	[Token(Token = "0x400AF0E")]
	[FieldOffset(Offset = "0xC")]
	public uint cost_item_id;

	[Token(Token = "0x400AF0F")]
	[FieldOffset(Offset = "0x10")]
	public uint cost_item_type;

	[Token(Token = "0x400AF10")]
	[FieldOffset(Offset = "0x14")]
	public uint cost_item_count;

	[Token(Token = "0x600822D")]
	[Address(RVA = "0x33E6A40", Offset = "0x33E6A40", VA = "0x33E6A40")]
	public WorkshopSlotUnlockDesc()
	{
	}
}
