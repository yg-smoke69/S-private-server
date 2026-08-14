using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001367")]
public class AdminSwapAccountReq
{
	[Token(Token = "0x40088E4")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id_a;

	[Token(Token = "0x40088E5")]
	[FieldOffset(Offset = "0x10")]
	public ulong account_id_b;

	[Token(Token = "0x40088E6")]
	[FieldOffset(Offset = "0x18")]
	public bool is_transfer_gems;

	[Token(Token = "0x6007A68")]
	[Address(RVA = "0x317A6DC", Offset = "0x317A6DC", VA = "0x317A6DC")]
	public AdminSwapAccountReq()
	{
	}
}
