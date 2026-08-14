using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003817")]
public class UILauncherView : UIBaseView
{
	[Token(Token = "0x4016D28")]
	[FieldOffset(Offset = "0x14")]
	public UILabel ProgressText;

	[Token(Token = "0x4016D29")]
	[FieldOffset(Offset = "0x18")]
	public UIProgressBar ProgressBar;

	[Token(Token = "0x4016D2A")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject ProgressRightEnd;

	[Token(Token = "0x4016D2B")]
	[FieldOffset(Offset = "0x20")]
	public UISprite LauncherLogo;

	[Token(Token = "0x4016D2C")]
	[FieldOffset(Offset = "0x24")]
	public UITexture Bg;

	[Token(Token = "0x6016BF0")]
	[Address(RVA = "0x1A886A8", Offset = "0x1A886A8", VA = "0x1A886A8")]
	public UILauncherView()
	{
	}

	[Token(Token = "0x6016BF1")]
	[Address(RVA = "0x1A886B0", Offset = "0x1A886B0", VA = "0x1A886B0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016BF2")]
	[Address(RVA = "0x1A889CC", Offset = "0x1A889CC", VA = "0x1A889CC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
