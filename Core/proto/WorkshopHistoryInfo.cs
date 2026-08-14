using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20014BA")]
public class WorkshopHistoryInfo
{
	[Token(Token = "0x4008F9F")]
	[FieldOffset(Offset = "0x8")]
	public WorkshopBasicInfo workshop_basic_info;

	[Token(Token = "0x4008FA0")]
	[FieldOffset(Offset = "0xC")]
	public EWorkshop.SlotState slot_state;

	[Token(Token = "0x4008FA1")]
	[FieldOffset(Offset = "0x10")]
	public uint play_times;

	[Token(Token = "0x4008FA2")]
	[FieldOffset(Offset = "0x14")]
	public string workshop_code;

	[Token(Token = "0x4008FA3")]
	[FieldOffset(Offset = "0x18")]
	public long latest_play_at;

	[Token(Token = "0x6007B1B")]
	[Address(RVA = "0x33E63DC", Offset = "0x33E63DC", VA = "0x33E63DC")]
	public WorkshopHistoryInfo()
	{
	}
}
