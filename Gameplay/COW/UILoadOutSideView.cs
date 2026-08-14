using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003836")]
public class UILoadOutSideView : UIBaseView
{
	[Token(Token = "0x4016ED2")]
	[FieldOffset(Offset = "0x14")]
	public UIButton Mask;

	[Token(Token = "0x4016ED3")]
	[FieldOffset(Offset = "0x18")]
	public UIButton SurvivalInfoBtn;

	[Token(Token = "0x4016ED4")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel SurvivalLoadoutBanned;

	[Token(Token = "0x4016ED5")]
	[FieldOffset(Offset = "0x20")]
	public UIGrid GridNew;

	[Token(Token = "0x4016ED6")]
	[FieldOffset(Offset = "0x24")]
	public UIButton BasicInfoBtn;

	[Token(Token = "0x4016ED7")]
	[FieldOffset(Offset = "0x28")]
	public UILabel BasicLoadoutBanned;

	[Token(Token = "0x4016ED8")]
	[FieldOffset(Offset = "0x2C")]
	public UIGrid GridOld;

	[Token(Token = "0x4016ED9")]
	[FieldOffset(Offset = "0x30")]
	public GameObject SkillContainer;

	[Token(Token = "0x4016EDA")]
	[FieldOffset(Offset = "0x34")]
	public UILabel SkillTitle;

	[Token(Token = "0x4016EDB")]
	[FieldOffset(Offset = "0x38")]
	public UILabel AvatarName;

	[Token(Token = "0x4016EDC")]
	[FieldOffset(Offset = "0x3C")]
	public Transform MainSkillPos;

	[Token(Token = "0x4016EDD")]
	[FieldOffset(Offset = "0x40")]
	public Transform EquipSkillPos1;

	[Token(Token = "0x4016EDE")]
	[FieldOffset(Offset = "0x44")]
	public Transform EquipSkillPos2;

	[Token(Token = "0x4016EDF")]
	[FieldOffset(Offset = "0x48")]
	public Transform EquipSkillPos3;

	[Token(Token = "0x6016C4D")]
	[Address(RVA = "0x2155C7C", Offset = "0x2155C7C", VA = "0x2155C7C")]
	public UILoadOutSideView()
	{
	}

	[Token(Token = "0x6016C4E")]
	[Address(RVA = "0x2155C84", Offset = "0x2155C84", VA = "0x2155C84", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016C4F")]
	[Address(RVA = "0x2156260", Offset = "0x2156260", VA = "0x2156260")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
