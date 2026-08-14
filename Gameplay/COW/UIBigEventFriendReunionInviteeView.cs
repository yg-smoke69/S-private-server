using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033F8")]
public class UIBigEventFriendReunionInviteeView : UIBaseView
{
	[Token(Token = "0x4014018")]
	[FieldOffset(Offset = "0x14")]
	public GameObject SearchBarContainer;

	[Token(Token = "0x4014019")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget UIBigEventFriendReunionInvitee;

	[Token(Token = "0x401401A")]
	[FieldOffset(Offset = "0x1C")]
	public UIInput InvitationInput;

	[Token(Token = "0x401401B")]
	[FieldOffset(Offset = "0x20")]
	public UILabel PlaceholderLabel;

	[Token(Token = "0x401401C")]
	[FieldOffset(Offset = "0x24")]
	public GameObject InviteeDescription;

	[Token(Token = "0x401401D")]
	[FieldOffset(Offset = "0x28")]
	public UIButton ClaimButton;

	[Token(Token = "0x401401E")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite ReunionInviterItemBg;

	[Token(Token = "0x6015F9C")]
	[Address(RVA = "0x141C310", Offset = "0x141C310", VA = "0x141C310")]
	public UIBigEventFriendReunionInviteeView()
	{
	}

	[Token(Token = "0x6015F9D")]
	[Address(RVA = "0x141C318", Offset = "0x141C318", VA = "0x141C318", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015F9E")]
	[Address(RVA = "0x141C6E8", Offset = "0x141C6E8", VA = "0x141C6E8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
