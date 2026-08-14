using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A08")]
public class UITrainingCampMsgCheckWndView : UIBaseView
{
	[Token(Token = "0x40187B3")]
	[FieldOffset(Offset = "0x14")]
	public UINetworkTexture CDNBG;

	[Token(Token = "0x40187B4")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Title;

	[Token(Token = "0x40187B5")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Message;

	[Token(Token = "0x40187B6")]
	[FieldOffset(Offset = "0x20")]
	public UIButton AcceptBtn;

	[Token(Token = "0x40187B7")]
	[FieldOffset(Offset = "0x24")]
	public UIButton RejectBtn;

	[Token(Token = "0x40187B8")]
	[FieldOffset(Offset = "0x28")]
	public UIButton ConfirmBtn;

	[Token(Token = "0x40187B9")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton CancelBtn;

	[Token(Token = "0x40187BA")]
	[FieldOffset(Offset = "0x30")]
	public UIButton CloseBtn;

	[Token(Token = "0x60171BE")]
	[Address(RVA = "0x1C1C050", Offset = "0x1C1C050", VA = "0x1C1C050")]
	public UITrainingCampMsgCheckWndView()
	{
	}

	[Token(Token = "0x60171BF")]
	[Address(RVA = "0x1C1C058", Offset = "0x1C1C058", VA = "0x1C1C058", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60171C0")]
	[Address(RVA = "0x1C1C4A0", Offset = "0x1C1C4A0", VA = "0x1C1C4A0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
