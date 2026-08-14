using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036E6")]
public class UIHudPopupView : UIBaseView
{
	[Token(Token = "0x40162FA")]
	[FieldOffset(Offset = "0x14")]
	public UIPanel MainPanel;

	[Token(Token = "0x40162FB")]
	[FieldOffset(Offset = "0x18")]
	public UISprite Bg;

	[Token(Token = "0x40162FC")]
	[FieldOffset(Offset = "0x1C")]
	public UIPanel LabelPanel;

	[Token(Token = "0x40162FD")]
	[FieldOffset(Offset = "0x20")]
	public UILabel Message;

	[Token(Token = "0x40162FE")]
	[FieldOffset(Offset = "0x24")]
	public UILabel Messageshow;

	[Token(Token = "0x601685D")]
	[Address(RVA = "0x1FB9DA0", Offset = "0x1FB9DA0", VA = "0x1FB9DA0")]
	public UIHudPopupView()
	{
	}

	[Token(Token = "0x601685E")]
	[Address(RVA = "0x1FB9DA8", Offset = "0x1FB9DA8", VA = "0x1FB9DA8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601685F")]
	[Address(RVA = "0x1FBA0D0", Offset = "0x1FBA0D0", VA = "0x1FBA0D0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
