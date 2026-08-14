using System.Collections.Generic;
using Il2CppDummyDll;
using message;
using proto;

namespace COW;

[Token(Token = "0x2002D84")]
public static class UGCDirtyWorldUtil
{
	[Token(Token = "0x4011766")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<FONLAPPBCOO, EWorkshop.WordFilterType> LOGICENTITY_TO_WORDFILTER;

	[Token(Token = "0x60130DD")]
	[Address(RVA = "0x23410C8", Offset = "0x23410C8", VA = "0x23410C8")]
	public static EWorkshop.WordFilterType GetWordFilterTypeByLogicEntity(uint type)
	{
		return default(EWorkshop.WordFilterType);
	}
}
