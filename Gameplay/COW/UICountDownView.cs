using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003489")]
public class UICountDownView : UIBaseView
{
	[Token(Token = "0x4014730")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget UICountDown;

	[Token(Token = "0x4014731")]
	[FieldOffset(Offset = "0x18")]
	public UICenterTargetHelper CenterHelper;

	[Token(Token = "0x4014732")]
	[FieldOffset(Offset = "0x1C")]
	public UICountDownLabel CountDownLabel;

	[Token(Token = "0x4014733")]
	[FieldOffset(Offset = "0x20")]
	public UILabel LabelContent;

	[Token(Token = "0x4014734")]
	[FieldOffset(Offset = "0x24")]
	public UISprite CountDownIcon;

	[Token(Token = "0x4014735")]
	[FieldOffset(Offset = "0x28")]
	public UIButton CountDownIconBtn;

	[Token(Token = "0x4014736")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite CountDownBg;

	[Token(Token = "0x4014737")]
	[FieldOffset(Offset = "0x30")]
	public GameObject CountdownBar;

	[Token(Token = "0x601614F")]
	[Address(RVA = "0x1EC2E1C", Offset = "0x1EC2E1C", VA = "0x1EC2E1C")]
	public UICountDownView()
	{
	}

	[Token(Token = "0x6016150")]
	[Address(RVA = "0x1EC2E24", Offset = "0x1EC2E24", VA = "0x1EC2E24", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016151")]
	[Address(RVA = "0x1EC3260", Offset = "0x1EC3260", VA = "0x1EC3260")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
