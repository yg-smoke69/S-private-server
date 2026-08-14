using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033B6")]
public class UIActivitySignInPopUpView : UIBaseView
{
	[Token(Token = "0x4013BF2")]
	[FieldOffset(Offset = "0x14")]
	public UILabel TimeLabel;

	[Token(Token = "0x4013BF3")]
	[FieldOffset(Offset = "0x18")]
	public UILabel LabelEndTime;

	[Token(Token = "0x4013BF4")]
	[FieldOffset(Offset = "0x1C")]
	public UIScrollView ListScrollView;

	[Token(Token = "0x4013BF5")]
	[FieldOffset(Offset = "0x20")]
	public Transform ItemContainer1;

	[Token(Token = "0x4013BF6")]
	[FieldOffset(Offset = "0x24")]
	public Transform ItemContainer2;

	[Token(Token = "0x4013BF7")]
	[FieldOffset(Offset = "0x28")]
	public Transform ItemContainer3;

	[Token(Token = "0x4013BF8")]
	[FieldOffset(Offset = "0x2C")]
	public Transform ItemContainer4;

	[Token(Token = "0x4013BF9")]
	[FieldOffset(Offset = "0x30")]
	public Transform ItemContainer5;

	[Token(Token = "0x4013BFA")]
	[FieldOffset(Offset = "0x34")]
	public Transform ItemContainer6;

	[Token(Token = "0x4013BFB")]
	[FieldOffset(Offset = "0x38")]
	public Transform ItemContainer7;

	[Token(Token = "0x4013BFC")]
	[FieldOffset(Offset = "0x3C")]
	public UINetworkTextureExt NetworkTexture;

	[Token(Token = "0x4013BFD")]
	[FieldOffset(Offset = "0x40")]
	public UILabel DescTitle;

	[Token(Token = "0x4013BFE")]
	[FieldOffset(Offset = "0x44")]
	public UIButton CloseBtn;

	[Token(Token = "0x6015ED8")]
	[Address(RVA = "0x1F21DAC", Offset = "0x1F21DAC", VA = "0x1F21DAC")]
	public UIActivitySignInPopUpView()
	{
	}

	[Token(Token = "0x6015ED9")]
	[Address(RVA = "0x1F21DB4", Offset = "0x1F21DB4", VA = "0x1F21DB4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015EDA")]
	[Address(RVA = "0x1F222C4", Offset = "0x1F222C4", VA = "0x1F222C4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
