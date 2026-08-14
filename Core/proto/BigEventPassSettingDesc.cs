using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B9D")]
public class BigEventPassSettingDesc
{
	[Token(Token = "0x400ADAE")]
	[FieldOffset(Offset = "0x8")]
	public uint event_id;

	[Token(Token = "0x400ADAF")]
	[FieldOffset(Offset = "0xC")]
	public uint big_event_badge_id;

	[Token(Token = "0x400ADB0")]
	[FieldOffset(Offset = "0x10")]
	public EInventory.AwardType badge_exchange_item_type;

	[Token(Token = "0x400ADB1")]
	[FieldOffset(Offset = "0x14")]
	public uint badge_exchange_item_id;

	[Token(Token = "0x400ADB2")]
	[FieldOffset(Offset = "0x18")]
	public uint badge_exchange_rate;

	[Token(Token = "0x400ADB3")]
	[FieldOffset(Offset = "0x1C")]
	public uint cost_gems;

	[Token(Token = "0x400ADB4")]
	[FieldOffset(Offset = "0x20")]
	public uint show_gem_price;

	[Token(Token = "0x400ADB5")]
	[FieldOffset(Offset = "0x24")]
	public uint show_discount;

	[Token(Token = "0x400ADB6")]
	[FieldOffset(Offset = "0x28")]
	public List<BigEventEPAward> rewards;

	[Token(Token = "0x400ADB7")]
	[FieldOffset(Offset = "0x2C")]
	public string default_reward_cdn;

	[Token(Token = "0x400ADB8")]
	[FieldOffset(Offset = "0x30")]
	public uint show_grand_reward;

	[Token(Token = "0x400ADB9")]
	[FieldOffset(Offset = "0x34")]
	public string show_special_reward;

	[Token(Token = "0x400ADBA")]
	[FieldOffset(Offset = "0x38")]
	public uint max_badge_exchange;

	[Token(Token = "0x400ADBB")]
	[FieldOffset(Offset = "0x3C")]
	public string show_ep_reward_cdn_url;

	[Token(Token = "0x400ADBC")]
	[FieldOffset(Offset = "0x40")]
	public EInventory.AwardType big_event_badge_type;

	[Token(Token = "0x60081F8")]
	[Address(RVA = "0x317C2F0", Offset = "0x317C2F0", VA = "0x317C2F0")]
	public BigEventPassSettingDesc()
	{
	}
}
