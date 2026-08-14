using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200186D")]
public class CSGetLimitedEventInventoryInfoRes
{
	[Token(Token = "0x4009CF6")]
	[FieldOffset(Offset = "0x8")]
	public List<LimitedEventBadge> badges;

	[Token(Token = "0x6007EC6")]
	[Address(RVA = "0x3186A9C", Offset = "0x3186A9C", VA = "0x3186A9C")]
	public CSGetLimitedEventInventoryInfoRes()
	{
	}
}
