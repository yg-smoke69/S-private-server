using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038C0")]
public class UINewAutoPickUpSettingView : UIBaseView
{
	[Token(Token = "0x40177E2")]
	[FieldOffset(Offset = "0x14")]
	public GameObject BG;

	[Token(Token = "0x40177E3")]
	[FieldOffset(Offset = "0x18")]
	public GameObject TitleContainer;

	[Token(Token = "0x40177E4")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel TitleLabel;

	[Token(Token = "0x40177E5")]
	[FieldOffset(Offset = "0x20")]
	public UILabel TiTleDesc;

	[Token(Token = "0x40177E6")]
	[FieldOffset(Offset = "0x24")]
	public UIButton SettingTypeHelpBtn;

	[Token(Token = "0x40177E7")]
	[FieldOffset(Offset = "0x28")]
	public UIGrid UIGridSettingTypeTitleGrid;

	[Token(Token = "0x40177E8")]
	[FieldOffset(Offset = "0x2C")]
	public UIToggleButtonGroup UIToggleButtonGroupSettingTypeTitleGrid;

	[Token(Token = "0x40177E9")]
	[FieldOffset(Offset = "0x30")]
	public UIToggleButton SettingTypeTitleToggleButton;

	[Token(Token = "0x40177EA")]
	[FieldOffset(Offset = "0x34")]
	public UIToggleButtonGroup TabToggleButtonGroup;

	[Token(Token = "0x40177EB")]
	[FieldOffset(Offset = "0x38")]
	public UIToggleButton TabToggleButtonState;

	[Token(Token = "0x40177EC")]
	[FieldOffset(Offset = "0x3C")]
	public UIToggleButton TabToggleButtonPriority;

	[Token(Token = "0x40177ED")]
	[FieldOffset(Offset = "0x40")]
	public UIScrollView SettingContainerScrollView;

	[Token(Token = "0x40177EE")]
	[FieldOffset(Offset = "0x44")]
	public UITable ContentTable;

	[Token(Token = "0x40177EF")]
	[FieldOffset(Offset = "0x48")]
	public UITable PriorityTable;

	[Token(Token = "0x40177F0")]
	[FieldOffset(Offset = "0x4C")]
	public UITable FreezeTable;

	[Token(Token = "0x40177F1")]
	[FieldOffset(Offset = "0x50")]
	public Transform CommonSettingContainer;

	[Token(Token = "0x40177F2")]
	[FieldOffset(Offset = "0x54")]
	public UIButton ResetButton;

	[Token(Token = "0x40177F3")]
	[FieldOffset(Offset = "0x58")]
	public UIButton GuideCoverBtn;

	[Token(Token = "0x40177F4")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject SeperatorWidget1;

	[Token(Token = "0x40177F5")]
	[FieldOffset(Offset = "0x60")]
	public UISprite BtnBg;

	[Token(Token = "0x6016DEB")]
	[Address(RVA = "0x279EA38", Offset = "0x279EA38", VA = "0x279EA38")]
	public UINewAutoPickUpSettingView()
	{
	}

	[Token(Token = "0x6016DEC")]
	[Address(RVA = "0x279EA40", Offset = "0x279EA40", VA = "0x279EA40", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016DED")]
	[Address(RVA = "0x279F2BC", Offset = "0x279F2BC", VA = "0x279F2BC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
