using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200341D")]
public class UIChampionshipTeamInviteItemView : UIBaseView
{
	[Token(Token = "0x4014205")]
	[FieldOffset(Offset = "0x14")]
	public Transform BaseProfile;

	[Token(Token = "0x4014206")]
	[FieldOffset(Offset = "0x18")]
	public UIButton Invite;

	[Token(Token = "0x4014207")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Tips;

	[Token(Token = "0x601600B")]
	[Address(RVA = "0x2614898", Offset = "0x2614898", VA = "0x2614898")]
	public UIChampionshipTeamInviteItemView()
	{
	}

	[Token(Token = "0x601600C")]
	[Address(RVA = "0x26148A0", Offset = "0x26148A0", VA = "0x26148A0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601600D")]
	[Address(RVA = "0x2614AE0", Offset = "0x2614AE0", VA = "0x2614AE0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
