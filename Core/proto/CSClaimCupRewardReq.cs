using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001592")]
public class CSClaimCupRewardReq
{
	[Token(Token = "0x4009391")]
	[FieldOffset(Offset = "0x8")]
	public uint cup_type;

	[Token(Token = "0x4009392")]
	[FieldOffset(Offset = "0xC")]
	public uint cup_id;

	[Token(Token = "0x6007BDA")]
	[Address(RVA = "0x317E588", Offset = "0x317E588", VA = "0x317E588")]
	public CSClaimCupRewardReq()
	{
	}
}
