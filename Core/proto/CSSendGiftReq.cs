using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200172A")]
public class CSSendGiftReq
{
	[Token(Token = "0x4009968")]
	[FieldOffset(Offset = "0x8")]
	public ulong[] receiver_account_ids;

	[Token(Token = "0x4009969")]
	[FieldOffset(Offset = "0xC")]
	public EGiftStore_BuddyType buddy_type;

	[Token(Token = "0x400996A")]
	[FieldOffset(Offset = "0x10")]
	public uint commodity_id;

	[Token(Token = "0x400996B")]
	[FieldOffset(Offset = "0x14")]
	public string message_content;

	[Token(Token = "0x400996C")]
	[FieldOffset(Offset = "0x18")]
	public EInventory.CurrencyType currency_type;

	[Token(Token = "0x400996D")]
	[FieldOffset(Offset = "0x20")]
	public ulong clan_id;

	[Token(Token = "0x400996E")]
	[FieldOffset(Offset = "0x28")]
	public uint commodity_cnt;

	[Token(Token = "0x400996F")]
	[FieldOffset(Offset = "0x2C")]
	public uint voucher_id;

	[Token(Token = "0x6007D84")]
	[Address(RVA = "0x3099784", Offset = "0x3099784", VA = "0x3099784")]
	public CSSendGiftReq()
	{
	}
}
