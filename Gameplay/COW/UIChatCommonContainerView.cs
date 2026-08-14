using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200342D")]
public class UIChatCommonContainerView : UIBaseView
{
	[Token(Token = "0x40142E2")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget Widget;

	[Token(Token = "0x40142E3")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ContentNode;

	[Token(Token = "0x40142E4")]
	[FieldOffset(Offset = "0x1C")]
	public UIScrollView MessageList;

	[Token(Token = "0x40142E5")]
	[FieldOffset(Offset = "0x20")]
	public GameObject EmptyNode;

	[Token(Token = "0x40142E6")]
	[FieldOffset(Offset = "0x24")]
	public GameObject NoMessageHint;

	[Token(Token = "0x601603B")]
	[Address(RVA = "0x262E5A4", Offset = "0x262E5A4", VA = "0x262E5A4")]
	public UIChatCommonContainerView()
	{
	}

	[Token(Token = "0x601603C")]
	[Address(RVA = "0x262E5AC", Offset = "0x262E5AC", VA = "0x262E5AC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601603D")]
	[Address(RVA = "0x262E8B0", Offset = "0x262E8B0", VA = "0x262E8B0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
