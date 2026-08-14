using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003933")]
public class UIPVELuckyDrawView : UIBaseView
{
	[Token(Token = "0x4017EDA")]
	[FieldOffset(Offset = "0x14")]
	public GameObject MaskBG;

	[Token(Token = "0x4017EDB")]
	[FieldOffset(Offset = "0x18")]
	public Animator ItemsRoot;

	[Token(Token = "0x4017EDC")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Item0;

	[Token(Token = "0x4017EDD")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Item1;

	[Token(Token = "0x4017EDE")]
	[FieldOffset(Offset = "0x24")]
	public GameObject Item2;

	[Token(Token = "0x4017EDF")]
	[FieldOffset(Offset = "0x28")]
	public GameObject Item3;

	[Token(Token = "0x4017EE0")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject RankSSS;

	[Token(Token = "0x4017EE1")]
	[FieldOffset(Offset = "0x30")]
	public GameObject RankS;

	[Token(Token = "0x4017EE2")]
	[FieldOffset(Offset = "0x34")]
	public GameObject RankA;

	[Token(Token = "0x4017EE3")]
	[FieldOffset(Offset = "0x38")]
	public GameObject RankB;

	[Token(Token = "0x4017EE4")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton BtnDetail;

	[Token(Token = "0x4017EE5")]
	[FieldOffset(Offset = "0x40")]
	public GameObject OpenAllObj;

	[Token(Token = "0x4017EE6")]
	[FieldOffset(Offset = "0x44")]
	public UIButton PurchaseBtn;

	[Token(Token = "0x4017EE7")]
	[FieldOffset(Offset = "0x48")]
	public GameObject FreeBG;

	[Token(Token = "0x4017EE8")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject CostBG;

	[Token(Token = "0x4017EE9")]
	[FieldOffset(Offset = "0x50")]
	public UILabel DiamondCount;

	[Token(Token = "0x4017EEA")]
	[FieldOffset(Offset = "0x54")]
	public UILabel LuckyTodayLabel;

	[Token(Token = "0x4017EEB")]
	[FieldOffset(Offset = "0x58")]
	public UIButton CloseBtn;

	[Token(Token = "0x6016F40")]
	[Address(RVA = "0x15A6D54", Offset = "0x15A6D54", VA = "0x15A6D54")]
	public UIPVELuckyDrawView()
	{
	}

	[Token(Token = "0x6016F41")]
	[Address(RVA = "0x15A6D5C", Offset = "0x15A6D5C", VA = "0x15A6D5C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016F42")]
	[Address(RVA = "0x15A74D4", Offset = "0x15A74D4", VA = "0x15A74D4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
