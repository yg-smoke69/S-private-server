using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035C6")]
public class UIHudADSBonusCountdownView : UIBaseView
{
	[Token(Token = "0x401587A")]
	[FieldOffset(Offset = "0x14")]
	public UIProgressBar ProgressBarBg;

	[Token(Token = "0x401587B")]
	[FieldOffset(Offset = "0x18")]
	public UISprite ProgressBarBgSprite;

	[Token(Token = "0x401587C")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite ProgressbarForSprite;

	[Token(Token = "0x401587D")]
	[FieldOffset(Offset = "0x20")]
	public UILabel BonusTimeLabel;

	[Token(Token = "0x6016500")]
	[Address(RVA = "0x1637468", Offset = "0x1637468", VA = "0x1637468")]
	public UIHudADSBonusCountdownView()
	{
	}

	[Token(Token = "0x6016501")]
	[Address(RVA = "0x1637470", Offset = "0x1637470", VA = "0x1637470", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016502")]
	[Address(RVA = "0x1637738", Offset = "0x1637738", VA = "0x1637738")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
