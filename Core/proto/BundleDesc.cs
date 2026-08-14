using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019A1")]
public class BundleDesc
{
	[Token(Token = "0x400A0CB")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400A0CC")]
	[FieldOffset(Offset = "0xC")]
	public EInventory.AwardType award_type;

	[Token(Token = "0x400A0CD")]
	[FieldOffset(Offset = "0x10")]
	public uint award_id;

	[Token(Token = "0x400A0CE")]
	[FieldOffset(Offset = "0x14")]
	public uint award_num;

	[Token(Token = "0x400A0CF")]
	[FieldOffset(Offset = "0x18")]
	public EInventory.AwardType return_type;

	[Token(Token = "0x400A0D0")]
	[FieldOffset(Offset = "0x1C")]
	public uint return_id;

	[Token(Token = "0x400A0D1")]
	[FieldOffset(Offset = "0x20")]
	public uint return_num;

	[Token(Token = "0x400A0D2")]
	[FieldOffset(Offset = "0x24")]
	public bool is_preview;

	[Token(Token = "0x400A0D3")]
	[FieldOffset(Offset = "0x28")]
	public uint preview_avatar;

	[Token(Token = "0x400A0D4")]
	[FieldOffset(Offset = "0x2C")]
	public string image_url;

	[Token(Token = "0x400A0D5")]
	[FieldOffset(Offset = "0x30")]
	public string back_ground_url;

	[Token(Token = "0x400A0D6")]
	[FieldOffset(Offset = "0x34")]
	public uint default_male_role;

	[Token(Token = "0x400A0D7")]
	[FieldOffset(Offset = "0x38")]
	public uint default_female_role;

	[Token(Token = "0x400A0D8")]
	[FieldOffset(Offset = "0x3C")]
	public uint award_time;

	[Token(Token = "0x400A0D9")]
	[FieldOffset(Offset = "0x40")]
	public uint no_forced_open;

	[Token(Token = "0x6007FF8")]
	[Address(RVA = "0x317D54C", Offset = "0x317D54C", VA = "0x317D54C")]
	public BundleDesc()
	{
	}
}
