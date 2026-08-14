using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003989")]
public class UIRuleToggleSettingV2View : UIBaseView
{
	[Token(Token = "0x4018189")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget Self;

	[Token(Token = "0x401818A")]
	[FieldOffset(Offset = "0x18")]
	public UISprite BG;

	[Token(Token = "0x401818B")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Title;

	[Token(Token = "0x401818C")]
	[FieldOffset(Offset = "0x20")]
	public UIButton Tip;

	[Token(Token = "0x401818D")]
	[FieldOffset(Offset = "0x24")]
	public UIToggleButtonGroup Toggle;

	[Token(Token = "0x401818E")]
	[FieldOffset(Offset = "0x28")]
	public UIToggleButton Right;

	[Token(Token = "0x401818F")]
	[FieldOffset(Offset = "0x2C")]
	public UIToggleButton Left;

	[Token(Token = "0x4018190")]
	[FieldOffset(Offset = "0x30")]
	public UISprite ToggleBG;

	[Token(Token = "0x4018191")]
	[FieldOffset(Offset = "0x34")]
	public UITable Table;

	[Token(Token = "0x6017042")]
	[Address(RVA = "0x1428214", Offset = "0x1428214", VA = "0x1428214")]
	public UIRuleToggleSettingV2View()
	{
	}

	[Token(Token = "0x6017043")]
	[Address(RVA = "0x142821C", Offset = "0x142821C", VA = "0x142821C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017044")]
	[Address(RVA = "0x14286C4", Offset = "0x14286C4", VA = "0x14286C4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
