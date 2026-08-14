using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001ABB")]
public class InstallmentStoreDesc
{
	[Token(Token = "0x400A844")]
	[FieldOffset(Offset = "0x8")]
	public uint sort_id;

	[Token(Token = "0x400A845")]
	[FieldOffset(Offset = "0xC")]
	public uint item_id;

	[Token(Token = "0x400A846")]
	[FieldOffset(Offset = "0x10")]
	public long added_time;

	[Token(Token = "0x400A847")]
	[FieldOffset(Offset = "0x18")]
	public long expire_time;

	[Token(Token = "0x400A848")]
	[FieldOffset(Offset = "0x20")]
	public uint gems_price;

	[Token(Token = "0x400A849")]
	[FieldOffset(Offset = "0x24")]
	public uint deposit_price;

	[Token(Token = "0x400A84A")]
	[FieldOffset(Offset = "0x28")]
	public EInventory.InstallmentType installment_type;

	[Token(Token = "0x400A84B")]
	[FieldOffset(Offset = "0x2C")]
	public uint installment_term;

	[Token(Token = "0x400A84C")]
	[FieldOffset(Offset = "0x30")]
	public uint promp_day;

	[Token(Token = "0x400A84D")]
	[FieldOffset(Offset = "0x34")]
	public string language;

	[Token(Token = "0x400A84E")]
	[FieldOffset(Offset = "0x38")]
	public string image_url;

	[Token(Token = "0x6008118")]
	[Address(RVA = "0x30A3C78", Offset = "0x30A3C78", VA = "0x30A3C78")]
	public InstallmentStoreDesc()
	{
	}
}
