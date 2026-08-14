using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036F4")]
public class UIHudQuickChatItemView : UIBaseView
{
	[Token(Token = "0x4016335")]
	[FieldOffset(Offset = "0x14")]
	public UIButton Btn;

	[Token(Token = "0x4016336")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Label;

	[Token(Token = "0x6016887")]
	[Address(RVA = "0x1FCAD40", Offset = "0x1FCAD40", VA = "0x1FCAD40")]
	public UIHudQuickChatItemView()
	{
	}

	[Token(Token = "0x6016888")]
	[Address(RVA = "0x1FCAD48", Offset = "0x1FCAD48", VA = "0x1FCAD48", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016889")]
	[Address(RVA = "0x1FCAF50", Offset = "0x1FCAF50", VA = "0x1FCAF50")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
