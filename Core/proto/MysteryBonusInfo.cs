using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015BC")]
public class MysteryBonusInfo
{
	[Token(Token = "0x4009425")]
	[FieldOffset(Offset = "0x8")]
	public uint bonus_max;

	[Token(Token = "0x4009426")]
	[FieldOffset(Offset = "0xC")]
	public string start_time;

	[Token(Token = "0x4009427")]
	[FieldOffset(Offset = "0x10")]
	public string end_time;

	[Token(Token = "0x4009428")]
	[FieldOffset(Offset = "0x14")]
	public uint start_time_stamp;

	[Token(Token = "0x4009429")]
	[FieldOffset(Offset = "0x18")]
	public uint end_time_stamp;

	[Token(Token = "0x400942A")]
	[FieldOffset(Offset = "0x1C")]
	public uint bonus_percent;

	[Token(Token = "0x400942B")]
	[FieldOffset(Offset = "0x20")]
	public uint bonus_topup_times;

	[Token(Token = "0x6007C06")]
	[Address(RVA = "0x30A9588", Offset = "0x30A9588", VA = "0x30A9588")]
	public MysteryBonusInfo()
	{
	}
}
