using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038E6")]
public class UIPaymentDiamondEventView : UIBaseView
{
	[Token(Token = "0x40179EF")]
	[FieldOffset(Offset = "0x14")]
	public GameObject BeforeBuy;

	[Token(Token = "0x40179F0")]
	[FieldOffset(Offset = "0x18")]
	public Transform ItemList;

	[Token(Token = "0x40179F1")]
	[FieldOffset(Offset = "0x1C")]
	public UICountDownLabel EndTime;

	[Token(Token = "0x40179F2")]
	[FieldOffset(Offset = "0x20")]
	public UIProgressBar ProgressBar;

	[Token(Token = "0x40179F3")]
	[FieldOffset(Offset = "0x24")]
	public UILabel Count;

	[Token(Token = "0x40179F4")]
	[FieldOffset(Offset = "0x28")]
	public UILabel Count1;

	[Token(Token = "0x40179F5")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel Count2;

	[Token(Token = "0x40179F6")]
	[FieldOffset(Offset = "0x30")]
	public UILabel Count3;

	[Token(Token = "0x40179F7")]
	[FieldOffset(Offset = "0x34")]
	public UILabel Count4;

	[Token(Token = "0x40179F8")]
	[FieldOffset(Offset = "0x38")]
	public UIPanel VFXRoot;

	[Token(Token = "0x40179F9")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton GoPosButton;

	[Token(Token = "0x40179FA")]
	[FieldOffset(Offset = "0x40")]
	public UILabel GoPosLabel;

	[Token(Token = "0x40179FB")]
	[FieldOffset(Offset = "0x44")]
	public UISprite GoPosIcon;

	[Token(Token = "0x40179FC")]
	[FieldOffset(Offset = "0x48")]
	public UILabel purchasingCountLabel;

	[Token(Token = "0x40179FD")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject AfterBuy;

	[Token(Token = "0x40179FE")]
	[FieldOffset(Offset = "0x50")]
	public UILabel DiamondGotLabel;

	[Token(Token = "0x6016E5B")]
	[Address(RVA = "0x28851F4", Offset = "0x28851F4", VA = "0x28851F4")]
	public UIPaymentDiamondEventView()
	{
	}

	[Token(Token = "0x6016E5C")]
	[Address(RVA = "0x28851FC", Offset = "0x28851FC", VA = "0x28851FC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016E5D")]
	[Address(RVA = "0x2885904", Offset = "0x2885904", VA = "0x2885904")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
