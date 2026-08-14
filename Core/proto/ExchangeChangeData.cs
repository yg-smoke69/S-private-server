using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200135A")]
public class ExchangeChangeData
{
	[Token(Token = "0x40088B6")]
	[FieldOffset(Offset = "0x8")]
	public ulong trans_id;

	[Token(Token = "0x40088B7")]
	[FieldOffset(Offset = "0x10")]
	public List<Item> add_item_list;

	[Token(Token = "0x40088B8")]
	[FieldOffset(Offset = "0x14")]
	public List<Item> del_item_list;

	[Token(Token = "0x40088B9")]
	[FieldOffset(Offset = "0x18")]
	public int coins_delta;

	[Token(Token = "0x40088BA")]
	[FieldOffset(Offset = "0x1C")]
	public int gems_delta;

	[Token(Token = "0x40088BB")]
	[FieldOffset(Offset = "0x20")]
	public int gop_gems_delta;

	[Token(Token = "0x40088BC")]
	[FieldOffset(Offset = "0x24")]
	public EInventory.TransReason reason;

	[Token(Token = "0x40088BD")]
	[FieldOffset(Offset = "0x28")]
	public uint sub_reason;

	[Token(Token = "0x40088BE")]
	[FieldOffset(Offset = "0x2C")]
	public uint gop_gems;

	[Token(Token = "0x40088BF")]
	[FieldOffset(Offset = "0x30")]
	public ulong gop_total_topup;

	[Token(Token = "0x40088C0")]
	[FieldOffset(Offset = "0x38")]
	public ulong gop_total_free;

	[Token(Token = "0x40088C1")]
	[FieldOffset(Offset = "0x40")]
	public List<ExchangedAward> exchangeAward;

	[Token(Token = "0x40088C2")]
	[FieldOffset(Offset = "0x44")]
	public bool check_bundle;

	[Token(Token = "0x6007A5B")]
	[Address(RVA = "0x309FBC8", Offset = "0x309FBC8", VA = "0x309FBC8")]
	public ExchangeChangeData()
	{
	}
}
