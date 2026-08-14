using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001514")]
public class LikeReceiverInfo
{
	[Token(Token = "0x40090A9")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x40090AA")]
	[FieldOffset(Offset = "0x10")]
	public string region;

	[Token(Token = "0x6007B5D")]
	[Address(RVA = "0x30A4634", Offset = "0x30A4634", VA = "0x30A4634")]
	public LikeReceiverInfo()
	{
	}
}
