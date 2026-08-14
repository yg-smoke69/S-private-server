using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033CD")]
public class UIAvatarLinkShareInfoView : UIBaseView
{
	[Token(Token = "0x4013CF5")]
	[FieldOffset(Offset = "0x14")]
	public UILabel LinkTitleLabel;

	[Token(Token = "0x4013CF6")]
	[FieldOffset(Offset = "0x18")]
	public UILabel AvatarNumLabel;

	[Token(Token = "0x4013CF7")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LinkAvatarName;

	[Token(Token = "0x4013CF8")]
	[FieldOffset(Offset = "0x20")]
	public UILabel LinkAvatarDetail;

	[Token(Token = "0x4013CF9")]
	[FieldOffset(Offset = "0x24")]
	public GameObject SkillSlotTrans;

	[Token(Token = "0x4013CFA")]
	[FieldOffset(Offset = "0x28")]
	public UILabel SkillNameLabel;

	[Token(Token = "0x4013CFB")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel SkillTypeLabel;

	[Token(Token = "0x4013CFC")]
	[FieldOffset(Offset = "0x30")]
	public UILabel SkillDescLabel;

	[Token(Token = "0x6015F1D")]
	[Address(RVA = "0x2A9A7D0", Offset = "0x2A9A7D0", VA = "0x2A9A7D0")]
	public UIAvatarLinkShareInfoView()
	{
	}

	[Token(Token = "0x6015F1E")]
	[Address(RVA = "0x2A9A7D8", Offset = "0x2A9A7D8", VA = "0x2A9A7D8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015F1F")]
	[Address(RVA = "0x2A9AC14", Offset = "0x2A9AC14", VA = "0x2A9AC14")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
