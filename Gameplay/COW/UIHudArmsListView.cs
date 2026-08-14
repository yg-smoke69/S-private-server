using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035CE")]
public class UIHudArmsListView : UIBaseView
{
	[Token(Token = "0x40158A5")]
	[FieldOffset(Offset = "0x14")]
	public UIButton Confirm;

	[Token(Token = "0x40158A6")]
	[FieldOffset(Offset = "0x18")]
	public UILabel CountDown;

	[Token(Token = "0x40158A7")]
	[FieldOffset(Offset = "0x1C")]
	public UIGrid Grid;

	[Token(Token = "0x6016518")]
	[Address(RVA = "0x170519C", Offset = "0x170519C", VA = "0x170519C")]
	public UIHudArmsListView()
	{
	}

	[Token(Token = "0x6016519")]
	[Address(RVA = "0x17051A4", Offset = "0x17051A4", VA = "0x17051A4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601651A")]
	[Address(RVA = "0x170540C", Offset = "0x170540C", VA = "0x170540C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
