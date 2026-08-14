using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A05")]
public class UITrainingCampGraduateWndView : UIBaseView
{
	[Token(Token = "0x40187A0")]
	[FieldOffset(Offset = "0x14")]
	public UIButton Mask;

	[Token(Token = "0x40187A1")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Title;

	[Token(Token = "0x40187A2")]
	[FieldOffset(Offset = "0x1C")]
	public UIGrid Grid;

	[Token(Token = "0x40187A3")]
	[FieldOffset(Offset = "0x20")]
	public UIButton ConfirmBtn;

	[Token(Token = "0x40187A4")]
	[FieldOffset(Offset = "0x24")]
	public UILabel GraduateInfoLabel;

	[Token(Token = "0x60171B5")]
	[Address(RVA = "0x2B08C6C", Offset = "0x2B08C6C", VA = "0x2B08C6C")]
	public UITrainingCampGraduateWndView()
	{
	}

	[Token(Token = "0x60171B6")]
	[Address(RVA = "0x2B08C74", Offset = "0x2B08C74", VA = "0x2B08C74", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60171B7")]
	[Address(RVA = "0x2B08F9C", Offset = "0x2B08F9C", VA = "0x2B08F9C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
