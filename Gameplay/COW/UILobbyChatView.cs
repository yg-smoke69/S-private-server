using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200383B")]
public class UILobbyChatView : UIBaseView
{
	[Token(Token = "0x4016F07")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ChatBtn;

	[Token(Token = "0x4016F08")]
	[FieldOffset(Offset = "0x18")]
	public UIButton RecruitBtn;

	[Token(Token = "0x4016F09")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton FastSendGiftBtn;

	[Token(Token = "0x4016F0A")]
	[FieldOffset(Offset = "0x20")]
	public GameObject LatestMessage;

	[Token(Token = "0x4016F0B")]
	[FieldOffset(Offset = "0x24")]
	public UILabel LatestMessageLabel;

	[Token(Token = "0x4016F0C")]
	[FieldOffset(Offset = "0x28")]
	public UIButton ChatMessageBtn;

	[Token(Token = "0x6016C5C")]
	[Address(RVA = "0x216FD8C", Offset = "0x216FD8C", VA = "0x216FD8C")]
	public UILobbyChatView()
	{
	}

	[Token(Token = "0x6016C5D")]
	[Address(RVA = "0x216FD94", Offset = "0x216FD94", VA = "0x216FD94", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016C5E")]
	[Address(RVA = "0x2170110", Offset = "0x2170110", VA = "0x2170110")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
