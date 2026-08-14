using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003824")]
public class UILegendGachaReRandomConfirmWndView : UIBaseView
{
	[Token(Token = "0x4016E18")]
	[FieldOffset(Offset = "0x14")]
	public GameObject LegendBox;

	[Token(Token = "0x4016E19")]
	[FieldOffset(Offset = "0x18")]
	public UISprite ItemIcon;

	[Token(Token = "0x4016E1A")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel ItemNameLabel;

	[Token(Token = "0x4016E1B")]
	[FieldOffset(Offset = "0x20")]
	public UILabel ConfirmLabel;

	[Token(Token = "0x4016E1C")]
	[FieldOffset(Offset = "0x24")]
	public UIButton PurchaseBtn;

	[Token(Token = "0x4016E1D")]
	[FieldOffset(Offset = "0x28")]
	public GameObject DiamondBtn;

	[Token(Token = "0x4016E1E")]
	[FieldOffset(Offset = "0x2C")]
	public UIToggle NoShowToggle;

	[Token(Token = "0x4016E1F")]
	[FieldOffset(Offset = "0x30")]
	public GameObject Rampgae4CBox;

	[Token(Token = "0x6016C17")]
	[Address(RVA = "0x2548F10", Offset = "0x2548F10", VA = "0x2548F10")]
	public UILegendGachaReRandomConfirmWndView()
	{
	}

	[Token(Token = "0x6016C18")]
	[Address(RVA = "0x2548F18", Offset = "0x2548F18", VA = "0x2548F18", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016C19")]
	[Address(RVA = "0x254933C", Offset = "0x254933C", VA = "0x254933C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
