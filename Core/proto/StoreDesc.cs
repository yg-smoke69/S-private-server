using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200199D")]
public class StoreDesc
{
	[Token(Token = "0x400A095")]
	[FieldOffset(Offset = "0x8")]
	public uint store_id;

	[Token(Token = "0x400A096")]
	[FieldOffset(Offset = "0xC")]
	public uint sort_id;

	[Token(Token = "0x400A097")]
	[FieldOffset(Offset = "0x10")]
	public uint item_id;

	[Token(Token = "0x400A098")]
	[FieldOffset(Offset = "0x14")]
	public string added_time;

	[Token(Token = "0x400A099")]
	[FieldOffset(Offset = "0x18")]
	public string expire_time;

	[Token(Token = "0x400A09A")]
	[FieldOffset(Offset = "0x1C")]
	public string name;

	[Token(Token = "0x400A09B")]
	[FieldOffset(Offset = "0x20")]
	public string desc;

	[Token(Token = "0x400A09C")]
	[FieldOffset(Offset = "0x24")]
	public uint coins_price;

	[Token(Token = "0x400A09D")]
	[FieldOffset(Offset = "0x28")]
	public uint gems_price;

	[Token(Token = "0x400A09E")]
	[FieldOffset(Offset = "0x2C")]
	public EInventory.StoreTag tag_type;

	[Token(Token = "0x400A09F")]
	[FieldOffset(Offset = "0x30")]
	public uint tag_value;

	[Token(Token = "0x400A0A0")]
	[FieldOffset(Offset = "0x34")]
	public uint limited_purchase_times;

	[Token(Token = "0x400A0A1")]
	[FieldOffset(Offset = "0x38")]
	public uint purchase_times;

	[Token(Token = "0x400A0A2")]
	[FieldOffset(Offset = "0x3C")]
	public bool is_new;

	[Token(Token = "0x400A0A3")]
	[FieldOffset(Offset = "0x40")]
	public string type_override;

	[Token(Token = "0x400A0A4")]
	[FieldOffset(Offset = "0x44")]
	public bool is_original_type_remain;

	[Token(Token = "0x400A0A5")]
	[FieldOffset(Offset = "0x45")]
	public bool is_recommended;

	[Token(Token = "0x400A0A6")]
	[FieldOffset(Offset = "0x48")]
	public string image_url;

	[Token(Token = "0x400A0A7")]
	[FieldOffset(Offset = "0x4C")]
	public string language;

	[Token(Token = "0x400A0A8")]
	[FieldOffset(Offset = "0x50")]
	public bool is_vfx;

	[Token(Token = "0x400A0A9")]
	[FieldOffset(Offset = "0x54")]
	public string real_image_url;

	[Token(Token = "0x400A0AA")]
	[FieldOffset(Offset = "0x58")]
	public uint discount_price;

	[Token(Token = "0x400A0AB")]
	[FieldOffset(Offset = "0x60")]
	public long discount_start_time;

	[Token(Token = "0x400A0AC")]
	[FieldOffset(Offset = "0x68")]
	public long discount_end_time;

	[Token(Token = "0x400A0AD")]
	[FieldOffset(Offset = "0x70")]
	public uint award_time;

	[Token(Token = "0x400A0AE")]
	[FieldOffset(Offset = "0x78")]
	public long expire_timestamp;

	[Token(Token = "0x400A0AF")]
	[FieldOffset(Offset = "0x80")]
	public uint go_pos_type;

	[Token(Token = "0x400A0B0")]
	[FieldOffset(Offset = "0x84")]
	public uint go_pos;

	[Token(Token = "0x400A0B1")]
	[FieldOffset(Offset = "0x88")]
	public string sub_go_pos;

	[Token(Token = "0x400A0B2")]
	[FieldOffset(Offset = "0x8C")]
	public uint award_num;

	[Token(Token = "0x6007FF4")]
	[Address(RVA = "0x33E283C", Offset = "0x33E283C", VA = "0x33E283C")]
	public StoreDesc()
	{
	}
}
