using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200135C")]
public class PlayerLogoutReq
{
	[Token(Token = "0x40088CA")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x40088CB")]
	[FieldOffset(Offset = "0x10")]
	public ulong conn_id;

	[Token(Token = "0x6007A5D")]
	[Address(RVA = "0x33DFFF0", Offset = "0x33DFFF0", VA = "0x33DFFF0")]
	public PlayerLogoutReq()
	{
	}
}
