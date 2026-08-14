using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001505")]
public class CSModifyNicknameReq
{
	[Token(Token = "0x400908D")]
	[FieldOffset(Offset = "0x8")]
	public string nickname;

	[Token(Token = "0x400908E")]
	[FieldOffset(Offset = "0xC")]
	public bool use_card;

	[Token(Token = "0x6007B4E")]
	[Address(RVA = "0x3097D44", Offset = "0x3097D44", VA = "0x3097D44")]
	public CSModifyNicknameReq()
	{
	}
}
