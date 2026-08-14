using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019A2")]
public class OptionalBundleDesc
{
	[Token(Token = "0x400A0DA")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400A0DB")]
	[FieldOffset(Offset = "0xC")]
	public uint option_order;

	[Token(Token = "0x400A0DC")]
	[FieldOffset(Offset = "0x10")]
	public EInventory.AwardType award_type;

	[Token(Token = "0x400A0DD")]
	[FieldOffset(Offset = "0x14")]
	public uint award_id;

	[Token(Token = "0x400A0DE")]
	[FieldOffset(Offset = "0x18")]
	public uint award_num;

	[Token(Token = "0x400A0DF")]
	[FieldOffset(Offset = "0x1C")]
	public uint award_time;

	[Token(Token = "0x400A0E0")]
	[FieldOffset(Offset = "0x20")]
	public EInventory.AwardType return_type;

	[Token(Token = "0x400A0E1")]
	[FieldOffset(Offset = "0x24")]
	public uint return_id;

	[Token(Token = "0x400A0E2")]
	[FieldOffset(Offset = "0x28")]
	public uint return_num;

	[Token(Token = "0x400A0E3")]
	[FieldOffset(Offset = "0x2C")]
	public bool is_preview;

	[Token(Token = "0x400A0E4")]
	[FieldOffset(Offset = "0x30")]
	public uint preview_avatar;

	[Token(Token = "0x400A0E5")]
	[FieldOffset(Offset = "0x34")]
	public uint default_male_role;

	[Token(Token = "0x400A0E6")]
	[FieldOffset(Offset = "0x38")]
	public uint default_female_role;

	[Token(Token = "0x400A0E7")]
	[FieldOffset(Offset = "0x3C")]
	public uint original_price;

	[Token(Token = "0x6007FF9")]
	[Address(RVA = "0x33DED54", Offset = "0x33DED54", VA = "0x33DED54")]
	public OptionalBundleDesc()
	{
	}
}
