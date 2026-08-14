using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001728")]
public class CSGetGiftStoreRes
{
	[Token(Token = "0x400995D")]
	[FieldOffset(Offset = "0x8")]
	public uint store_id;

	[Token(Token = "0x400995E")]
	[FieldOffset(Offset = "0xC")]
	public uint open_time;

	[Token(Token = "0x400995F")]
	[FieldOffset(Offset = "0x10")]
	public uint close_time;

	[Token(Token = "0x4009960")]
	[FieldOffset(Offset = "0x14")]
	public bool is_time_show;

	[Token(Token = "0x4009961")]
	[FieldOffset(Offset = "0x18")]
	public uint giver_level;

	[Token(Token = "0x4009962")]
	[FieldOffset(Offset = "0x1C")]
	public uint receiver_level;

	[Token(Token = "0x4009963")]
	[FieldOffset(Offset = "0x20")]
	public uint gift_time_limited;

	[Token(Token = "0x4009964")]
	[FieldOffset(Offset = "0x24")]
	public uint gift_num_limited;

	[Token(Token = "0x6007D82")]
	[Address(RVA = "0x3185B0C", Offset = "0x3185B0C", VA = "0x3185B0C")]
	public CSGetGiftStoreRes()
	{
	}
}
