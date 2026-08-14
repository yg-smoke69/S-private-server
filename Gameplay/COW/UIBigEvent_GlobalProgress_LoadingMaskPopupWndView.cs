using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033EF")]
public class UIBigEvent_GlobalProgress_LoadingMaskPopupWndView : UIBaseView
{
	[Token(Token = "0x4013FB7")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnClose;

	[Token(Token = "0x4013FB8")]
	[FieldOffset(Offset = "0x18")]
	public UILabel ProgressLabel;

	[Token(Token = "0x4013FB9")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject LoadingGIF;

	[Token(Token = "0x4013FBA")]
	[FieldOffset(Offset = "0x20")]
	public UIProgressBar WebViewProgressBar;

	[Token(Token = "0x4013FBB")]
	[FieldOffset(Offset = "0x24")]
	public UIWidget WebViewProgressBarThumb;

	[Token(Token = "0x6015F81")]
	[Address(RVA = "0x3028EEC", Offset = "0x3028EEC", VA = "0x3028EEC")]
	public UIBigEvent_GlobalProgress_LoadingMaskPopupWndView()
	{
	}

	[Token(Token = "0x6015F82")]
	[Address(RVA = "0x3028EF4", Offset = "0x3028EF4", VA = "0x3028EF4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015F83")]
	[Address(RVA = "0x3029210", Offset = "0x3029210", VA = "0x3029210")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
