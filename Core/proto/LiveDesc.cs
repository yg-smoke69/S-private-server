using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B81")]
public class LiveDesc
{
	[Token(Token = "0x400AD01")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400AD02")]
	[FieldOffset(Offset = "0xC")]
	public string tab_name;

	[Token(Token = "0x400AD03")]
	[FieldOffset(Offset = "0x10")]
	public string web_link;

	[Token(Token = "0x400AD04")]
	[FieldOffset(Offset = "0x14")]
	public List<LivePopupDesc> live_popup;

	[Token(Token = "0x60081DC")]
	[Address(RVA = "0x30A64D0", Offset = "0x30A64D0", VA = "0x30A64D0")]
	public LiveDesc()
	{
	}
}
