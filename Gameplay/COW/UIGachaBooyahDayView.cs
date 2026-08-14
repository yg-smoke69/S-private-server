using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003566")]
public class UIGachaBooyahDayView : UIBaseView
{
	[Token(Token = "0x401525D")]
	[FieldOffset(Offset = "0x14")]
	public Animator GachaAnimator;

	[Token(Token = "0x401525E")]
	[FieldOffset(Offset = "0x18")]
	public GameObject UIGachaRightBorder;

	[Token(Token = "0x401525F")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton SwitchBtn;

	[Token(Token = "0x4015260")]
	[FieldOffset(Offset = "0x20")]
	public GameObject SwitchToGunSpr;

	[Token(Token = "0x4015261")]
	[FieldOffset(Offset = "0x24")]
	public GameObject SwitchToPersonSpr;

	[Token(Token = "0x4015262")]
	[FieldOffset(Offset = "0x28")]
	public GameObject ChangeSceneMask;

	[Token(Token = "0x4015263")]
	[FieldOffset(Offset = "0x2C")]
	public Transform CDNPreviewContainer;

	[Token(Token = "0x4015264")]
	[FieldOffset(Offset = "0x30")]
	public GameObject LeftBg;

	[Token(Token = "0x4015265")]
	[FieldOffset(Offset = "0x34")]
	public Transform ContentPanel;

	[Token(Token = "0x4015266")]
	[FieldOffset(Offset = "0x38")]
	public UIButton InterfaceContentMask;

	[Token(Token = "0x4015267")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject InterfaceContetnMaskLabel;

	[Token(Token = "0x4015268")]
	[FieldOffset(Offset = "0x40")]
	public UIButton InterfaceMask;

	[Token(Token = "0x4015269")]
	[FieldOffset(Offset = "0x44")]
	public GameObject UI3DPanel;

	[Token(Token = "0x401526A")]
	[FieldOffset(Offset = "0x48")]
	public GameObject InterfaceMaskLabel;

	[Token(Token = "0x401526B")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject Props;

	[Token(Token = "0x401526C")]
	[FieldOffset(Offset = "0x50")]
	public UIButton PropsButton;

	[Token(Token = "0x401526D")]
	[FieldOffset(Offset = "0x54")]
	public GameObject CouponTipsContainer;

	[Token(Token = "0x401526E")]
	[FieldOffset(Offset = "0x58")]
	public UIButton MaskPanel;

	[Token(Token = "0x401526F")]
	[FieldOffset(Offset = "0x5C")]
	public UITable Table;

	[Token(Token = "0x4015270")]
	[FieldOffset(Offset = "0x60")]
	public GameObject item1;

	[Token(Token = "0x4015271")]
	[FieldOffset(Offset = "0x64")]
	public GameObject item2;

	[Token(Token = "0x4015272")]
	[FieldOffset(Offset = "0x68")]
	public GameObject item3;

	[Token(Token = "0x4015273")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject MoreLabel;

	[Token(Token = "0x4015274")]
	[FieldOffset(Offset = "0x70")]
	public UILabel CurCouponCnt;

	[Token(Token = "0x4015275")]
	[FieldOffset(Offset = "0x74")]
	public UIButton BtnClose;

	[Token(Token = "0x4015276")]
	[FieldOffset(Offset = "0x78")]
	public GameObject RightBg;

	[Token(Token = "0x4015277")]
	[FieldOffset(Offset = "0x7C")]
	public UIButton BtnToken;

	[Token(Token = "0x4015278")]
	[FieldOffset(Offset = "0x80")]
	public UISprite TokenIcon;

	[Token(Token = "0x4015279")]
	[FieldOffset(Offset = "0x84")]
	public UILabel TokenNum;

	[Token(Token = "0x60163E2")]
	[Address(RVA = "0x2666410", Offset = "0x2666410", VA = "0x2666410")]
	public UIGachaBooyahDayView()
	{
	}

	[Token(Token = "0x60163E3")]
	[Address(RVA = "0x2666418", Offset = "0x2666418", VA = "0x2666418", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60163E4")]
	[Address(RVA = "0x2666F3C", Offset = "0x2666F3C", VA = "0x2666F3C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
