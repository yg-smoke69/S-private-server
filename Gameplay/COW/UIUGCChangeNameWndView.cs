using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A1D")]
public class UIUGCChangeNameWndView : UIBaseView
{
	[Token(Token = "0x401889F")]
	[FieldOffset(Offset = "0x14")]
	public UILabel CurrentNameTxt;

	[Token(Token = "0x40188A0")]
	[FieldOffset(Offset = "0x18")]
	public UIInput NewNameInputTxt;

	[Token(Token = "0x40188A1")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnCancel;

	[Token(Token = "0x40188A2")]
	[FieldOffset(Offset = "0x20")]
	public UIButton BtnApply;

	[Token(Token = "0x60171FD")]
	[Address(RVA = "0x2B82040", Offset = "0x2B82040", VA = "0x2B82040")]
	public UIUGCChangeNameWndView()
	{
	}

	[Token(Token = "0x60171FE")]
	[Address(RVA = "0x2B82048", Offset = "0x2B82048", VA = "0x2B82048", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60171FF")]
	[Address(RVA = "0x2B82310", Offset = "0x2B82310", VA = "0x2B82310")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
