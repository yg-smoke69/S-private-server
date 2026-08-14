using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017CB")]
public class CSGetAccountSubscriptionsRes
{
	[Token(Token = "0x4009B6C")]
	[FieldOffset(Offset = "0x8")]
	public List<AccountSubscription> subscriptions;

	[Token(Token = "0x6007E25")]
	[Address(RVA = "0x3180DE4", Offset = "0x3180DE4", VA = "0x3180DE4")]
	public CSGetAccountSubscriptionsRes()
	{
	}
}
