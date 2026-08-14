using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036CE")]
public class UIHudPartyGameSoloDanceInvitationView : UIBaseView
{
	[Token(Token = "0x40161FA")]
	[FieldOffset(Offset = "0x14")]
	public GameObject GoInvitedPanel;

	[Token(Token = "0x40161FB")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BtnRejectInvitaion;

	[Token(Token = "0x40161FC")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnAcceptInvitaion;

	[Token(Token = "0x40161FD")]
	[FieldOffset(Offset = "0x20")]
	public UIToggle ToggleDismissInvitation;

	[Token(Token = "0x6016817")]
	[Address(RVA = "0x1841B08", Offset = "0x1841B08", VA = "0x1841B08")]
	public UIHudPartyGameSoloDanceInvitationView()
	{
	}

	[Token(Token = "0x6016818")]
	[Address(RVA = "0x1841B10", Offset = "0x1841B10", VA = "0x1841B10", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016819")]
	[Address(RVA = "0x1841D18", Offset = "0x1841D18", VA = "0x1841D18")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
