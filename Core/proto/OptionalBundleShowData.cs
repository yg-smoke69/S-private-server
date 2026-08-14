using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015B7")]
public class OptionalBundleShowData
{
	[Token(Token = "0x4009410")]
	[FieldOffset(Offset = "0x8")]
	public uint option_order;

	[Token(Token = "0x4009411")]
	[FieldOffset(Offset = "0xC")]
	public EInventory.AwardType award_type;

	[Token(Token = "0x4009412")]
	[FieldOffset(Offset = "0x10")]
	public uint award_id;

	[Token(Token = "0x4009413")]
	[FieldOffset(Offset = "0x14")]
	public uint award_num;

	[Token(Token = "0x4009414")]
	[FieldOffset(Offset = "0x18")]
	public uint award_time;

	[Token(Token = "0x4009415")]
	[FieldOffset(Offset = "0x1C")]
	public EInventory.AwardType return_type;

	[Token(Token = "0x4009416")]
	[FieldOffset(Offset = "0x20")]
	public uint return_id;

	[Token(Token = "0x4009417")]
	[FieldOffset(Offset = "0x24")]
	public uint return_num;

	[Token(Token = "0x4009418")]
	[FieldOffset(Offset = "0x28")]
	public bool is_preview;

	[Token(Token = "0x4009419")]
	[FieldOffset(Offset = "0x2C")]
	public uint preview_avatar;

	[Token(Token = "0x400941A")]
	[FieldOffset(Offset = "0x30")]
	public uint default_male_role;

	[Token(Token = "0x400941B")]
	[FieldOffset(Offset = "0x34")]
	public uint default_female_role;

	[Token(Token = "0x400941C")]
	[FieldOffset(Offset = "0x38")]
	public uint original_price;

	[Token(Token = "0x6007C01")]
	[Address(RVA = "0x33DEDE8", Offset = "0x33DEDE8", VA = "0x33DEDE8")]
	public OptionalBundleShowData()
	{
	}
}
