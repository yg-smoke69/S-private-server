using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001535")]
public class IngameItem
{
	[Token(Token = "0x4009225")]
	[FieldOffset(Offset = "0x8")]
	public uint itemtable_id;

	[Token(Token = "0x4009226")]
	[FieldOffset(Offset = "0xC")]
	public Item item;

	[Token(Token = "0x4009227")]
	[FieldOffset(Offset = "0x10")]
	public bool reach_daily_limit;

	[Token(Token = "0x4009228")]
	[FieldOffset(Offset = "0x14")]
	public uint daily_limit_cnt;

	[Token(Token = "0x4009229")]
	[FieldOffset(Offset = "0x18")]
	public uint daily_ingame_drop;

	[Token(Token = "0x6007B7D")]
	[Address(RVA = "0x30A3C70", Offset = "0x30A3C70", VA = "0x30A3C70")]
	public IngameItem()
	{
	}
}
