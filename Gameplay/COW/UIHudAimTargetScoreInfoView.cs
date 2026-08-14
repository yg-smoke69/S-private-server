using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035C8")]
public class UIHudAimTargetScoreInfoView : UIBaseView
{
	[Token(Token = "0x4015891")]
	[FieldOffset(Offset = "0x14")]
	public UILabel AllScoreLabel;

	[Token(Token = "0x4015892")]
	[FieldOffset(Offset = "0x18")]
	public UILabel ScaleScoreLabel;

	[Token(Token = "0x4015893")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel AngleScoreLabel;

	[Token(Token = "0x4015894")]
	[FieldOffset(Offset = "0x20")]
	public UILabel DistScoreLabel;

	[Token(Token = "0x4015895")]
	[FieldOffset(Offset = "0x24")]
	public GameObject BG;

	[Token(Token = "0x4015896")]
	[FieldOffset(Offset = "0x28")]
	public GameObject ChooseBG;

	[Token(Token = "0x4015897")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite TagSprite;

	[Token(Token = "0x6016506")]
	[Address(RVA = "0x17030F4", Offset = "0x17030F4", VA = "0x17030F4")]
	public UIHudAimTargetScoreInfoView()
	{
	}

	[Token(Token = "0x6016507")]
	[Address(RVA = "0x17030FC", Offset = "0x17030FC", VA = "0x17030FC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016508")]
	[Address(RVA = "0x17033E0", Offset = "0x17033E0", VA = "0x17033E0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
