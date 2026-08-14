using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002A6A")]
public class PopMenuData
{
	[Token(Token = "0x4010499")]
	[FieldOffset(Offset = "0x8")]
	public string Text;

	[Token(Token = "0x401049A")]
	[FieldOffset(Offset = "0xC")]
	public Action<object> Callback;

	[Token(Token = "0x401049B")]
	[FieldOffset(Offset = "0x10")]
	public object Data;

	[Token(Token = "0x401049C")]
	[FieldOffset(Offset = "0x14")]
	public bool Selected;

	[Token(Token = "0x401049D")]
	[FieldOffset(Offset = "0x15")]
	public bool CanSelect;

	[Token(Token = "0x401049E")]
	[FieldOffset(Offset = "0x18")]
	public ResourceID spriteRes;

	[Token(Token = "0x401049F")]
	[FieldOffset(Offset = "0x1C")]
	public string spritename;

	[Token(Token = "0x40104A0")]
	[FieldOffset(Offset = "0x20")]
	public string SelectTip;

	[Token(Token = "0x40104A1")]
	[FieldOffset(Offset = "0x24")]
	public EEventTag TagType;

	[Token(Token = "0x40104A2")]
	[FieldOffset(Offset = "0x28")]
	public List<PopMenuData> SubMenuData;

	[Token(Token = "0x40104A3")]
	[FieldOffset(Offset = "0x2C")]
	public bool IsDownLoadIconActive;

	[Token(Token = "0x6011428")]
	[Address(RVA = "0x1C0CF9C", Offset = "0x1C0CF9C", VA = "0x1C0CF9C")]
	public PopMenuData()
	{
	}
}
