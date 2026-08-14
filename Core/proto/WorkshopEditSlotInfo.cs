using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20014B4")]
public class WorkshopEditSlotInfo
{
	[Token(Token = "0x4008F87")]
	[FieldOffset(Offset = "0x8")]
	public uint slot_id;

	[Token(Token = "0x4008F88")]
	[FieldOffset(Offset = "0xC")]
	public EWorkshop.SlotState slot_state;

	[Token(Token = "0x4008F89")]
	[FieldOffset(Offset = "0x10")]
	public WorkshopBasicInfo workshop_basic_info;

	[Token(Token = "0x6007B15")]
	[Address(RVA = "0x33E6224", Offset = "0x33E6224", VA = "0x33E6224")]
	public WorkshopEditSlotInfo()
	{
	}
}
