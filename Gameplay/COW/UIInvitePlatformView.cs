using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003807")]
public class UIInvitePlatformView : UIBaseView
{
	[Token(Token = "0x4016C48")]
	[FieldOffset(Offset = "0x14")]
	public UIGrid GridInterAppInvite;

	[Token(Token = "0x4016C49")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BtnCopyLink;

	[Token(Token = "0x4016C4A")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnLineInvite;

	[Token(Token = "0x4016C4B")]
	[FieldOffset(Offset = "0x20")]
	public UIButton BtnFBInvite;

	[Token(Token = "0x4016C4C")]
	[FieldOffset(Offset = "0x24")]
	public UIButton BtnVKInvite;

	[Token(Token = "0x4016C4D")]
	[FieldOffset(Offset = "0x28")]
	public UIButton BtnOtherInvite;

	[Token(Token = "0x4016C4E")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel Tips;

	[Token(Token = "0x6016BC0")]
	[Address(RVA = "0x1ADE520", Offset = "0x1ADE520", VA = "0x1ADE520")]
	public UIInvitePlatformView()
	{
	}

	[Token(Token = "0x6016BC1")]
	[Address(RVA = "0x1ADE528", Offset = "0x1ADE528", VA = "0x1ADE528", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016BC2")]
	[Address(RVA = "0x1ADE910", Offset = "0x1ADE910", VA = "0x1ADE910")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
