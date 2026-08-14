using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039AE")]
public class UISettingView : UIBaseView
{
	[Token(Token = "0x401835F")]
	[FieldOffset(Offset = "0x14")]
	public UIPanel WindowPanel;

	[Token(Token = "0x4018360")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ChangeTabToggle;

	[Token(Token = "0x4018361")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject BasicNode;

	[Token(Token = "0x4018362")]
	[FieldOffset(Offset = "0x20")]
	public UIToggleButton BasicButton;

	[Token(Token = "0x4018363")]
	[FieldOffset(Offset = "0x24")]
	public GameObject UGCEditor;

	[Token(Token = "0x4018364")]
	[FieldOffset(Offset = "0x28")]
	public UIToggleButton UGCEditorButton;

	[Token(Token = "0x4018365")]
	[FieldOffset(Offset = "0x2C")]
	public UIToggleButton SensitivyButton;

	[Token(Token = "0x4018366")]
	[FieldOffset(Offset = "0x30")]
	public UIToggleButton OperationButton;

	[Token(Token = "0x4018367")]
	[FieldOffset(Offset = "0x34")]
	public GameObject OperationTips;

	[Token(Token = "0x4018368")]
	[FieldOffset(Offset = "0x38")]
	public UIToggleButton AutoPickUpTabBtn;

	[Token(Token = "0x4018369")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject Graphics;

	[Token(Token = "0x401836A")]
	[FieldOffset(Offset = "0x40")]
	public UIToggleButton GraphicsBtn;

	[Token(Token = "0x401836B")]
	[FieldOffset(Offset = "0x44")]
	public UIToggleButton SoundButton;

	[Token(Token = "0x401836C")]
	[FieldOffset(Offset = "0x48")]
	public GameObject VibrateTab;

	[Token(Token = "0x401836D")]
	[FieldOffset(Offset = "0x4C")]
	public UIToggleButton VibrateButton;

	[Token(Token = "0x401836E")]
	[FieldOffset(Offset = "0x50")]
	public GameObject NotificationsTab;

	[Token(Token = "0x401836F")]
	[FieldOffset(Offset = "0x54")]
	public UIToggleButton NotificationsButton;

	[Token(Token = "0x4018370")]
	[FieldOffset(Offset = "0x58")]
	public GameObject MAXTab;

	[Token(Token = "0x4018371")]
	[FieldOffset(Offset = "0x5C")]
	public UIToggleButton MAXButton;

	[Token(Token = "0x4018372")]
	[FieldOffset(Offset = "0x60")]
	public GameObject MaxRedTips;

	[Token(Token = "0x4018373")]
	[FieldOffset(Offset = "0x64")]
	public GameObject DebugInfoTab;

	[Token(Token = "0x4018374")]
	[FieldOffset(Offset = "0x68")]
	public UIToggleButton DegbugInfoButton;

	[Token(Token = "0x4018375")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject OBTab;

	[Token(Token = "0x4018376")]
	[FieldOffset(Offset = "0x70")]
	public UIToggleButton OBButton;

	[Token(Token = "0x4018377")]
	[FieldOffset(Offset = "0x74")]
	public UISprite bg;

	[Token(Token = "0x4018378")]
	[FieldOffset(Offset = "0x78")]
	public GameObject Content;

	[Token(Token = "0x4018379")]
	[FieldOffset(Offset = "0x7C")]
	public UIButton QuitBtn1;

	[Token(Token = "0x401837A")]
	[FieldOffset(Offset = "0x80")]
	public GameObject RegionContainer;

	[Token(Token = "0x401837B")]
	[FieldOffset(Offset = "0x84")]
	public UILabel Region;

	[Token(Token = "0x60170B1")]
	[Address(RVA = "0x20529CC", Offset = "0x20529CC", VA = "0x20529CC")]
	public UISettingView()
	{
	}

	[Token(Token = "0x60170B2")]
	[Address(RVA = "0x20529D4", Offset = "0x20529D4", VA = "0x20529D4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60170B3")]
	[Address(RVA = "0x2053560", Offset = "0x2053560", VA = "0x2053560")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
