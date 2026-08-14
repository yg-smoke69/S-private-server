using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200398A")]
public class UIRuleToggleSettingView : UIBaseView
{
	[Token(Token = "0x4018192")]
	[FieldOffset(Offset = "0x14")]
	public UISprite BG;

	[Token(Token = "0x4018193")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Title;

	[Token(Token = "0x4018194")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton Tip;

	[Token(Token = "0x4018195")]
	[FieldOffset(Offset = "0x20")]
	public UIToggleButtonGroup Toggle;

	[Token(Token = "0x4018196")]
	[FieldOffset(Offset = "0x24")]
	public UIToggleButton Right;

	[Token(Token = "0x4018197")]
	[FieldOffset(Offset = "0x28")]
	public UIToggleButton Left;

	[Token(Token = "0x6017045")]
	[Address(RVA = "0x14286CC", Offset = "0x14286CC", VA = "0x14286CC")]
	public UIRuleToggleSettingView()
	{
	}

	[Token(Token = "0x6017046")]
	[Address(RVA = "0x14286D4", Offset = "0x14286D4", VA = "0x14286D4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017047")]
	[Address(RVA = "0x1428A5C", Offset = "0x1428A5C", VA = "0x1428A5C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
