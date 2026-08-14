using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200394F")]
public class UIRelationshipInviteMsgItemView : UIBaseView
{
	[Token(Token = "0x4017FCD")]
	[FieldOffset(Offset = "0x14")]
	public GameObject BaseProfileInfo;

	[Token(Token = "0x4017FCE")]
	[FieldOffset(Offset = "0x18")]
	public UILabel MsgLabel;

	[Token(Token = "0x4017FCF")]
	[FieldOffset(Offset = "0x1C")]
	public UICountDownLabel TimeLabel;

	[Token(Token = "0x4017FD0")]
	[FieldOffset(Offset = "0x20")]
	public UIButton ShowMsgDetailBtn;

	[Token(Token = "0x4017FD1")]
	[FieldOffset(Offset = "0x24")]
	public UILabel MsgStateLabel;

	[Token(Token = "0x6016F94")]
	[Address(RVA = "0x1E4B740", Offset = "0x1E4B740", VA = "0x1E4B740")]
	public UIRelationshipInviteMsgItemView()
	{
	}

	[Token(Token = "0x6016F95")]
	[Address(RVA = "0x1E4B748", Offset = "0x1E4B748", VA = "0x1E4B748", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016F96")]
	[Address(RVA = "0x1E4BA64", Offset = "0x1E4BA64", VA = "0x1E4BA64")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
