using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015B4")]
public class BundleShowData
{
	[Token(Token = "0x40093FE")]
	[FieldOffset(Offset = "0x8")]
	public uint award_id;

	[Token(Token = "0x40093FF")]
	[FieldOffset(Offset = "0xC")]
	public bool is_preview;

	[Token(Token = "0x4009400")]
	[FieldOffset(Offset = "0x10")]
	public uint preview_avatar;

	[Token(Token = "0x4009401")]
	[FieldOffset(Offset = "0x14")]
	public uint award_num;

	[Token(Token = "0x4009402")]
	[FieldOffset(Offset = "0x18")]
	public EInventory.AwardType award_type;

	[Token(Token = "0x4009403")]
	[FieldOffset(Offset = "0x1C")]
	public string image_url;

	[Token(Token = "0x4009404")]
	[FieldOffset(Offset = "0x20")]
	public EInventory.AwardType return_type;

	[Token(Token = "0x4009405")]
	[FieldOffset(Offset = "0x24")]
	public uint return_id;

	[Token(Token = "0x4009406")]
	[FieldOffset(Offset = "0x28")]
	public uint return_num;

	[Token(Token = "0x4009407")]
	[FieldOffset(Offset = "0x2C")]
	public string back_ground_url;

	[Token(Token = "0x4009408")]
	[FieldOffset(Offset = "0x30")]
	public uint default_male_role;

	[Token(Token = "0x4009409")]
	[FieldOffset(Offset = "0x34")]
	public uint default_female_role;

	[Token(Token = "0x400940A")]
	[FieldOffset(Offset = "0x38")]
	public uint award_time;

	[Token(Token = "0x400940B")]
	[FieldOffset(Offset = "0x3C")]
	public uint no_forced_open;

	[Token(Token = "0x6007BFE")]
	[Address(RVA = "0x317D684", Offset = "0x317D684", VA = "0x317D684")]
	public BundleShowData()
	{
	}
}
