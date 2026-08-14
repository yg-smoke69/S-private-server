using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003832")]
internal class UILoadingView : UIBaseView
{
	[Token(Token = "0x4016EA5")]
	[FieldOffset(Offset = "0x14")]
	public GameObject tips;

	[Token(Token = "0x4016EA6")]
	[FieldOffset(Offset = "0x18")]
	public UILabel modeTips;

	[Token(Token = "0x4016EA7")]
	[FieldOffset(Offset = "0x1C")]
	public UIProgressBar ProgressBar;

	[Token(Token = "0x4016EA8")]
	[FieldOffset(Offset = "0x20")]
	public GameObject BgPanel;

	[Token(Token = "0x4016EA9")]
	[FieldOffset(Offset = "0x24")]
	public GameObject DefaultBg;

	[Token(Token = "0x6016C41")]
	[Address(RVA = "0x215BFAC", Offset = "0x215BFAC", VA = "0x215BFAC")]
	public UILoadingView()
	{
	}

	[Token(Token = "0x6016C42")]
	[Address(RVA = "0x215BFB4", Offset = "0x215BFB4", VA = "0x215BFB4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016C43")]
	[Address(RVA = "0x215C1F8", Offset = "0x215C1F8", VA = "0x215C1F8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
