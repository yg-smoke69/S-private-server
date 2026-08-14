using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033A7")]
public class UIActivityFriendReunionInviteeView : UIBaseView
{
	[Token(Token = "0x4013B8F")]
	[FieldOffset(Offset = "0x14")]
	public GameObject SearchBarContainer;

	[Token(Token = "0x4013B90")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget UIActivityFriendReunionInvitee;

	[Token(Token = "0x4013B91")]
	[FieldOffset(Offset = "0x1C")]
	public UIInput InvitationInput;

	[Token(Token = "0x4013B92")]
	[FieldOffset(Offset = "0x20")]
	public UILabel PlaceholderLabel;

	[Token(Token = "0x4013B93")]
	[FieldOffset(Offset = "0x24")]
	public GameObject InviteeDescription;

	[Token(Token = "0x4013B94")]
	[FieldOffset(Offset = "0x28")]
	public UIButton ClaimButton;

	[Token(Token = "0x4013B95")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite ReunionInviterItemBg;

	[Token(Token = "0x6015EAB")]
	[Address(RVA = "0x2FB16E0", Offset = "0x2FB16E0", VA = "0x2FB16E0")]
	public UIActivityFriendReunionInviteeView()
	{
	}

	[Token(Token = "0x6015EAC")]
	[Address(RVA = "0x2FB16E8", Offset = "0x2FB16E8", VA = "0x2FB16E8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015EAD")]
	[Address(RVA = "0x2FB1AB8", Offset = "0x2FB1AB8", VA = "0x2FB1AB8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
