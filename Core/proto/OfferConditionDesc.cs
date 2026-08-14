using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019BB")]
public class OfferConditionDesc
{
	[Token(Token = "0x400A141")]
	[FieldOffset(Offset = "0x8")]
	public uint offer_id;

	[Token(Token = "0x400A142")]
	[FieldOffset(Offset = "0x10")]
	public long offer_start_time;

	[Token(Token = "0x400A143")]
	[FieldOffset(Offset = "0x18")]
	public long offer_end_time;

	[Token(Token = "0x400A144")]
	[FieldOffset(Offset = "0x20")]
	public uint expend_diamond;

	[Token(Token = "0x400A145")]
	[FieldOffset(Offset = "0x24")]
	public uint offer_chance;

	[Token(Token = "0x400A146")]
	[FieldOffset(Offset = "0x28")]
	public uint offer_appear_time;

	[Token(Token = "0x6008013")]
	[Address(RVA = "0x33DEB64", Offset = "0x33DEB64", VA = "0x33DEB64")]
	public OfferConditionDesc()
	{
	}
}
