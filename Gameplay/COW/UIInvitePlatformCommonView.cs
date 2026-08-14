using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003806")]
public class UIInvitePlatformCommonView : UIBaseView
{
	[Token(Token = "0x4016C41")]
	[FieldOffset(Offset = "0x14")]
	public UIGrid GridInterAppInvite;

	[Token(Token = "0x4016C42")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BtnCopyLink;

	[Token(Token = "0x4016C43")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnLineInvite;

	[Token(Token = "0x4016C44")]
	[FieldOffset(Offset = "0x20")]
	public UIButton BtnBindInvite;

	[Token(Token = "0x4016C45")]
	[FieldOffset(Offset = "0x24")]
	public UISprite BindInviteSprite;

	[Token(Token = "0x4016C46")]
	[FieldOffset(Offset = "0x28")]
	public UIButton BtnOtherInvite;

	[Token(Token = "0x4016C47")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel Tips;

	[Token(Token = "0x6016BBD")]
	[Address(RVA = "0x1ADBAE0", Offset = "0x1ADBAE0", VA = "0x1ADBAE0")]
	public UIInvitePlatformCommonView()
	{
	}

	[Token(Token = "0x6016BBE")]
	[Address(RVA = "0x1ADBAE8", Offset = "0x1ADBAE8", VA = "0x1ADBAE8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016BBF")]
	[Address(RVA = "0x1ADBED0", Offset = "0x1ADBED0", VA = "0x1ADBED0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
