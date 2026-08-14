using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A28")]
public class UIUGCDebuggerOpenView : UIBaseView
{
	[Token(Token = "0x40188EC")]
	[FieldOffset(Offset = "0x14")]
	public Object Panel;

	[Token(Token = "0x40188ED")]
	[FieldOffset(Offset = "0x18")]
	public UIButton OKBtn;

	[Token(Token = "0x40188EE")]
	[FieldOffset(Offset = "0x1C")]
	public UIToggle FastTestToggle;

	[Token(Token = "0x40188EF")]
	[FieldOffset(Offset = "0x20")]
	public UIToggle NormalTestToggle;

	[Token(Token = "0x40188F0")]
	[FieldOffset(Offset = "0x24")]
	public UIToggle ToggleFillFullBot;

	[Token(Token = "0x40188F1")]
	[FieldOffset(Offset = "0x28")]
	public UIButton CloseBtn;

	[Token(Token = "0x601721E")]
	[Address(RVA = "0x2B933E4", Offset = "0x2B933E4", VA = "0x2B933E4")]
	public UIUGCDebuggerOpenView()
	{
	}

	[Token(Token = "0x601721F")]
	[Address(RVA = "0x2B933EC", Offset = "0x2B933EC", VA = "0x2B933EC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017220")]
	[Address(RVA = "0x2B93774", Offset = "0x2B93774", VA = "0x2B93774")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
