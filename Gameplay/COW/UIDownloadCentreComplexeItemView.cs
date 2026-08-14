using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034F1")]
public class UIDownloadCentreComplexeItemView : UIBaseView
{
	[Token(Token = "0x4014CFF")]
	[FieldOffset(Offset = "0x14")]
	public UISprite TagState;

	[Token(Token = "0x4014D00")]
	[FieldOffset(Offset = "0x18")]
	public UINetworkTexture CDNSprite;

	[Token(Token = "0x4014D01")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Desc;

	[Token(Token = "0x4014D02")]
	[FieldOffset(Offset = "0x20")]
	public UILabel Title;

	[Token(Token = "0x4014D03")]
	[FieldOffset(Offset = "0x24")]
	public UILabel ProgressLabel;

	[Token(Token = "0x4014D04")]
	[FieldOffset(Offset = "0x28")]
	public UISprite ProgressBar;

	[Token(Token = "0x4014D05")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton DeleteBtn;

	[Token(Token = "0x4014D06")]
	[FieldOffset(Offset = "0x30")]
	public UIButton InPendingBtn;

	[Token(Token = "0x4014D07")]
	[FieldOffset(Offset = "0x34")]
	public UIButton DownloadBtn;

	[Token(Token = "0x4014D08")]
	[FieldOffset(Offset = "0x38")]
	public UIButton pauseBtn;

	[Token(Token = "0x4014D09")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton ActivityBtn;

	[Token(Token = "0x4014D0A")]
	[FieldOffset(Offset = "0x40")]
	public UISprite ActivityIcon;

	[Token(Token = "0x4014D0B")]
	[FieldOffset(Offset = "0x44")]
	public GameObject ActivityEffect;

	[Token(Token = "0x4014D0C")]
	[FieldOffset(Offset = "0x48")]
	public UIButton RetryBtn;

	[Token(Token = "0x4014D0D")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject FinishedLabel;

	[Token(Token = "0x4014D0E")]
	[FieldOffset(Offset = "0x50")]
	public GameObject InPendingEffect;

	[Token(Token = "0x4014D0F")]
	[FieldOffset(Offset = "0x54")]
	public UILabel ActivityNum;

	[Token(Token = "0x6016283")]
	[Address(RVA = "0x276184C", Offset = "0x276184C", VA = "0x276184C")]
	public UIDownloadCentreComplexeItemView()
	{
	}

	[Token(Token = "0x6016284")]
	[Address(RVA = "0x2761854", Offset = "0x2761854", VA = "0x2761854", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016285")]
	[Address(RVA = "0x2761FD8", Offset = "0x2761FD8", VA = "0x2761FD8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
