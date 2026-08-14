using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001399")]
public class PetActionInfo
{
	[Token(Token = "0x4008A21")]
	[FieldOffset(Offset = "0x8")]
	public uint pet_id;

	[Token(Token = "0x4008A22")]
	[FieldOffset(Offset = "0xC")]
	public uint action_id;

	[Token(Token = "0x6007A94")]
	[Address(RVA = "0x33DF57C", Offset = "0x33DF57C", VA = "0x33DF57C")]
	public PetActionInfo()
	{
	}
}
