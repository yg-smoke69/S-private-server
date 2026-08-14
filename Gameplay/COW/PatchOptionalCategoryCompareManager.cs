using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20001E0")]
internal class PatchOptionalCategoryCompareManager : _Attribute
{
	[Token(Token = "0x60009EF")]
	[Address(RVA = "0x28D2B90", Offset = "0x28D2B90", VA = "0x28D2B90")]
	public PatchOptionalCategoryCompareManager()
	{
	}

	[Token(Token = "0x60009F0")]
	[Address(RVA = "0x28D2B98", Offset = "0x28D2B98", VA = "0x28D2B98", Slot = "4")]
	public int Compare(PatchOptionalCategoryManagerData x, PatchOptionalCategoryManagerData y)
	{
		return default(int);
	}
}
