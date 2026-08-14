using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BE3")]
public class LimitedChestTypeDesc
{
	[Token(Token = "0x400AF6E")]
	[FieldOffset(Offset = "0x8")]
	public uint chest_id;

	[Token(Token = "0x400AF6F")]
	[FieldOffset(Offset = "0xC")]
	public uint chest_sub_id;

	[Token(Token = "0x400AF70")]
	[FieldOffset(Offset = "0x10")]
	public ELottery.Type type;

	[Token(Token = "0x400AF71")]
	[FieldOffset(Offset = "0x14")]
	public uint open_priority_switch;

	[Token(Token = "0x400AF72")]
	[FieldOffset(Offset = "0x18")]
	public uint priority;

	[Token(Token = "0x400AF73")]
	[FieldOffset(Offset = "0x20")]
	public long start_time_stamp;

	[Token(Token = "0x400AF74")]
	[FieldOffset(Offset = "0x28")]
	public long end_time_stamp;

	[Token(Token = "0x400AF75")]
	[FieldOffset(Offset = "0x30")]
	public string chest_name;

	[Token(Token = "0x400AF76")]
	[FieldOffset(Offset = "0x34")]
	public uint[] jackpot;

	[Token(Token = "0x400AF77")]
	[FieldOffset(Offset = "0x38")]
	public bool drop_probability_switch;

	[Token(Token = "0x400AF78")]
	[FieldOffset(Offset = "0x40")]
	public long drop_up_start_time;

	[Token(Token = "0x400AF79")]
	[FieldOffset(Offset = "0x48")]
	public long drop_up_end_time;

	[Token(Token = "0x400AF7A")]
	[FieldOffset(Offset = "0x50")]
	public bool melonpi_switch;

	[Token(Token = "0x600823E")]
	[Address(RVA = "0x30A4954", Offset = "0x30A4954", VA = "0x30A4954")]
	public LimitedChestTypeDesc()
	{
	}
}
