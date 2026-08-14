using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003805")]
public class UIInvitePlatformCommonGridView : UIBaseView
{
	[Token(Token = "0x4016C3C")]
	[FieldOffset(Offset = "0x14")]
	public UIGrid GridShareIcon;

	[Token(Token = "0x4016C3D")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BtnCopyInvite;

	[Token(Token = "0x4016C3E")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnLineInvite;

	[Token(Token = "0x4016C3F")]
	[FieldOffset(Offset = "0x20")]
	public UIButton BtnBindInvite;

	[Token(Token = "0x4016C40")]
	[FieldOffset(Offset = "0x24")]
	public UIButton BtnOtherInvite;

	[Token(Token = "0x6016BBA")]
	[Address(RVA = "0x1ADB7A8", Offset = "0x1ADB7A8", VA = "0x1ADB7A8")]
	public UIInvitePlatformCommonGridView()
	{
	}

	[Token(Token = "0x6016BBB")]
	[Address(RVA = "0x1ADB7B0", Offset = "0x1ADB7B0", VA = "0x1ADB7B0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016BBC")]
	[Address(RVA = "0x1ADBAD8", Offset = "0x1ADBAD8", VA = "0x1ADBAD8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
