using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20028C4")]
public class WereWolvesChatEasyListCallBack : _Attribute
{
	[Token(Token = "0x400FAD7")]
	[FieldOffset(Offset = "0x8")]
	private Transform m_content;

	[Token(Token = "0x400FAD8")]
	[FieldOffset(Offset = "0xC")]
	public UIHudWereWolvesVoteController m_controller;

	[Token(Token = "0x60100DD")]
	[Address(RVA = "0x21B8C70", Offset = "0x21B8C70", VA = "0x21B8C70")]
	public WereWolvesChatEasyListCallBack(UIHudWereWolvesVoteController controller, Transform content)
	{
	}

	[Token(Token = "0x60100DE")]
	[Address(RVA = "0x21B8C98", Offset = "0x21B8C98", VA = "0x21B8C98", Slot = "4")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x60100DF")]
	[Address(RVA = "0x21B8D20", Offset = "0x21B8D20", VA = "0x21B8D20", Slot = "5")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}
}
