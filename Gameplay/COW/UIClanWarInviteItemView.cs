using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200345C")]
public class UIClanWarInviteItemView : UIBaseView
{
	[Token(Token = "0x4014550")]
	[FieldOffset(Offset = "0x14")]
	public GameObject ProfileContent;

	[Token(Token = "0x4014551")]
	[FieldOffset(Offset = "0x18")]
	public UIButton InviteBtn;

	[Token(Token = "0x4014552")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject InvitedLabel;

	[Token(Token = "0x4014553")]
	[FieldOffset(Offset = "0x20")]
	public UILabel RoleLabel;

	[Token(Token = "0x4014554")]
	[FieldOffset(Offset = "0x24")]
	public UILabel PresenceLabel;

	[Token(Token = "0x60160C8")]
	[Address(RVA = "0x2B50948", Offset = "0x2B50948", VA = "0x2B50948")]
	public UIClanWarInviteItemView()
	{
	}

	[Token(Token = "0x60160C9")]
	[Address(RVA = "0x2B50950", Offset = "0x2B50950", VA = "0x2B50950", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60160CA")]
	[Address(RVA = "0x2B50C60", Offset = "0x2B50C60", VA = "0x2B50C60")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
