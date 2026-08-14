using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001703")]
public class RewardStatus
{
	[Token(Token = "0x4009834")]
	[FieldOffset(Offset = "0x8")]
	public uint unlock_id;

	[Token(Token = "0x4009835")]
	[FieldOffset(Offset = "0xC")]
	public EPTarget_Status status;

	[Token(Token = "0x4009836")]
	[FieldOffset(Offset = "0x10")]
	public uint is_ep;

	[Token(Token = "0x6007D5D")]
	[Address(RVA = "0x33E1B44", Offset = "0x33E1B44", VA = "0x33E1B44")]
	public RewardStatus()
	{
	}
}
