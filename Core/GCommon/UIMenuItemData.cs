using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2004157")]
public class UIMenuItemData
{
	[Token(Token = "0x401B6A4")]
	[FieldOffset(Offset = "0x8")]
	public string id;

	[Token(Token = "0x401B6A5")]
	[FieldOffset(Offset = "0xC")]
	public string title;

	[Token(Token = "0x401B6A6")]
	[FieldOffset(Offset = "0x10")]
	public Action selectedCallback;

	[Token(Token = "0x401B6A7")]
	[FieldOffset(Offset = "0x14")]
	public Action unSelectedCallback;

	[Token(Token = "0x401B6A8")]
	[FieldOffset(Offset = "0x18")]
	public Action<GameObject[]> externInitCallback;

	[Token(Token = "0x601AB12")]
	[Address(RVA = "0x2CA7BA8", Offset = "0x2CA7BA8", VA = "0x2CA7BA8")]
	public UIMenuItemData()
	{
	}
}
