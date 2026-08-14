using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001400")]
public class CompletionItem
{
	[Token(Token = "0x4008BE2")]
	[FieldOffset(Offset = "0x8")]
	public uint item_id;

	[Token(Token = "0x4008BE3")]
	[FieldOffset(Offset = "0xC")]
	public uint item_type;

	[Token(Token = "0x4008BE4")]
	[FieldOffset(Offset = "0x10")]
	public uint cnt;

	[Token(Token = "0x4008BE5")]
	[FieldOffset(Offset = "0x14")]
	public uint expire_time;

	[Token(Token = "0x4008BE6")]
	[FieldOffset(Offset = "0x18")]
	public uint id;

	[Token(Token = "0x4008BE7")]
	[FieldOffset(Offset = "0x1C")]
	public uint repeat_change_item_id;

	[Token(Token = "0x4008BE8")]
	[FieldOffset(Offset = "0x20")]
	public uint repeat_change_item_type;

	[Token(Token = "0x4008BE9")]
	[FieldOffset(Offset = "0x24")]
	public uint repeat_change_item_num;

	[Token(Token = "0x6007AD6")]
	[Address(RVA = "0x309D718", Offset = "0x309D718", VA = "0x309D718")]
	public CompletionItem()
	{
	}
}
