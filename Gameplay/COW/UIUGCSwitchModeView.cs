using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A4A")]
public class UIUGCSwitchModeView : UIBaseView
{
	[Token(Token = "0x4018A34")]
	[FieldOffset(Offset = "0x14")]
	public UIEasyList Grid;

	[Token(Token = "0x4018A35")]
	[FieldOffset(Offset = "0x18")]
	public UIToggleButton ClassicModeBtn;

	[Token(Token = "0x4018A36")]
	[FieldOffset(Offset = "0x1C")]
	public UIToggleButton TemplateModeBtn;

	[Token(Token = "0x4018A37")]
	[FieldOffset(Offset = "0x20")]
	public UILabel Desc;

	[Token(Token = "0x4018A38")]
	[FieldOffset(Offset = "0x24")]
	public UIButton BtnApply;

	[Token(Token = "0x6017284")]
	[Address(RVA = "0xF43BB4", Offset = "0xF43BB4", VA = "0xF43BB4")]
	public UIUGCSwitchModeView()
	{
	}

	[Token(Token = "0x6017285")]
	[Address(RVA = "0xF43BBC", Offset = "0xF43BBC", VA = "0xF43BBC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017286")]
	[Address(RVA = "0xF43EE4", Offset = "0xF43EE4", VA = "0xF43EE4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
