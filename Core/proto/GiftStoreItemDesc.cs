using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AA7")]
public class GiftStoreItemDesc
{
	[Token(Token = "0x400A772")]
	[FieldOffset(Offset = "0x8")]
	public uint store_id;

	[Token(Token = "0x400A773")]
	[FieldOffset(Offset = "0xC")]
	public uint commodity_id;

	[Token(Token = "0x400A774")]
	[FieldOffset(Offset = "0x10")]
	public uint sort_id;

	[Token(Token = "0x400A775")]
	[FieldOffset(Offset = "0x14")]
	public uint item_id;

	[Token(Token = "0x400A776")]
	[FieldOffset(Offset = "0x18")]
	public uint coins_price;

	[Token(Token = "0x400A777")]
	[FieldOffset(Offset = "0x1C")]
	public uint gems_price;

	[Token(Token = "0x400A778")]
	[FieldOffset(Offset = "0x20")]
	public uint tag_type;

	[Token(Token = "0x400A779")]
	[FieldOffset(Offset = "0x24")]
	public uint tag_value;

	[Token(Token = "0x400A77A")]
	[FieldOffset(Offset = "0x28")]
	public EInventory.AwardType return_type;

	[Token(Token = "0x400A77B")]
	[FieldOffset(Offset = "0x2C")]
	public uint return_id;

	[Token(Token = "0x400A77C")]
	[FieldOffset(Offset = "0x30")]
	public uint return_num;

	[Token(Token = "0x400A77D")]
	[FieldOffset(Offset = "0x34")]
	public string added_time;

	[Token(Token = "0x400A77E")]
	[FieldOffset(Offset = "0x38")]
	public string expire_time;

	[Token(Token = "0x400A77F")]
	[FieldOffset(Offset = "0x3C")]
	public uint type_override;

	[Token(Token = "0x400A780")]
	[FieldOffset(Offset = "0x40")]
	public bool is_original_type_remain;

	[Token(Token = "0x400A781")]
	[FieldOffset(Offset = "0x41")]
	public bool is_exclusive;

	[Token(Token = "0x400A782")]
	[FieldOffset(Offset = "0x44")]
	public string image_url;

	[Token(Token = "0x400A783")]
	[FieldOffset(Offset = "0x48")]
	public bool is_quick_gift_recommended;

	[Token(Token = "0x400A784")]
	[FieldOffset(Offset = "0x4C")]
	public uint award_time;

	[Token(Token = "0x400A785")]
	[FieldOffset(Offset = "0x50")]
	public long expire_timestamp;

	[Token(Token = "0x6008104")]
	[Address(RVA = "0x30A26A0", Offset = "0x30A26A0", VA = "0x30A26A0")]
	public GiftStoreItemDesc()
	{
	}
}
