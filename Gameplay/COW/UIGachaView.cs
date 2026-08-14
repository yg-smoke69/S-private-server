using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200359E")]
public class UIGachaView : UIBaseView
{
	[Token(Token = "0x4015617")]
	[FieldOffset(Offset = "0x14")]
	public Animator GachaAnimator;

	[Token(Token = "0x4015618")]
	[FieldOffset(Offset = "0x18")]
	public GameObject GaChaTab;

	[Token(Token = "0x4015619")]
	[FieldOffset(Offset = "0x1C")]
	public UIScrollView TabScrollView;

	[Token(Token = "0x401561A")]
	[FieldOffset(Offset = "0x20")]
	public UIGrid GaChaTabGrid;

	[Token(Token = "0x401561B")]
	[FieldOffset(Offset = "0x24")]
	public GameObject prompt;

	[Token(Token = "0x401561C")]
	[FieldOffset(Offset = "0x28")]
	public UIToggle CheckboxForNotify;

	[Token(Token = "0x401561D")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject UIGachaRightBorder;

	[Token(Token = "0x401561E")]
	[FieldOffset(Offset = "0x30")]
	public UIButton SwitchBtn;

	[Token(Token = "0x401561F")]
	[FieldOffset(Offset = "0x34")]
	public GameObject SwitchToGunSpr;

	[Token(Token = "0x4015620")]
	[FieldOffset(Offset = "0x38")]
	public GameObject SwitchToPersonSpr;

	[Token(Token = "0x4015621")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject ChangeSceneMask;

	[Token(Token = "0x4015622")]
	[FieldOffset(Offset = "0x40")]
	public UINetworkTexture NetworkTexture;

	[Token(Token = "0x4015623")]
	[FieldOffset(Offset = "0x44")]
	public GameObject Props;

	[Token(Token = "0x4015624")]
	[FieldOffset(Offset = "0x48")]
	public UIButton PropsButton;

	[Token(Token = "0x4015625")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject CouponTipsContainer;

	[Token(Token = "0x4015626")]
	[FieldOffset(Offset = "0x50")]
	public UIButton MaskPanel;

	[Token(Token = "0x4015627")]
	[FieldOffset(Offset = "0x54")]
	public UITable Table;

	[Token(Token = "0x4015628")]
	[FieldOffset(Offset = "0x58")]
	public GameObject item1;

	[Token(Token = "0x4015629")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject item2;

	[Token(Token = "0x401562A")]
	[FieldOffset(Offset = "0x60")]
	public GameObject item3;

	[Token(Token = "0x401562B")]
	[FieldOffset(Offset = "0x64")]
	public GameObject MoreLabel;

	[Token(Token = "0x401562C")]
	[FieldOffset(Offset = "0x68")]
	public UILabel CurCouponCnt;

	[Token(Token = "0x401562D")]
	[FieldOffset(Offset = "0x6C")]
	public Transform ContentPanel;

	[Token(Token = "0x401562E")]
	[FieldOffset(Offset = "0x70")]
	public UIButton InterfaceContentMask;

	[Token(Token = "0x401562F")]
	[FieldOffset(Offset = "0x74")]
	public GameObject InterfaceContetnMaskLabel;

	[Token(Token = "0x4015630")]
	[FieldOffset(Offset = "0x78")]
	public UIButton InterfaceMask;

	[Token(Token = "0x4015631")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject UI3DPanel;

	[Token(Token = "0x4015632")]
	[FieldOffset(Offset = "0x80")]
	public GameObject InterfaceMaskLabel;

	[Token(Token = "0x4015633")]
	[FieldOffset(Offset = "0x84")]
	public UIWidget PreviewBorder;

	[Token(Token = "0x601648A")]
	[Address(RVA = "0x2E9AAA0", Offset = "0x2E9AAA0", VA = "0x2E9AAA0")]
	public UIGachaView()
	{
	}

	[Token(Token = "0x601648B")]
	[Address(RVA = "0x2E9AAA8", Offset = "0x2E9AAA8", VA = "0x2E9AAA8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601648C")]
	[Address(RVA = "0x2E9B5F4", Offset = "0x2E9B5F4", VA = "0x2E9B5F4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
