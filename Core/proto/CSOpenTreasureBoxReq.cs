using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015DE")]
public class CSOpenTreasureBoxReq
{
	[Token(Token = "0x400946A")]
	[FieldOffset(Offset = "0x8")]
	public uint treasure_id;

	[Token(Token = "0x400946B")]
	[FieldOffset(Offset = "0x10")]
	public ulong trans_id;

	[Token(Token = "0x400946C")]
	[FieldOffset(Offset = "0x18")]
	public ETreasureBox.BoxType box_type;

	[Token(Token = "0x400946D")]
	[FieldOffset(Offset = "0x1C")]
	public bool can_get_unique;

	[Token(Token = "0x400946E")]
	[FieldOffset(Offset = "0x20")]
	public uint item_cnt;

	[Token(Token = "0x400946F")]
	[FieldOffset(Offset = "0x24")]
	public bool is_crate_treasure;

	[Token(Token = "0x4009470")]
	[FieldOffset(Offset = "0x25")]
	public bool is_auto_open;

	[Token(Token = "0x6007C28")]
	[Address(RVA = "0x30982A0", Offset = "0x30982A0", VA = "0x30982A0")]
	public CSOpenTreasureBoxReq()
	{
	}
}
