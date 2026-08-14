using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034A4")]
public class UICupMatchTeamInviteItemView : UIBaseView
{
	[Token(Token = "0x40148C6")]
	[FieldOffset(Offset = "0x14")]
	public Transform BaseProfile;

	[Token(Token = "0x40148C7")]
	[FieldOffset(Offset = "0x18")]
	public UIButton Invite;

	[Token(Token = "0x40148C8")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Tips;

	[Token(Token = "0x60161A0")]
	[Address(RVA = "0x2ABF844", Offset = "0x2ABF844", VA = "0x2ABF844")]
	public UICupMatchTeamInviteItemView()
	{
	}

	[Token(Token = "0x60161A1")]
	[Address(RVA = "0x2ABF84C", Offset = "0x2ABF84C", VA = "0x2ABF84C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60161A2")]
	[Address(RVA = "0x2ABFA8C", Offset = "0x2ABFA8C", VA = "0x2ABFA8C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
