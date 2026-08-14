using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002879")]
public class UIHudTestSkateboardEasyList : _Attribute
{
	[Token(Token = "0x200287A")]
	public enum EEasyListType
	{
		[Token(Token = "0x400F974")]
		LeftSide,
		[Token(Token = "0x400F975")]
		Search
	}

	[Token(Token = "0x400F971")]
	[FieldOffset(Offset = "0x8")]
	public EEasyListType ELType;

	[Token(Token = "0x400F972")]
	[FieldOffset(Offset = "0xC")]
	public UIHudTestSkateboardController Owner;

	[Token(Token = "0x600FDCC")]
	[Address(RVA = "0x157B45C", Offset = "0x157B45C", VA = "0x157B45C")]
	public UIHudTestSkateboardEasyList(UIHudTestSkateboardController owner, EEasyListType elt)
	{
	}

	[Token(Token = "0x600FDCD")]
	[Address(RVA = "0x157C0E4", Offset = "0x157C0E4", VA = "0x157C0E4", Slot = "4")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600FDCE")]
	[Address(RVA = "0x157C3FC", Offset = "0x157C3FC", VA = "0x157C3FC", Slot = "5")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}
}
