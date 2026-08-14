using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20014B6")]
public class WorkshopSubscribeSlotInfo
{
	[Token(Token = "0x4008F8E")]
	[FieldOffset(Offset = "0x8")]
	public uint slot_id;

	[Token(Token = "0x4008F8F")]
	[FieldOffset(Offset = "0xC")]
	public EWorkshop.SlotState slot_state;

	[Token(Token = "0x4008F90")]
	[FieldOffset(Offset = "0x10")]
	public string workshop_code;

	[Token(Token = "0x4008F91")]
	[FieldOffset(Offset = "0x14")]
	public WorkshopBasicInfo workshop_basic_info;

	[Token(Token = "0x6007B17")]
	[Address(RVA = "0x33E6A48", Offset = "0x33E6A48", VA = "0x33E6A48")]
	public WorkshopSubscribeSlotInfo()
	{
	}
}
