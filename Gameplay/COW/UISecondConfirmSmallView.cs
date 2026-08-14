using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039A5")]
public class UISecondConfirmSmallView : UIBaseView
{
	[Token(Token = "0x401831E")]
	[FieldOffset(Offset = "0x14")]
	public UIButton CancelBtn;

	[Token(Token = "0x401831F")]
	[FieldOffset(Offset = "0x18")]
	public UIButton ConfirmBtn;

	[Token(Token = "0x4018320")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject OneTextStyle;

	[Token(Token = "0x4018321")]
	[FieldOffset(Offset = "0x20")]
	public UILabel OneTextContent;

	[Token(Token = "0x4018322")]
	[FieldOffset(Offset = "0x24")]
	public UILabel CancelBtnLabel;

	[Token(Token = "0x4018323")]
	[FieldOffset(Offset = "0x28")]
	public UILabel ConfirmBtnLabel;

	[Token(Token = "0x6017096")]
	[Address(RVA = "0x1A4FF98", Offset = "0x1A4FF98", VA = "0x1A4FF98")]
	public UISecondConfirmSmallView()
	{
	}

	[Token(Token = "0x6017097")]
	[Address(RVA = "0x1A4FFA0", Offset = "0x1A4FFA0", VA = "0x1A4FFA0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017098")]
	[Address(RVA = "0x1A5031C", Offset = "0x1A5031C", VA = "0x1A5031C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
