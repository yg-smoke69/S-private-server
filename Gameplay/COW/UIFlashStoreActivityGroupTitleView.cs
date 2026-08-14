using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003536")]
public class UIFlashStoreActivityGroupTitleView : UIBaseView
{
	[Token(Token = "0x40150A4")]
	[FieldOffset(Offset = "0x14")]
	public UILabel DescriptionLabel;

	[Token(Token = "0x40150A5")]
	[FieldOffset(Offset = "0x18")]
	public UICountDownLabel CountdownLabel;

	[Token(Token = "0x40150A6")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject TimeIcon;

	[Token(Token = "0x6016352")]
	[Address(RVA = "0x1DC35A0", Offset = "0x1DC35A0", VA = "0x1DC35A0")]
	public UIFlashStoreActivityGroupTitleView()
	{
	}

	[Token(Token = "0x6016353")]
	[Address(RVA = "0x1DC35A8", Offset = "0x1DC35A8", VA = "0x1DC35A8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016354")]
	[Address(RVA = "0x1DC3804", Offset = "0x1DC3804", VA = "0x1DC3804")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
