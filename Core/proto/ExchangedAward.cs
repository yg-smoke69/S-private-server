using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001359")]
public class ExchangedAward
{
	[Token(Token = "0x40088AF")]
	[FieldOffset(Offset = "0x8")]
	public EInventory.AwardType origin_award_type;

	[Token(Token = "0x40088B0")]
	[FieldOffset(Offset = "0xC")]
	public uint origin_award_id;

	[Token(Token = "0x40088B1")]
	[FieldOffset(Offset = "0x10")]
	public uint origin_award_num;

	[Token(Token = "0x40088B2")]
	[FieldOffset(Offset = "0x14")]
	public EInventory.AwardType dest_award_type;

	[Token(Token = "0x40088B3")]
	[FieldOffset(Offset = "0x18")]
	public uint dest_award_id;

	[Token(Token = "0x40088B4")]
	[FieldOffset(Offset = "0x1C")]
	public uint dest_award_num;

	[Token(Token = "0x40088B5")]
	[FieldOffset(Offset = "0x20")]
	public uint origin_award_time;

	[Token(Token = "0x6007A5A")]
	[Address(RVA = "0x30A0044", Offset = "0x30A0044", VA = "0x30A0044")]
	public ExchangedAward()
	{
	}
}
