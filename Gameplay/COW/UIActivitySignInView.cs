using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033B7")]
public class UIActivitySignInView : UIBaseView
{
	[Token(Token = "0x4013BFF")]
	[FieldOffset(Offset = "0x14")]
	public UIButton VipSignInBtn;

	[Token(Token = "0x4013C00")]
	[FieldOffset(Offset = "0x18")]
	public UILabel TimeLabel;

	[Token(Token = "0x4013C01")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LabelEndTime;

	[Token(Token = "0x4013C02")]
	[FieldOffset(Offset = "0x20")]
	public UIScrollView ListScrollView;

	[Token(Token = "0x4013C03")]
	[FieldOffset(Offset = "0x24")]
	public Transform ItemContainer1;

	[Token(Token = "0x4013C04")]
	[FieldOffset(Offset = "0x28")]
	public Transform ItemContainer2;

	[Token(Token = "0x4013C05")]
	[FieldOffset(Offset = "0x2C")]
	public Transform ItemContainer3;

	[Token(Token = "0x4013C06")]
	[FieldOffset(Offset = "0x30")]
	public Transform ItemContainer4;

	[Token(Token = "0x4013C07")]
	[FieldOffset(Offset = "0x34")]
	public Transform ItemContainer5;

	[Token(Token = "0x4013C08")]
	[FieldOffset(Offset = "0x38")]
	public Transform ItemContainer6;

	[Token(Token = "0x4013C09")]
	[FieldOffset(Offset = "0x3C")]
	public Transform ItemContainer7;

	[Token(Token = "0x4013C0A")]
	[FieldOffset(Offset = "0x40")]
	public UINetworkTextureExt NetworkTexture;

	[Token(Token = "0x4013C0B")]
	[FieldOffset(Offset = "0x44")]
	public UILabel DescTitle;

	[Token(Token = "0x6015EDB")]
	[Address(RVA = "0x1F222CC", Offset = "0x1F222CC", VA = "0x1F222CC")]
	public UIActivitySignInView()
	{
	}

	[Token(Token = "0x6015EDC")]
	[Address(RVA = "0x1F222D4", Offset = "0x1F222D4", VA = "0x1F222D4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015EDD")]
	[Address(RVA = "0x1F227E4", Offset = "0x1F227E4", VA = "0x1F227E4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
