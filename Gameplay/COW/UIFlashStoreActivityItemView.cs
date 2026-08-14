using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003537")]
public class UIFlashStoreActivityItemView : UIBaseView
{
	[Token(Token = "0x40150A7")]
	[FieldOffset(Offset = "0x14")]
	public UILabel DescriptionLabel;

	[Token(Token = "0x40150A8")]
	[FieldOffset(Offset = "0x18")]
	public UILabel ProgressLabel;

	[Token(Token = "0x40150A9")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton GoBtn;

	[Token(Token = "0x40150AA")]
	[FieldOffset(Offset = "0x20")]
	public UIButton ClaimBtn;

	[Token(Token = "0x40150AB")]
	[FieldOffset(Offset = "0x24")]
	public GameObject ClaimedGroup;

	[Token(Token = "0x40150AC")]
	[FieldOffset(Offset = "0x28")]
	public Animation OnStartAnim;

	[Token(Token = "0x40150AD")]
	[FieldOffset(Offset = "0x2C")]
	public UIGrid AwardItemGrid;

	[Token(Token = "0x40150AE")]
	[FieldOffset(Offset = "0x30")]
	public UILabel GoBtnLabel;

	[Token(Token = "0x6016355")]
	[Address(RVA = "0x1DC5910", Offset = "0x1DC5910", VA = "0x1DC5910")]
	public UIFlashStoreActivityItemView()
	{
	}

	[Token(Token = "0x6016356")]
	[Address(RVA = "0x1DC5918", Offset = "0x1DC5918", VA = "0x1DC5918", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016357")]
	[Address(RVA = "0x1DC5D54", Offset = "0x1DC5D54", VA = "0x1DC5D54")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
