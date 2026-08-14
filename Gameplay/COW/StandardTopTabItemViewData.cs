using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20023CA")]
public class StandardTopTabItemViewData
{
	[Token(Token = "0x400DE99")]
	[FieldOffset(Offset = "0x8")]
	public string tabName;

	[Token(Token = "0x400DE9A")]
	[FieldOffset(Offset = "0xC")]
	public string tabIconName;

	[Token(Token = "0x400DE9B")]
	[FieldOffset(Offset = "0x10")]
	public string selectIconName;

	[Token(Token = "0x400DE9C")]
	[FieldOffset(Offset = "0x14")]
	public string tabNameColor;

	[Token(Token = "0x400DE9D")]
	[FieldOffset(Offset = "0x18")]
	public ETipsType tipType;

	[Token(Token = "0x400DE9E")]
	[FieldOffset(Offset = "0x1C")]
	public Action onClick;

	[Token(Token = "0x400DE9F")]
	[FieldOffset(Offset = "0x20")]
	public object extraPara;

	[Token(Token = "0x400DEA0")]
	[FieldOffset(Offset = "0x24")]
	public Color SelectIconColor;

	[Token(Token = "0x600C9D7")]
	[Address(RVA = "0x288E1FC", Offset = "0x288E1FC", VA = "0x288E1FC")]
	public StandardTopTabItemViewData(string tabName, string tabIconName, ETipsType tipType = ETipsType.None)
	{
	}
}
