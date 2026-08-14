using GCommon;
using Il2CppDummyDll;
using Spine.Unity;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034DB")]
public class UIDigitaluniverseBRoleDoorDialogView : UIBaseView
{
	[Token(Token = "0x4014C05")]
	[FieldOffset(Offset = "0x14")]
	public UILabel PlotChapterLabel;

	[Token(Token = "0x4014C06")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BtnStorySelect;

	[Token(Token = "0x4014C07")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnStorySelect2;

	[Token(Token = "0x4014C08")]
	[FieldOffset(Offset = "0x20")]
	public UIButton BtnStorySelect3;

	[Token(Token = "0x4014C09")]
	[FieldOffset(Offset = "0x24")]
	public UILabel LabelStorySelect;

	[Token(Token = "0x4014C0A")]
	[FieldOffset(Offset = "0x28")]
	public UILabel LabelStorySelect2;

	[Token(Token = "0x4014C0B")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel LabelStorySelect3;

	[Token(Token = "0x4014C0C")]
	[FieldOffset(Offset = "0x30")]
	public SkeletonAnimation RoleKelly;

	[Token(Token = "0x4014C0D")]
	[FieldOffset(Offset = "0x34")]
	public SkeletonAnimation RoleHayato;

	[Token(Token = "0x4014C0E")]
	[FieldOffset(Offset = "0x38")]
	public SkeletonAnimation RoleMaxim;

	[Token(Token = "0x4014C0F")]
	[FieldOffset(Offset = "0x3C")]
	public SkeletonAnimation RoleMoco;

	[Token(Token = "0x4014C10")]
	[FieldOffset(Offset = "0x40")]
	public SkeletonAnimation RoleXJ;

	[Token(Token = "0x4014C11")]
	[FieldOffset(Offset = "0x44")]
	public Transform LeftKellyPos;

	[Token(Token = "0x4014C12")]
	[FieldOffset(Offset = "0x48")]
	public Transform RightKellyPos;

	[Token(Token = "0x4014C13")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel LabelTomorrowDialog;

	[Token(Token = "0x4014C14")]
	[FieldOffset(Offset = "0x50")]
	public UIButton BtnDialog;

	[Token(Token = "0x4014C15")]
	[FieldOffset(Offset = "0x54")]
	public UILabel LabelRole;

	[Token(Token = "0x4014C16")]
	[FieldOffset(Offset = "0x58")]
	public UIButton BtnSkip;

	[Token(Token = "0x4014C17")]
	[FieldOffset(Offset = "0x5C")]
	public Transform VFX_Click;

	[Token(Token = "0x4014C18")]
	[FieldOffset(Offset = "0x60")]
	public UILabel PlotChapterLabel_Shadow;

	[Token(Token = "0x4014C19")]
	[FieldOffset(Offset = "0x64")]
	public UILabel LabelRole_Shadow;

	[Token(Token = "0x4014C1A")]
	[FieldOffset(Offset = "0x68")]
	public UILabel LabelRole_L;

	[Token(Token = "0x4014C1B")]
	[FieldOffset(Offset = "0x6C")]
	public UILabel LabelRole_L_Shadow;

	[Token(Token = "0x4014C1C")]
	[FieldOffset(Offset = "0x70")]
	public Transform LeftHayatoPos;

	[Token(Token = "0x4014C1D")]
	[FieldOffset(Offset = "0x74")]
	public Transform LeftMaximPos;

	[Token(Token = "0x4014C1E")]
	[FieldOffset(Offset = "0x78")]
	public Transform LeftMocoPos;

	[Token(Token = "0x4014C1F")]
	[FieldOffset(Offset = "0x7C")]
	public Transform LeftXjPos;

	[Token(Token = "0x4014C20")]
	[FieldOffset(Offset = "0x80")]
	public Transform RightHayatoPos;

	[Token(Token = "0x4014C21")]
	[FieldOffset(Offset = "0x84")]
	public Transform RightMaximPos;

	[Token(Token = "0x4014C22")]
	[FieldOffset(Offset = "0x88")]
	public Transform RightMocoPos;

	[Token(Token = "0x4014C23")]
	[FieldOffset(Offset = "0x8C")]
	public Transform RightXjPos;

	[Token(Token = "0x4014C24")]
	[FieldOffset(Offset = "0x90")]
	public UILabel SkipLabel;

	[Token(Token = "0x6016243")]
	[Address(RVA = "0x2F090B4", Offset = "0x2F090B4", VA = "0x2F090B4")]
	public UIDigitaluniverseBRoleDoorDialogView()
	{
	}

	[Token(Token = "0x6016244")]
	[Address(RVA = "0x2F090BC", Offset = "0x2F090BC", VA = "0x2F090BC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016245")]
	[Address(RVA = "0x2F09C4C", Offset = "0x2F09C4C", VA = "0x2F09C4C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
