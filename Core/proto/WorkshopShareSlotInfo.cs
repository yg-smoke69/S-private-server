using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20014B5")]
public class WorkshopShareSlotInfo
{
	[Token(Token = "0x4008F8A")]
	[FieldOffset(Offset = "0x8")]
	public uint slot_id;

	[Token(Token = "0x4008F8B")]
	[FieldOffset(Offset = "0xC")]
	public EWorkshop.SlotState slot_state;

	[Token(Token = "0x4008F8C")]
	[FieldOffset(Offset = "0x10")]
	public string workshop_code;

	[Token(Token = "0x4008F8D")]
	[FieldOffset(Offset = "0x14")]
	public WorkshopBasicInfo workshop_basic_info;

	[Token(Token = "0x6007B16")]
	[Address(RVA = "0x33E69A0", Offset = "0x33E69A0", VA = "0x33E69A0")]
	public WorkshopShareSlotInfo()
	{
	}
}
