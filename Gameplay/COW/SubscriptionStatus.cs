using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002D77")]
public enum SubscriptionStatus
{
	[Token(Token = "0x401171A")]
	None = -1,
	[Token(Token = "0x401171B")]
	Active,
	[Token(Token = "0x401171C")]
	Expired,
	[Token(Token = "0x401171D")]
	Cancelled,
	[Token(Token = "0x401171E")]
	Revoked,
	[Token(Token = "0x401171F")]
	Transferred,
	[Token(Token = "0x4011720")]
	Scheduled
}
