using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003833")]
public class UILoadOutItemNewView : UIBaseView
{
	[Token(Token = "0x4016EAA")]
	[FieldOffset(Offset = "0x14")]
	public BaseItemView BaseInfoView;

	[Token(Token = "0x4016EAB")]
	[FieldOffset(Offset = "0x18")]
	public UIButton itemBtn;

	[Token(Token = "0x4016EAC")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite icon;

	[Token(Token = "0x4016EAD")]
	[FieldOffset(Offset = "0x20")]
	public UILabel cnt;

	[Token(Token = "0x4016EAE")]
	[FieldOffset(Offset = "0x24")]
	public UILabel name;

	[Token(Token = "0x4016EAF")]
	[FieldOffset(Offset = "0x28")]
	public GameObject HL;

	[Token(Token = "0x4016EB0")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject HLPlayCard;

	[Token(Token = "0x4016EB1")]
	[FieldOffset(Offset = "0x30")]
	public GameObject line;

	[Token(Token = "0x4016EB2")]
	[FieldOffset(Offset = "0x34")]
	public UIButton infoBtn;

	[Token(Token = "0x4016EB3")]
	[FieldOffset(Offset = "0x38")]
	public UIButton BuyBtn;

	[Token(Token = "0x4016EB4")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel Price;

	[Token(Token = "0x4016EB5")]
	[FieldOffset(Offset = "0x40")]
	public UIButton DecreaseBtn;

	[Token(Token = "0x4016EB6")]
	[FieldOffset(Offset = "0x44")]
	public UIButton IncreaseBtn;

	[Token(Token = "0x4016EB7")]
	[FieldOffset(Offset = "0x48")]
	public UILabel num;

	[Token(Token = "0x4016EB8")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject PlayCardGameObj;

	[Token(Token = "0x4016EB9")]
	[FieldOffset(Offset = "0x50")]
	public UISprite PlayCardIcon;

	[Token(Token = "0x4016EBA")]
	[FieldOffset(Offset = "0x54")]
	public UILabel Remain;

	[Token(Token = "0x6016C44")]
	[Address(RVA = "0x214EB30", Offset = "0x214EB30", VA = "0x214EB30")]
	public UILoadOutItemNewView()
	{
	}

	[Token(Token = "0x6016C45")]
	[Address(RVA = "0x214EB38", Offset = "0x214EB38", VA = "0x214EB38", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016C46")]
	[Address(RVA = "0x214F2B0", Offset = "0x214F2B0", VA = "0x214F2B0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
