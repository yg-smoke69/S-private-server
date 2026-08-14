using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034F6")]
public class UIDownloadInfoPopupWindowView : UIBaseView
{
	[Token(Token = "0x4014D4B")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnClose;

	[Token(Token = "0x4014D4C")]
	[FieldOffset(Offset = "0x18")]
	public UILabel TitleLabel;

	[Token(Token = "0x4014D4D")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject SingleHint;

	[Token(Token = "0x4014D4E")]
	[FieldOffset(Offset = "0x20")]
	public UIButton SingleHintCancleBtn;

	[Token(Token = "0x4014D4F")]
	[FieldOffset(Offset = "0x24")]
	public UIButton SingleHintConfirmBtn;

	[Token(Token = "0x4014D50")]
	[FieldOffset(Offset = "0x28")]
	public GameObject DonwloadInfo;

	[Token(Token = "0x4014D51")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton BtnLeft;

	[Token(Token = "0x4014D52")]
	[FieldOffset(Offset = "0x30")]
	public UILabel LeftLabel;

	[Token(Token = "0x4014D53")]
	[FieldOffset(Offset = "0x34")]
	public UIButton BtnRight;

	[Token(Token = "0x4014D54")]
	[FieldOffset(Offset = "0x38")]
	public UILabel RightLabel;

	[Token(Token = "0x4014D55")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel InfoLabel;

	[Token(Token = "0x4014D56")]
	[FieldOffset(Offset = "0x40")]
	public UIProgressBar DownloadProgressBar;

	[Token(Token = "0x4014D57")]
	[FieldOffset(Offset = "0x44")]
	public UILabel DownloadPercent;

	[Token(Token = "0x4014D58")]
	[FieldOffset(Offset = "0x48")]
	public UILabel FileName;

	[Token(Token = "0x4014D59")]
	[FieldOffset(Offset = "0x4C")]
	public TweenAlpha FileNameTween;

	[Token(Token = "0x4014D5A")]
	[FieldOffset(Offset = "0x50")]
	public UILabel PauseHint;

	[Token(Token = "0x4014D5B")]
	[FieldOffset(Offset = "0x54")]
	public GameObject SingleDownloadInfo;

	[Token(Token = "0x4014D5C")]
	[FieldOffset(Offset = "0x58")]
	public UILabel SingleFileSizeInfo;

	[Token(Token = "0x4014D5D")]
	[FieldOffset(Offset = "0x5C")]
	public UIButton SingleDownloadBtn;

	[Token(Token = "0x6016292")]
	[Address(RVA = "0x2769AB4", Offset = "0x2769AB4", VA = "0x2769AB4")]
	public UIDownloadInfoPopupWindowView()
	{
	}

	[Token(Token = "0x6016293")]
	[Address(RVA = "0x2769ABC", Offset = "0x2769ABC", VA = "0x2769ABC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016294")]
	[Address(RVA = "0x276A300", Offset = "0x276A300", VA = "0x276A300")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
