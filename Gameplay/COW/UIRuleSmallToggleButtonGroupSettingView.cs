using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003984")]
public class UIRuleSmallToggleButtonGroupSettingView : UIBaseView
{
	[Token(Token = "0x4018172")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget UIRuleSmallToggleButtonGroupSetting;

	[Token(Token = "0x4018173")]
	[FieldOffset(Offset = "0x18")]
	public UISprite BG;

	[Token(Token = "0x4018174")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Title;

	[Token(Token = "0x4018175")]
	[FieldOffset(Offset = "0x20")]
	public UIGrid Container;

	[Token(Token = "0x6017033")]
	[Address(RVA = "0x1420E04", Offset = "0x1420E04", VA = "0x1420E04")]
	public UIRuleSmallToggleButtonGroupSettingView()
	{
	}

	[Token(Token = "0x6017034")]
	[Address(RVA = "0x1420E0C", Offset = "0x1420E0C", VA = "0x1420E0C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017035")]
	[Address(RVA = "0x14210D4", Offset = "0x14210D4", VA = "0x14210D4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
