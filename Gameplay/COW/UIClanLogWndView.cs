using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003451")]
public class UIClanLogWndView : UIBaseView
{
	[Token(Token = "0x40144B0")]
	[FieldOffset(Offset = "0x14")]
	public GameObject EmptyNode;

	[Token(Token = "0x40144B1")]
	[FieldOffset(Offset = "0x18")]
	public UIScrollView MessageList;

	[Token(Token = "0x40144B2")]
	[FieldOffset(Offset = "0x1C")]
	public UITable MessageListTable;

	[Token(Token = "0x60160A7")]
	[Address(RVA = "0x2B35168", Offset = "0x2B35168", VA = "0x2B35168")]
	public UIClanLogWndView()
	{
	}

	[Token(Token = "0x60160A8")]
	[Address(RVA = "0x2B35170", Offset = "0x2B35170", VA = "0x2B35170", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60160A9")]
	[Address(RVA = "0x2B353CC", Offset = "0x2B353CC", VA = "0x2B353CC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
