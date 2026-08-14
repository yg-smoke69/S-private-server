using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002577")]
public class CodeInputPopupData
{
	[Token(Token = "0x400E7D4")]
	[FieldOffset(Offset = "0x8")]
	public string PopWindowTitle;

	[Token(Token = "0x400E7D5")]
	[FieldOffset(Offset = "0xC")]
	public string Title;

	[Token(Token = "0x400E7D6")]
	[FieldOffset(Offset = "0x10")]
	public Action<object> Callback;

	[Token(Token = "0x400E7D7")]
	[FieldOffset(Offset = "0x14")]
	public int CodeNumber;

	[Token(Token = "0x400E7D8")]
	[FieldOffset(Offset = "0x18")]
	public object Ext;

	[Token(Token = "0x600DB08")]
	[Address(RVA = "0x172EFD8", Offset = "0x172EFD8", VA = "0x172EFD8")]
	public CodeInputPopupData(string popwindowTitle = "", string title = "", [Optional] Action<object> callback, int codeNumber = 6, [Optional] object ext)
	{
	}
}
