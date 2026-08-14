using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using message;

namespace COW.Gameplay.UGC;

[Token(Token = "0x2000CE5")]
public class UGCEditorErrorComparer : _Attribute
{
	[Token(Token = "0x400685C")]
	[FieldOffset(Offset = "0x8")]
	private Dictionary<int, OAMCFBDOEHM.BFIGPFKKAGK> m_config;

	[Token(Token = "0x60061CB")]
	[Address(RVA = "0x2F58C38", Offset = "0x2F58C38", VA = "0x2F58C38")]
	public UGCEditorErrorComparer(Dictionary<int, OAMCFBDOEHM.BFIGPFKKAGK> config)
	{
	}

	[Token(Token = "0x60061CC")]
	[Address(RVA = "0x2F5EBA8", Offset = "0x2F5EBA8", VA = "0x2F5EBA8", Slot = "4")]
	public int Compare(OAMCFBDOEHM.HHLNNKGMAFD x, OAMCFBDOEHM.HHLNNKGMAFD y)
	{
		return default(int);
	}
}
