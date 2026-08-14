using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200343B")]
public class UIChoose1From3ItemView : UIBaseView
{
	[Token(Token = "0x40143AC")]
	[FieldOffset(Offset = "0x14")]
	public UILabel ItemName;

	[Token(Token = "0x40143AD")]
	[FieldOffset(Offset = "0x18")]
	public GameObject HighLight;

	[Token(Token = "0x40143AE")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton ItemButton;

	[Token(Token = "0x40143AF")]
	[FieldOffset(Offset = "0x20")]
	public BaseItemView ItemIconContainer;

	[Token(Token = "0x40143B0")]
	[FieldOffset(Offset = "0x24")]
	public UISprite NewQualityicon;

	[Token(Token = "0x40143B1")]
	[FieldOffset(Offset = "0x28")]
	public GameObject NotRecharge;

	[Token(Token = "0x40143B2")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject ChooseHasRecharge;

	[Token(Token = "0x40143B3")]
	[FieldOffset(Offset = "0x30")]
	public GameObject PriceContent;

	[Token(Token = "0x40143B4")]
	[FieldOffset(Offset = "0x34")]
	public UILabel Price;

	[Token(Token = "0x40143B5")]
	[FieldOffset(Offset = "0x38")]
	public UISprite BG;

	[Token(Token = "0x6016065")]
	[Address(RVA = "0x208D37C", Offset = "0x208D37C", VA = "0x208D37C")]
	public UIChoose1From3ItemView()
	{
	}

	[Token(Token = "0x6016066")]
	[Address(RVA = "0x208D384", Offset = "0x208D384", VA = "0x208D384", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016067")]
	[Address(RVA = "0x208D85C", Offset = "0x208D85C", VA = "0x208D85C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
