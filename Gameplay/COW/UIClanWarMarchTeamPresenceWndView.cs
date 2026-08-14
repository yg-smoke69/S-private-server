using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200345F")]
public class UIClanWarMarchTeamPresenceWndView : UIBaseView
{
	[Token(Token = "0x4014569")]
	[FieldOffset(Offset = "0x14")]
	public UIGrid GridOfflineMember;

	[Token(Token = "0x401456A")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BtnCancel;

	[Token(Token = "0x401456B")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LabelCancel;

	[Token(Token = "0x401456C")]
	[FieldOffset(Offset = "0x20")]
	public UIButton BtnConfirm;

	[Token(Token = "0x401456D")]
	[FieldOffset(Offset = "0x24")]
	public UILabel LabelConfirm;

	[Token(Token = "0x401456E")]
	[FieldOffset(Offset = "0x28")]
	public UICountDownLabel LabelCountdown;

	[Token(Token = "0x60160D1")]
	[Address(RVA = "0x28FCBD0", Offset = "0x28FCBD0", VA = "0x28FCBD0")]
	public UIClanWarMarchTeamPresenceWndView()
	{
	}

	[Token(Token = "0x60160D2")]
	[Address(RVA = "0x28FCBD8", Offset = "0x28FCBD8", VA = "0x28FCBD8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60160D3")]
	[Address(RVA = "0x28FCF60", Offset = "0x28FCF60", VA = "0x28FCF60")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
