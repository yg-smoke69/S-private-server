using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AAE")]
public class FlashStoreGoodsDesc
{
	[Token(Token = "0x400A7C1")]
	[FieldOffset(Offset = "0x8")]
	public uint flash_store_id;

	[Token(Token = "0x400A7C2")]
	[FieldOffset(Offset = "0xC")]
	public uint store_id;

	[Token(Token = "0x400A7C3")]
	[FieldOffset(Offset = "0x10")]
	public uint sort_id;

	[Token(Token = "0x400A7C4")]
	[FieldOffset(Offset = "0x14")]
	public uint item_type;

	[Token(Token = "0x400A7C5")]
	[FieldOffset(Offset = "0x18")]
	public uint item_id;

	[Token(Token = "0x400A7C6")]
	[FieldOffset(Offset = "0x1C")]
	public uint item_num;

	[Token(Token = "0x400A7C7")]
	[FieldOffset(Offset = "0x20")]
	public uint item_duration;

	[Token(Token = "0x400A7C8")]
	[FieldOffset(Offset = "0x24")]
	public uint type_override;

	[Token(Token = "0x400A7C9")]
	[FieldOffset(Offset = "0x28")]
	public uint gem_price;

	[Token(Token = "0x400A7CA")]
	[FieldOffset(Offset = "0x2C")]
	public uint flash_gem_price;

	[Token(Token = "0x400A7CB")]
	[FieldOffset(Offset = "0x30")]
	public long added_time;

	[Token(Token = "0x400A7CC")]
	[FieldOffset(Offset = "0x38")]
	public long expire_time;

	[Token(Token = "0x400A7CD")]
	[FieldOffset(Offset = "0x40")]
	public uint tag_type;

	[Token(Token = "0x400A7CE")]
	[FieldOffset(Offset = "0x44")]
	public uint limited_purchase_times;

	[Token(Token = "0x400A7CF")]
	[FieldOffset(Offset = "0x48")]
	public bool is_recommended;

	[Token(Token = "0x600810B")]
	[Address(RVA = "0x30A0E60", Offset = "0x30A0E60", VA = "0x30A0E60")]
	public FlashStoreGoodsDesc()
	{
	}
}
