using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200376B")]
internal class UIHudTeammatesInfoView : UIBaseView
{
	[Token(Token = "0x4016727")]
	[FieldOffset(Offset = "0x14")]
	public Transform Grid;

	[Token(Token = "0x4016728")]
	[FieldOffset(Offset = "0x18")]
	public UIHudTeammateItem TeammateTemplate;

	[Token(Token = "0x4016729")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Effect_Glow;

	[Token(Token = "0x401672A")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Icon_Celebrity;

	[Token(Token = "0x401672B")]
	[FieldOffset(Offset = "0x24")]
	public UIWidget TutorialWidget;

	[Token(Token = "0x401672C")]
	[FieldOffset(Offset = "0x28")]
	public UIToggleButtonGroup PageToggleGroup;

	[Token(Token = "0x401672D")]
	[FieldOffset(Offset = "0x2C")]
	public UIToggleButton Page1Toggle;

	[Token(Token = "0x401672E")]
	[FieldOffset(Offset = "0x30")]
	public UIToggleButton Page2Toggle;

	[Token(Token = "0x401672F")]
	[FieldOffset(Offset = "0x34")]
	public UIToggleButton Page3Toggle;

	[Token(Token = "0x4016730")]
	[FieldOffset(Offset = "0x38")]
	public UIScrollView RootScrollview;

	[Token(Token = "0x4016731")]
	[FieldOffset(Offset = "0x3C")]
	public UIWrapContent WrapContent;

	[Token(Token = "0x4016732")]
	[FieldOffset(Offset = "0x40")]
	public Transform PageGridTemplate;

	[Token(Token = "0x60169EC")]
	[Address(RVA = "0x17B0578", Offset = "0x17B0578", VA = "0x17B0578")]
	public UIHudTeammatesInfoView()
	{
	}

	[Token(Token = "0x60169ED")]
	[Address(RVA = "0x17B0580", Offset = "0x17B0580", VA = "0x17B0580", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60169EE")]
	[Address(RVA = "0x17B0AE0", Offset = "0x17B0AE0", VA = "0x17B0AE0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
