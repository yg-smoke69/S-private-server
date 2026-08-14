using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A56")]
public class UIVeteranGuideancePreviewItemReverseView : UIBaseView
{
	[Token(Token = "0x4018ADB")]
	[FieldOffset(Offset = "0x14")]
	public BaseItemView2 BaseItemView;

	[Token(Token = "0x4018ADC")]
	[FieldOffset(Offset = "0x18")]
	public UIButton ItemBtn;

	[Token(Token = "0x4018ADD")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Item;

	[Token(Token = "0x4018ADE")]
	[FieldOffset(Offset = "0x20")]
	public UILabel num;

	[Token(Token = "0x4018ADF")]
	[FieldOffset(Offset = "0x24")]
	public UISprite DefaultIcon;

	[Token(Token = "0x4018AE0")]
	[FieldOffset(Offset = "0x28")]
	public GameObject BigPrizeBG;

	[Token(Token = "0x4018AE1")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite plus;

	[Token(Token = "0x4018AE2")]
	[FieldOffset(Offset = "0x30")]
	public GameObject BigPrize;

	[Token(Token = "0x4018AE3")]
	[FieldOffset(Offset = "0x34")]
	public GameObject BeforeCommit;

	[Token(Token = "0x4018AE4")]
	[FieldOffset(Offset = "0x38")]
	public GameObject AfterCommit;

	[Token(Token = "0x4018AE5")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject Available;

	[Token(Token = "0x4018AE6")]
	[FieldOffset(Offset = "0x40")]
	public GameObject Received;

	[Token(Token = "0x4018AE7")]
	[FieldOffset(Offset = "0x44")]
	public GameObject Locked;

	[Token(Token = "0x60172A8")]
	[Address(RVA = "0x2857178", Offset = "0x2857178", VA = "0x2857178")]
	public UIVeteranGuideancePreviewItemReverseView()
	{
	}

	[Token(Token = "0x60172A9")]
	[Address(RVA = "0x2857180", Offset = "0x2857180", VA = "0x2857180", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60172AA")]
	[Address(RVA = "0x2857748", Offset = "0x2857748", VA = "0x2857748")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
