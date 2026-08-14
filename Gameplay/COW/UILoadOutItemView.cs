using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003835")]
public class UILoadOutItemView : UIBaseView
{
	[Token(Token = "0x4016EC1")]
	[FieldOffset(Offset = "0x14")]
	public BaseItemView BaseInfoView;

	[Token(Token = "0x4016EC2")]
	[FieldOffset(Offset = "0x18")]
	public UIButton itemBtn;

	[Token(Token = "0x4016EC3")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite icon;

	[Token(Token = "0x4016EC4")]
	[FieldOffset(Offset = "0x20")]
	public UILabel cnt;

	[Token(Token = "0x4016EC5")]
	[FieldOffset(Offset = "0x24")]
	public UILabel name;

	[Token(Token = "0x4016EC6")]
	[FieldOffset(Offset = "0x28")]
	public GameObject HL;

	[Token(Token = "0x4016EC7")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject HLPlayCard;

	[Token(Token = "0x4016EC8")]
	[FieldOffset(Offset = "0x30")]
	public GameObject line;

	[Token(Token = "0x4016EC9")]
	[FieldOffset(Offset = "0x34")]
	public UIButton infoBtn;

	[Token(Token = "0x4016ECA")]
	[FieldOffset(Offset = "0x38")]
	public UILabel num;

	[Token(Token = "0x4016ECB")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton IncreaseBtn;

	[Token(Token = "0x4016ECC")]
	[FieldOffset(Offset = "0x40")]
	public UIButton DecreaseBtn;

	[Token(Token = "0x4016ECD")]
	[FieldOffset(Offset = "0x44")]
	public UIButton BuyBtn;

	[Token(Token = "0x4016ECE")]
	[FieldOffset(Offset = "0x48")]
	public UILabel Price;

	[Token(Token = "0x4016ECF")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject PlayCardGameObj;

	[Token(Token = "0x4016ED0")]
	[FieldOffset(Offset = "0x50")]
	public UISprite PlayCardIcon;

	[Token(Token = "0x4016ED1")]
	[FieldOffset(Offset = "0x54")]
	public UILabel Remain;

	[Token(Token = "0x6016C4A")]
	[Address(RVA = "0x214F620", Offset = "0x214F620", VA = "0x214F620")]
	public UILoadOutItemView()
	{
	}

	[Token(Token = "0x6016C4B")]
	[Address(RVA = "0x214F628", Offset = "0x214F628", VA = "0x214F628", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016C4C")]
	[Address(RVA = "0x214FDA0", Offset = "0x214FDA0", VA = "0x214FDA0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
