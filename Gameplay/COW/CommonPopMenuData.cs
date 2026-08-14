using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002581")]
public class CommonPopMenuData
{
	[Token(Token = "0x400E817")]
	[FieldOffset(Offset = "0x8")]
	public string Text;

	[Token(Token = "0x400E818")]
	[FieldOffset(Offset = "0xC")]
	public Action<object> Callback;

	[Token(Token = "0x400E819")]
	[FieldOffset(Offset = "0x10")]
	public object Ext;

	[Token(Token = "0x400E81A")]
	[FieldOffset(Offset = "0x14")]
	public bool Enabled;

	[Token(Token = "0x600DB52")]
	[Address(RVA = "0x17391A0", Offset = "0x17391A0", VA = "0x17391A0")]
	public CommonPopMenuData(string text = "", [Optional] Action<object> callback, [Optional] object ext, bool enable = true)
	{
	}
}
