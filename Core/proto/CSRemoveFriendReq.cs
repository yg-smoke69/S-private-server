using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001699")]
public class CSRemoveFriendReq
{
	[Token(Token = "0x4009687")]
	[FieldOffset(Offset = "0x8")]
	public ulong remover;

	[Token(Token = "0x4009688")]
	[FieldOffset(Offset = "0x10")]
	public ulong removee;

	[Token(Token = "0x6007CF4")]
	[Address(RVA = "0x3099110", Offset = "0x3099110", VA = "0x3099110")]
	public CSRemoveFriendReq()
	{
	}
}
