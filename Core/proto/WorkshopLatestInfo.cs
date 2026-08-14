using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20014B9")]
public class WorkshopLatestInfo
{
	[Token(Token = "0x4008F9B")]
	[FieldOffset(Offset = "0x8")]
	public WorkshopBasicInfo workshop_basic_info;

	[Token(Token = "0x4008F9C")]
	[FieldOffset(Offset = "0xC")]
	public EWorkshop.SlotState slot_state;

	[Token(Token = "0x4008F9D")]
	[FieldOffset(Offset = "0x10")]
	public string workshop_code;

	[Token(Token = "0x4008F9E")]
	[FieldOffset(Offset = "0x18")]
	public long play_at;

	[Token(Token = "0x6007B1A")]
	[Address(RVA = "0x33E65E0", Offset = "0x33E65E0", VA = "0x33E65E0")]
	public WorkshopLatestInfo()
	{
	}
}
