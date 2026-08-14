using System;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20028F8")]
public class TabInfo
{
	[Token(Token = "0x400FBF6")]
	[FieldOffset(Offset = "0x8")]
	public string DeepLink;

	[Token(Token = "0x400FBF7")]
	[FieldOffset(Offset = "0xC")]
	public string Key;

	[Token(Token = "0x400FBF8")]
	[FieldOffset(Offset = "0x10")]
	public Action OnClick;

	[Token(Token = "0x6010317")]
	[Address(RVA = "0x2893D54", Offset = "0x2893D54", VA = "0x2893D54")]
	public TabInfo()
	{
	}
}
