using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002875")]
public class UIHudTestRecipeEasyList : _Attribute
{
	[Token(Token = "0x2002876")]
	public enum EEasyListType
	{
		[Token(Token = "0x400F968")]
		LeftSide,
		[Token(Token = "0x400F969")]
		Search
	}

	[Token(Token = "0x400F965")]
	[FieldOffset(Offset = "0x8")]
	public EEasyListType ELType;

	[Token(Token = "0x400F966")]
	[FieldOffset(Offset = "0xC")]
	public UIHudTestRecipeController Owner;

	[Token(Token = "0x600FDB9")]
	[Address(RVA = "0x1578D28", Offset = "0x1578D28", VA = "0x1578D28")]
	public UIHudTestRecipeEasyList(UIHudTestRecipeController owner, EEasyListType elt)
	{
	}

	[Token(Token = "0x600FDBA")]
	[Address(RVA = "0x1578D50", Offset = "0x1578D50", VA = "0x1578D50", Slot = "4")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600FDBB")]
	[Address(RVA = "0x15790E8", Offset = "0x15790E8", VA = "0x15790E8", Slot = "5")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}
}
