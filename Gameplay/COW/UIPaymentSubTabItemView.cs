using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038F7")]
public class UIPaymentSubTabItemView : UIBaseView
{
	[Token(Token = "0x4017AC4")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnTab;

	[Token(Token = "0x4017AC5")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Select;

	[Token(Token = "0x4017AC6")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel SelectLabel;

	[Token(Token = "0x4017AC7")]
	[FieldOffset(Offset = "0x20")]
	public GameObject UnSelect;

	[Token(Token = "0x4017AC8")]
	[FieldOffset(Offset = "0x24")]
	public UILabel UnSelectLabel;

	[Token(Token = "0x4017AC9")]
	[FieldOffset(Offset = "0x28")]
	public GameObject Tag;

	[Token(Token = "0x4017ACA")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject NewSprite;

	[Token(Token = "0x4017ACB")]
	[FieldOffset(Offset = "0x30")]
	public GameObject RedPoint;

	[Token(Token = "0x4017ACC")]
	[FieldOffset(Offset = "0x34")]
	public Transform Lock;

	[Token(Token = "0x4017ACD")]
	[FieldOffset(Offset = "0x38")]
	public UILabel TagLabel;

	[Token(Token = "0x4017ACE")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite TagIconBg;

	[Token(Token = "0x4017ACF")]
	[FieldOffset(Offset = "0x40")]
	public UISprite TagIcon;

	[Token(Token = "0x6016E8E")]
	[Address(RVA = "0x29DF7A8", Offset = "0x29DF7A8", VA = "0x29DF7A8")]
	public UIPaymentSubTabItemView()
	{
	}

	[Token(Token = "0x6016E8F")]
	[Address(RVA = "0x29DF7B0", Offset = "0x29DF7B0", VA = "0x29DF7B0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016E90")]
	[Address(RVA = "0x29DFD14", Offset = "0x29DFD14", VA = "0x29DFD14")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
