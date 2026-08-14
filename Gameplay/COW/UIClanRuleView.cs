using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003456")]
public class UIClanRuleView : UIBaseView
{
	[Token(Token = "0x4014502")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnClose;

	[Token(Token = "0x4014503")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BtnConfirm;

	[Token(Token = "0x60160B6")]
	[Address(RVA = "0x2B43554", Offset = "0x2B43554", VA = "0x2B43554")]
	public UIClanRuleView()
	{
	}

	[Token(Token = "0x60160B7")]
	[Address(RVA = "0x2B4355C", Offset = "0x2B4355C", VA = "0x2B4355C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60160B8")]
	[Address(RVA = "0x2B43764", Offset = "0x2B43764", VA = "0x2B43764")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
