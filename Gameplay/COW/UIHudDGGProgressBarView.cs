using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003637")]
public class UIHudDGGProgressBarView : UIBaseView
{
	[Token(Token = "0x4015BE3")]
	[FieldOffset(Offset = "0x14")]
	public UILabel TimeLabel;

	[Token(Token = "0x4015BE4")]
	[FieldOffset(Offset = "0x18")]
	public UIProgressBar MyBar;

	[Token(Token = "0x4015BE5")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite MyBarValue;

	[Token(Token = "0x4015BE6")]
	[FieldOffset(Offset = "0x20")]
	public UIProgressBar TargetBar;

	[Token(Token = "0x4015BE7")]
	[FieldOffset(Offset = "0x24")]
	public UISprite TargetBarValue;

	[Token(Token = "0x4015BE8")]
	[FieldOffset(Offset = "0x28")]
	public Transform MyThump;

	[Token(Token = "0x4015BE9")]
	[FieldOffset(Offset = "0x2C")]
	public Transform TargetThump;

	[Token(Token = "0x4015BEA")]
	[FieldOffset(Offset = "0x30")]
	public UILabel TargetThumpLabel;

	[Token(Token = "0x4015BEB")]
	[FieldOffset(Offset = "0x34")]
	public Transform WarningThump;

	[Token(Token = "0x4015BEC")]
	[FieldOffset(Offset = "0x38")]
	public UIWidget TutorialWidget;

	[Token(Token = "0x6016652")]
	[Address(RVA = "0x1CCCD70", Offset = "0x1CCCD70", VA = "0x1CCCD70")]
	public UIHudDGGProgressBarView()
	{
	}

	[Token(Token = "0x6016653")]
	[Address(RVA = "0x1CCCD78", Offset = "0x1CCCD78", VA = "0x1CCCD78", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016654")]
	[Address(RVA = "0x1CCD208", Offset = "0x1CCD208", VA = "0x1CCD208")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
