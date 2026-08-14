using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20014BE")]
public class WorkshopAuthorSlotInfo
{
	[Token(Token = "0x4008FB1")]
	[FieldOffset(Offset = "0x8")]
	public uint slot_id;

	[Token(Token = "0x4008FB2")]
	[FieldOffset(Offset = "0xC")]
	public EWorkshop.SlotState slot_state;

	[Token(Token = "0x4008FB3")]
	[FieldOffset(Offset = "0x10")]
	public string workshop_code;

	[Token(Token = "0x4008FB4")]
	[FieldOffset(Offset = "0x14")]
	public WorkshopBasicInfo workshop_basic_info;

	[Token(Token = "0x6007B1F")]
	[Address(RVA = "0x33E5F88", Offset = "0x33E5F88", VA = "0x33E5F88")]
	public WorkshopAuthorSlotInfo()
	{
	}
}
