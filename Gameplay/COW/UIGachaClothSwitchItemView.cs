using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003567")]
public class UIGachaClothSwitchItemView : UIBaseView
{
	[Token(Token = "0x401527A")]
	[FieldOffset(Offset = "0x14")]
	public GameObject BG;

	[Token(Token = "0x401527B")]
	[FieldOffset(Offset = "0x18")]
	public GameObject SelectedBG;

	[Token(Token = "0x401527C")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton ItemBtn;

	[Token(Token = "0x401527D")]
	[FieldOffset(Offset = "0x20")]
	public GameObject ItemInfoContainer;

	[Token(Token = "0x401527E")]
	[FieldOffset(Offset = "0x24")]
	public BaseItemView BaseInfoView;

	[Token(Token = "0x401527F")]
	[FieldOffset(Offset = "0x28")]
	public GameObject ObtainedSprite;

	[Token(Token = "0x4015280")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject LimitTimeLabel;

	[Token(Token = "0x60163E5")]
	[Address(RVA = "0x266E168", Offset = "0x266E168", VA = "0x266E168")]
	public UIGachaClothSwitchItemView()
	{
	}

	[Token(Token = "0x60163E6")]
	[Address(RVA = "0x266E170", Offset = "0x266E170", VA = "0x266E170", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60163E7")]
	[Address(RVA = "0x266E51C", Offset = "0x266E51C", VA = "0x266E51C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
