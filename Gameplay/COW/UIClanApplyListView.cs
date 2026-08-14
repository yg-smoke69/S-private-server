using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003440")]
public class UIClanApplyListView : UIBaseView
{
	[Token(Token = "0x40143E4")]
	[FieldOffset(Offset = "0x14")]
	public UIPopWindowFrameStyle PopWndFrame;

	[Token(Token = "0x40143E5")]
	[FieldOffset(Offset = "0x18")]
	public UISprite TailArrow;

	[Token(Token = "0x40143E6")]
	[FieldOffset(Offset = "0x1C")]
	public UIScrollView ListScrollView_Apply;

	[Token(Token = "0x40143E7")]
	[FieldOffset(Offset = "0x20")]
	public UIEasyList ListGrid_Apply;

	[Token(Token = "0x40143E8")]
	[FieldOffset(Offset = "0x24")]
	public GameObject EmptyNode;

	[Token(Token = "0x6016074")]
	[Address(RVA = "0x2F20904", Offset = "0x2F20904", VA = "0x2F20904")]
	public UIClanApplyListView()
	{
	}

	[Token(Token = "0x6016075")]
	[Address(RVA = "0x2F2090C", Offset = "0x2F2090C", VA = "0x2F2090C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016076")]
	[Address(RVA = "0x2F20C28", Offset = "0x2F20C28", VA = "0x2F20C28")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
