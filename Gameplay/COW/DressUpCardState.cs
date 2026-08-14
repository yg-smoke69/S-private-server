using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200301B")]
public enum DressUpCardState
{
	[Token(Token = "0x401251B")]
	None,
	[Token(Token = "0x401251C")]
	HasSuitWithOutSex,
	[Token(Token = "0x401251D")]
	HasSuitWithInMale,
	[Token(Token = "0x401251E")]
	HasSuitWithInFeMale,
	[Token(Token = "0x401251F")]
	NoSuit,
	[Token(Token = "0x4012520")]
	Locked
}
