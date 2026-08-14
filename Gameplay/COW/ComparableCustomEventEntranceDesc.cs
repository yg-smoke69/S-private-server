using System.Runtime.InteropServices;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002EE7")]
public class ComparableCustomEventEntranceDesc : _Attribute
{
	[Token(Token = "0x60139F0")]
	[Address(RVA = "0x1C7FFE8", Offset = "0x1C7FFE8", VA = "0x1C7FFE8")]
	public ComparableCustomEventEntranceDesc()
	{
	}

	[Token(Token = "0x60139F1")]
	[Address(RVA = "0x1C7FFF0", Offset = "0x1C7FFF0", VA = "0x1C7FFF0", Slot = "4")]
	public int Compare(CustomEventEntranceDesc descLeft, CustomEventEntranceDesc descRight)
	{
		return default(int);
	}
}
