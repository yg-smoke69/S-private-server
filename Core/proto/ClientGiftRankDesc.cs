using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200173B")]
public class ClientGiftRankDesc
{
	[Token(Token = "0x40099A4")]
	[FieldOffset(Offset = "0x8")]
	public uint rank_id;

	[Token(Token = "0x40099A5")]
	[FieldOffset(Offset = "0xC")]
	public string rank_name;

	[Token(Token = "0x40099A6")]
	[FieldOffset(Offset = "0x10")]
	public long open_time;

	[Token(Token = "0x40099A7")]
	[FieldOffset(Offset = "0x18")]
	public long close_time;

	[Token(Token = "0x40099A8")]
	[FieldOffset(Offset = "0x20")]
	public bool is_time_show;

	[Token(Token = "0x40099A9")]
	[FieldOffset(Offset = "0x24")]
	public uint giver_item_id;

	[Token(Token = "0x40099AA")]
	[FieldOffset(Offset = "0x28")]
	public uint receiver_item_id;

	[Token(Token = "0x40099AB")]
	[FieldOffset(Offset = "0x2C")]
	public uint gift_ratio;

	[Token(Token = "0x6007D95")]
	[Address(RVA = "0x309C774", Offset = "0x309C774", VA = "0x309C774")]
	public ClientGiftRankDesc()
	{
	}
}
