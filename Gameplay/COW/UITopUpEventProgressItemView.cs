using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A01")]
public class UITopUpEventProgressItemView : UIBaseView
{
	[Token(Token = "0x4018756")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget Bounds;

	[Token(Token = "0x4018757")]
	[FieldOffset(Offset = "0x18")]
	public GameObject BreeathVFX;

	[Token(Token = "0x4018758")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite LuckyProgressBarFront;

	[Token(Token = "0x4018759")]
	[FieldOffset(Offset = "0x20")]
	public UIProgressBar ProgressBar;

	[Token(Token = "0x401875A")]
	[FieldOffset(Offset = "0x24")]
	public UILabel DiamondCountLabel;

	[Token(Token = "0x401875B")]
	[FieldOffset(Offset = "0x28")]
	public Transform DiamondCountLabelNormalTrans;

	[Token(Token = "0x401875C")]
	[FieldOffset(Offset = "0x2C")]
	public Transform DiamondCountLabelLastTrans;

	[Token(Token = "0x60171A9")]
	[Address(RVA = "0x2AF8654", Offset = "0x2AF8654", VA = "0x2AF8654")]
	public UITopUpEventProgressItemView()
	{
	}

	[Token(Token = "0x60171AA")]
	[Address(RVA = "0x2AF865C", Offset = "0x2AF865C", VA = "0x2AF865C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60171AB")]
	[Address(RVA = "0x2AF89E8", Offset = "0x2AF89E8", VA = "0x2AF89E8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
