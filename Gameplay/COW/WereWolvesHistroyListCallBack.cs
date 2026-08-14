using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20028C5")]
public class WereWolvesHistroyListCallBack : _Attribute
{
	[Token(Token = "0x400FAD9")]
	[FieldOffset(Offset = "0x8")]
	private Transform m_content;

	[Token(Token = "0x400FADA")]
	[FieldOffset(Offset = "0xC")]
	public UIHudWereWolvesVoteController m_controller;

	[Token(Token = "0x60100E0")]
	[Address(RVA = "0x21B8D9C", Offset = "0x21B8D9C", VA = "0x21B8D9C")]
	public WereWolvesHistroyListCallBack(UIHudWereWolvesVoteController controller, Transform content)
	{
	}

	[Token(Token = "0x60100E1")]
	[Address(RVA = "0x21B8DC4", Offset = "0x21B8DC4", VA = "0x21B8DC4", Slot = "4")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x60100E2")]
	[Address(RVA = "0x21B8E4C", Offset = "0x21B8E4C", VA = "0x21B8E4C", Slot = "5")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}
}
