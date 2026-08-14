using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002661")]
public enum GachaLimitItemState
{
	[Token(Token = "0x400ED12")]
	Normal,
	[Token(Token = "0x400ED13")]
	PrepareForRemove,
	[Token(Token = "0x400ED14")]
	MarkForRemove,
	[Token(Token = "0x400ED15")]
	Remove,
	[Token(Token = "0x400ED16")]
	Owned,
	[Token(Token = "0x400ED17")]
	OwnedByBag
}
