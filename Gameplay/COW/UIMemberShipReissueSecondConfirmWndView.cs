using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038A8")]
public class UIMemberShipReissueSecondConfirmWndView : UIBaseView
{
	[Token(Token = "0x40176E4")]
	[FieldOffset(Offset = "0x14")]
	public UIButton CancelBtn;

	[Token(Token = "0x40176E5")]
	[FieldOffset(Offset = "0x18")]
	public UIButton ConfirmBtn;

	[Token(Token = "0x40176E6")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel DescriptionLabel;

	[Token(Token = "0x6016DA3")]
	[Address(RVA = "0x12FF84C", Offset = "0x12FF84C", VA = "0x12FF84C")]
	public UIMemberShipReissueSecondConfirmWndView()
	{
	}

	[Token(Token = "0x6016DA4")]
	[Address(RVA = "0x12FF854", Offset = "0x12FF854", VA = "0x12FF854", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016DA5")]
	[Address(RVA = "0x12FFABC", Offset = "0x12FFABC", VA = "0x12FFABC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
