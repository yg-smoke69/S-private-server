using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20013FF")]
public class AwardTypeProbability
{
	[Token(Token = "0x4008BDF")]
	[FieldOffset(Offset = "0x8")]
	public EInventory.AwardType award_type;

	[Token(Token = "0x4008BE0")]
	[FieldOffset(Offset = "0xC")]
	public uint award_num;

	[Token(Token = "0x4008BE1")]
	[FieldOffset(Offset = "0x10")]
	public uint probability;

	[Token(Token = "0x6007AD5")]
	[Address(RVA = "0x317B510", Offset = "0x317B510", VA = "0x317B510")]
	public AwardTypeProbability()
	{
	}
}
