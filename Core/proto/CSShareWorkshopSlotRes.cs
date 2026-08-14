using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018E3")]
public class CSShareWorkshopSlotRes
{
	[Token(Token = "0x4009E1B")]
	[FieldOffset(Offset = "0x8")]
	public uint slot_id;

	[Token(Token = "0x4009E1C")]
	[FieldOffset(Offset = "0xC")]
	public string workshop_code;

	[Token(Token = "0x4009E1D")]
	[FieldOffset(Offset = "0x10")]
	public long update_time;

	[Token(Token = "0x4009E1E")]
	[FieldOffset(Offset = "0x18")]
	public uint reward_general_times;

	[Token(Token = "0x4009E1F")]
	[FieldOffset(Offset = "0x1C")]
	public uint remain_reward_count;

	[Token(Token = "0x6007F3C")]
	[Address(RVA = "0x3099C14", Offset = "0x3099C14", VA = "0x3099C14")]
	public CSShareWorkshopSlotRes()
	{
	}
}
