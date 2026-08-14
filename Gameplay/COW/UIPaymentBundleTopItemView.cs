using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038E4")]
public class UIPaymentBundleTopItemView : UIBaseView
{
	[Token(Token = "0x40179D8")]
	[FieldOffset(Offset = "0x14")]
	public UIButton Button;

	[Token(Token = "0x40179D9")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Select;

	[Token(Token = "0x40179DA")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite SelectBg;

	[Token(Token = "0x40179DB")]
	[FieldOffset(Offset = "0x20")]
	public UILabel SelectLabel;

	[Token(Token = "0x40179DC")]
	[FieldOffset(Offset = "0x24")]
	public UISprite SelectLine;

	[Token(Token = "0x40179DD")]
	[FieldOffset(Offset = "0x28")]
	public UISprite SelectIcon;

	[Token(Token = "0x40179DE")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject UnSelect;

	[Token(Token = "0x40179DF")]
	[FieldOffset(Offset = "0x30")]
	public UISprite UnSelectBg;

	[Token(Token = "0x40179E0")]
	[FieldOffset(Offset = "0x34")]
	public UISprite UnSelectIcon;

	[Token(Token = "0x40179E1")]
	[FieldOffset(Offset = "0x38")]
	public UILabel UnSelectLabel;

	[Token(Token = "0x40179E2")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject RedPoint;

	[Token(Token = "0x40179E3")]
	[FieldOffset(Offset = "0x40")]
	public UISprite TabIcon;

	[Token(Token = "0x6016E55")]
	[Address(RVA = "0x28788B4", Offset = "0x28788B4", VA = "0x28788B4")]
	public UIPaymentBundleTopItemView()
	{
	}

	[Token(Token = "0x6016E56")]
	[Address(RVA = "0x28788BC", Offset = "0x28788BC", VA = "0x28788BC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016E57")]
	[Address(RVA = "0x2878E60", Offset = "0x2878E60", VA = "0x2878E60")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
