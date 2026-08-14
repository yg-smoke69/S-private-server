using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200156D")]
public class CSGetAccountCupInfoReq
{
	[Token(Token = "0x400931C")]
	[FieldOffset(Offset = "0x8")]
	public uint cup_type;

	[Token(Token = "0x400931D")]
	[FieldOffset(Offset = "0xC")]
	public uint cup_id;

	[Token(Token = "0x6007BB5")]
	[Address(RVA = "0x3180AC0", Offset = "0x3180AC0", VA = "0x3180AC0")]
	public CSGetAccountCupInfoReq()
	{
	}
}
