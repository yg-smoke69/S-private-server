using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20014B7")]
public class WorkshopClassicSlotInfo
{
	[Token(Token = "0x4008F92")]
	[FieldOffset(Offset = "0x8")]
	public uint slot_id;

	[Token(Token = "0x4008F93")]
	[FieldOffset(Offset = "0xC")]
	public EWorkshop.SlotState slot_state;

	[Token(Token = "0x4008F94")]
	[FieldOffset(Offset = "0x10")]
	public string workshop_code;

	[Token(Token = "0x4008F95")]
	[FieldOffset(Offset = "0x14")]
	public WorkshopBasicInfo workshop_basic_info;

	[Token(Token = "0x6007B18")]
	[Address(RVA = "0x33E60E0", Offset = "0x33E60E0", VA = "0x33E60E0")]
	public WorkshopClassicSlotInfo()
	{
	}
}
