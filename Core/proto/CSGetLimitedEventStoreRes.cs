using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017E6")]
public class CSGetLimitedEventStoreRes
{
	[Token(Token = "0x4009BA3")]
	[FieldOffset(Offset = "0x8")]
	public List<LimitedEventStore> limited_event_stores;

	[Token(Token = "0x6007E40")]
	[Address(RVA = "0x3186D20", Offset = "0x3186D20", VA = "0x3186D20")]
	public CSGetLimitedEventStoreRes()
	{
	}
}
