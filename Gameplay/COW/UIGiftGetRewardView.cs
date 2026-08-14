using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035AE")]
public class UIGiftGetRewardView : UIBaseView
{
	[Token(Token = "0x401571D")]
	[FieldOffset(Offset = "0x14")]
	public UISprite BG;

	[Token(Token = "0x401571E")]
	[FieldOffset(Offset = "0x18")]
	public TweenColor tweenColor;

	[Token(Token = "0x401571F")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton OKBtn;

	[Token(Token = "0x4015720")]
	[FieldOffset(Offset = "0x20")]
	public UILabel BtnLabel;

	[Token(Token = "0x4015721")]
	[FieldOffset(Offset = "0x24")]
	public UIButton CloseBtn;

	[Token(Token = "0x4015722")]
	[FieldOffset(Offset = "0x28")]
	public UILabel ReceiverName;

	[Token(Token = "0x4015723")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel SenderName;

	[Token(Token = "0x4015724")]
	[FieldOffset(Offset = "0x30")]
	public UILabel Message;

	[Token(Token = "0x4015725")]
	[FieldOffset(Offset = "0x34")]
	public UILabel Title;

	[Token(Token = "0x60164B8")]
	[Address(RVA = "0x21981EC", Offset = "0x21981EC", VA = "0x21981EC")]
	public UIGiftGetRewardView()
	{
	}

	[Token(Token = "0x60164B9")]
	[Address(RVA = "0x21981F4", Offset = "0x21981F4", VA = "0x21981F4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60164BA")]
	[Address(RVA = "0x219869C", Offset = "0x219869C", VA = "0x219869C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
