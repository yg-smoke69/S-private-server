using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200397D")]
public class UIRulePopmenuSettingV2View : UIBaseView
{
	[Token(Token = "0x401813B")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget Self;

	[Token(Token = "0x401813C")]
	[FieldOffset(Offset = "0x18")]
	public UISprite BG;

	[Token(Token = "0x401813D")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Title;

	[Token(Token = "0x401813E")]
	[FieldOffset(Offset = "0x20")]
	public UIButton Tip;

	[Token(Token = "0x401813F")]
	[FieldOffset(Offset = "0x24")]
	public UIPanel PopMenuContainer;

	[Token(Token = "0x601701E")]
	[Address(RVA = "0x2BFAC8C", Offset = "0x2BFAC8C", VA = "0x2BFAC8C")]
	public UIRulePopmenuSettingV2View()
	{
	}

	[Token(Token = "0x601701F")]
	[Address(RVA = "0x2BFAC94", Offset = "0x2BFAC94", VA = "0x2BFAC94", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017020")]
	[Address(RVA = "0x2BFAFBC", Offset = "0x2BFAFBC", VA = "0x2BFAFBC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
