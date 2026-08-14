using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B9F")]
public class BigEventEPAward
{
	[Token(Token = "0x400ADC4")]
	[FieldOffset(Offset = "0x8")]
	public EInventory.AwardType award_type;

	[Token(Token = "0x400ADC5")]
	[FieldOffset(Offset = "0xC")]
	public uint award_id;

	[Token(Token = "0x400ADC6")]
	[FieldOffset(Offset = "0x10")]
	public uint award_num;

	[Token(Token = "0x400ADC7")]
	[FieldOffset(Offset = "0x14")]
	public uint award_time;

	[Token(Token = "0x60081FA")]
	[Address(RVA = "0x317BE5C", Offset = "0x317BE5C", VA = "0x317BE5C")]
	public BigEventEPAward()
	{
	}
}
