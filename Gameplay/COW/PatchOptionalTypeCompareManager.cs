using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20001DF")]
internal class PatchOptionalTypeCompareManager : _Attribute
{
	[Token(Token = "0x60009ED")]
	[Address(RVA = "0x2DBD064", Offset = "0x2DBD064", VA = "0x2DBD064")]
	public PatchOptionalTypeCompareManager()
	{
	}

	[Token(Token = "0x60009EE")]
	[Address(RVA = "0x2DBD06C", Offset = "0x2DBD06C", VA = "0x2DBD06C", Slot = "4")]
	public int Compare(PatchOptionalTypeManagerData x, PatchOptionalTypeManagerData y)
	{
		return default(int);
	}
}
