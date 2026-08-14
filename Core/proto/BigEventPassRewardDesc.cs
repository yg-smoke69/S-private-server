using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B9E")]
public class BigEventPassRewardDesc
{
	[Token(Token = "0x400ADBD")]
	[FieldOffset(Offset = "0x8")]
	public uint event_id;

	[Token(Token = "0x400ADBE")]
	[FieldOffset(Offset = "0xC")]
	public uint id;

	[Token(Token = "0x400ADBF")]
	[FieldOffset(Offset = "0x10")]
	public uint big_event_badge_id;

	[Token(Token = "0x400ADC0")]
	[FieldOffset(Offset = "0x14")]
	public uint required_badge_num;

	[Token(Token = "0x400ADC1")]
	[FieldOffset(Offset = "0x18")]
	public bool is_elite_award;

	[Token(Token = "0x400ADC2")]
	[FieldOffset(Offset = "0x1C")]
	public BigEventEPAward reward;

	[Token(Token = "0x400ADC3")]
	[FieldOffset(Offset = "0x20")]
	public string award_cdn_url;

	[Token(Token = "0x60081F9")]
	[Address(RVA = "0x317C250", Offset = "0x317C250", VA = "0x317C250")]
	public BigEventPassRewardDesc()
	{
	}
}
