using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A09")]
public class UITrainingCampMsgItemView : UIBaseView
{
	[Token(Token = "0x40187BB")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget CallSignPos;

	[Token(Token = "0x40187BC")]
	[FieldOffset(Offset = "0x18")]
	public UILabel MsgText;

	[Token(Token = "0x40187BD")]
	[FieldOffset(Offset = "0x1C")]
	public UICountDownLabel TimeText;

	[Token(Token = "0x40187BE")]
	[FieldOffset(Offset = "0x20")]
	public UIButton AcceptBtn;

	[Token(Token = "0x40187BF")]
	[FieldOffset(Offset = "0x24")]
	public UIButton CheckBtn;

	[Token(Token = "0x60171C1")]
	[Address(RVA = "0x1C1D96C", Offset = "0x1C1D96C", VA = "0x1C1D96C")]
	public UITrainingCampMsgItemView()
	{
	}

	[Token(Token = "0x60171C2")]
	[Address(RVA = "0x1C1D974", Offset = "0x1C1D974", VA = "0x1C1D974", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60171C3")]
	[Address(RVA = "0x1C1DC9C", Offset = "0x1C1DC9C", VA = "0x1C1DC9C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
