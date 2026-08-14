using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033E7")]
internal class UIBaseChatItemView : UIBaseView
{
	[Token(Token = "0x4013EFE")]
	[FieldOffset(Offset = "0x14")]
	public BaseChatMessageView LeftView;

	[Token(Token = "0x4013EFF")]
	[FieldOffset(Offset = "0x18")]
	public UIButton headbtnleft;

	[Token(Token = "0x4013F00")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton LeftContentBtn;

	[Token(Token = "0x4013F01")]
	[FieldOffset(Offset = "0x20")]
	public BaseChatMessageView RightView;

	[Token(Token = "0x4013F02")]
	[FieldOffset(Offset = "0x24")]
	public UIButton headbtn;

	[Token(Token = "0x4013F03")]
	[FieldOffset(Offset = "0x28")]
	public UIButton RightContentBtn;

	[Token(Token = "0x6015F6B")]
	[Address(RVA = "0x1409548", Offset = "0x1409548", VA = "0x1409548")]
	public UIBaseChatItemView()
	{
	}

	[Token(Token = "0x6015F6C")]
	[Address(RVA = "0x1409550", Offset = "0x1409550", VA = "0x1409550", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015F6D")]
	[Address(RVA = "0x14097F8", Offset = "0x14097F8", VA = "0x14097F8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
