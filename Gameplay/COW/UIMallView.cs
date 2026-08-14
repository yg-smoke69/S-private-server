using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003878")]
public class UIMallView : UIBaseView
{
	[Token(Token = "0x40173FE")]
	[FieldOffset(Offset = "0x14")]
	public UITexture BG;

	[Token(Token = "0x40173FF")]
	[FieldOffset(Offset = "0x18")]
	public Transform MallTypeContainer;

	[Token(Token = "0x4017400")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject MallTypeToggles;

	[Token(Token = "0x4017401")]
	[FieldOffset(Offset = "0x20")]
	public UIGrid MainToggleGrid;

	[Token(Token = "0x4017402")]
	[FieldOffset(Offset = "0x24")]
	public UIToggleButton NormalMallToggle;

	[Token(Token = "0x4017403")]
	[FieldOffset(Offset = "0x28")]
	public UIToggleButton WeaponMallToggle;

	[Token(Token = "0x4017404")]
	[FieldOffset(Offset = "0x2C")]
	public UIToggleButton BoxMallToggle;

	[Token(Token = "0x4017405")]
	[FieldOffset(Offset = "0x30")]
	public UIToggleButton GiftMallToggle;

	[Token(Token = "0x4017406")]
	[FieldOffset(Offset = "0x34")]
	public UIToggleButton ExchangeMallToggle;

	[Token(Token = "0x4017407")]
	[FieldOffset(Offset = "0x38")]
	public GameObject TopBar;

	[Token(Token = "0x4017408")]
	[FieldOffset(Offset = "0x3C")]
	public Transform MallPanelContainer;

	[Token(Token = "0x4017409")]
	[FieldOffset(Offset = "0x40")]
	public UIButton CharacterBtn;

	[Token(Token = "0x401740A")]
	[FieldOffset(Offset = "0x44")]
	public UIButton VaultBtn;

	[Token(Token = "0x401740B")]
	[FieldOffset(Offset = "0x48")]
	public UIWidget PreviewLeftContainer;

	[Token(Token = "0x401740C")]
	[FieldOffset(Offset = "0x4C")]
	public UIWidget PreviewRightContainer;

	[Token(Token = "0x401740D")]
	[FieldOffset(Offset = "0x50")]
	public UIButton TreasureBoxProbability;

	[Token(Token = "0x401740E")]
	[FieldOffset(Offset = "0x54")]
	public UIButton AnimPlayBtn;

	[Token(Token = "0x401740F")]
	[FieldOffset(Offset = "0x58")]
	public UIButton HyperBookBtn;

	[Token(Token = "0x4017410")]
	[FieldOffset(Offset = "0x5C")]
	public UIWidget PreviewBorder;

	[Token(Token = "0x6016D13")]
	[Address(RVA = "0x226B144", Offset = "0x226B144", VA = "0x226B144")]
	public UIMallView()
	{
	}

	[Token(Token = "0x6016D14")]
	[Address(RVA = "0x226B14C", Offset = "0x226B14C", VA = "0x226B14C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016D15")]
	[Address(RVA = "0x226B94C", Offset = "0x226B94C", VA = "0x226B94C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
