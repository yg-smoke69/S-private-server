using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002DA0")]
public enum LinkSystemStatus
{
	[Token(Token = "0x4011825")]
	NotReady,
	[Token(Token = "0x4011826")]
	Closed,
	[Token(Token = "0x4011827")]
	NoAny,
	[Token(Token = "0x4011828")]
	NoSelectable,
	[Token(Token = "0x4011829")]
	ExistSelectableButCooldown,
	[Token(Token = "0x401182A")]
	ExistSelectable,
	[Token(Token = "0x401182B")]
	SelectedProcessing,
	[Token(Token = "0x401182C")]
	SelectedAcquirable,
	[Token(Token = "0x401182D")]
	AllAcquired
}
