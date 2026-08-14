using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038ED")]
public class UIPaymentIAPView : UIBaseView
{
	[Token(Token = "0x4017A44")]
	[FieldOffset(Offset = "0x14")]
	public GameObject UIPaymentIAP;

	[Token(Token = "0x4017A45")]
	[FieldOffset(Offset = "0x18")]
	public UIGrid PaymentItemsGrid;

	[Token(Token = "0x4017A46")]
	[FieldOffset(Offset = "0x1C")]
	public UIWidget CdnAdContainer;

	[Token(Token = "0x4017A47")]
	[FieldOffset(Offset = "0x20")]
	public UIScrollView ScrollView;

	[Token(Token = "0x4017A48")]
	[FieldOffset(Offset = "0x24")]
	public UIWrapContent WrapContent;

	[Token(Token = "0x4017A49")]
	[FieldOffset(Offset = "0x28")]
	public GameObject BonusContainer;

	[Token(Token = "0x4017A4A")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject Bonus;

	[Token(Token = "0x4017A4B")]
	[FieldOffset(Offset = "0x30")]
	public UILabel BonusDescLabel;

	[Token(Token = "0x4017A4C")]
	[FieldOffset(Offset = "0x34")]
	public UILabel BonusLabel;

	[Token(Token = "0x4017A4D")]
	[FieldOffset(Offset = "0x38")]
	public UIButton ProbabilityBtn;

	[Token(Token = "0x4017A4E")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject BonusTips;

	[Token(Token = "0x4017A4F")]
	[FieldOffset(Offset = "0x40")]
	public UILabel BonusTipsLabel;

	[Token(Token = "0x4017A50")]
	[FieldOffset(Offset = "0x44")]
	public Transform CountDown;

	[Token(Token = "0x4017A51")]
	[FieldOffset(Offset = "0x48")]
	public UILabel time;

	[Token(Token = "0x4017A52")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject BonusSpinUnFinishedVFX;

	[Token(Token = "0x4017A53")]
	[FieldOffset(Offset = "0x50")]
	public MeshRenderer number_ones;

	[Token(Token = "0x4017A54")]
	[FieldOffset(Offset = "0x54")]
	public MeshRenderer number_tens;

	[Token(Token = "0x4017A55")]
	[FieldOffset(Offset = "0x58")]
	public MeshRenderer number_hunderds;

	[Token(Token = "0x4017A56")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject BonusSpinedFinishedVFX;

	[Token(Token = "0x4017A57")]
	[FieldOffset(Offset = "0x60")]
	public UIButton GetBonusBtn;

	[Token(Token = "0x4017A58")]
	[FieldOffset(Offset = "0x64")]
	public UIGrid CdnAdDotsGrid;

	[Token(Token = "0x4017A59")]
	[FieldOffset(Offset = "0x68")]
	public UIButton BtnPaymentActivity;

	[Token(Token = "0x4017A5A")]
	[FieldOffset(Offset = "0x6C")]
	public UISprite PaymentActivityRedDot;

	[Token(Token = "0x6016E70")]
	[Address(RVA = "0x29D810C", Offset = "0x29D810C", VA = "0x29D810C")]
	public UIPaymentIAPView()
	{
	}

	[Token(Token = "0x6016E71")]
	[Address(RVA = "0x29D8114", Offset = "0x29D8114", VA = "0x29D8114", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016E72")]
	[Address(RVA = "0x29D8A8C", Offset = "0x29D8A8C", VA = "0x29D8A8C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
