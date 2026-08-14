using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200348C")]
public class UICreateCharacterView : UIBaseView
{
	[Token(Token = "0x4014742")]
	[FieldOffset(Offset = "0x14")]
	public Animation AnimSwitch;

	[Token(Token = "0x4014743")]
	[FieldOffset(Offset = "0x18")]
	public GameObject RegisterPanel;

	[Token(Token = "0x4014744")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LabelNameFinish;

	[Token(Token = "0x4014745")]
	[FieldOffset(Offset = "0x20")]
	public UIInput InputNickName;

	[Token(Token = "0x4014746")]
	[FieldOffset(Offset = "0x24")]
	public UIButton Random;

	[Token(Token = "0x4014747")]
	[FieldOffset(Offset = "0x28")]
	public UILabel NickNameLimited;

	[Token(Token = "0x4014748")]
	[FieldOffset(Offset = "0x2C")]
	public UIInput InputCode;

	[Token(Token = "0x4014749")]
	[FieldOffset(Offset = "0x30")]
	public UIButton BtnRegister;

	[Token(Token = "0x401474A")]
	[FieldOffset(Offset = "0x34")]
	public UILabel NickNameErr;

	[Token(Token = "0x401474B")]
	[FieldOffset(Offset = "0x38")]
	public UIButton BtnUseRandom;

	[Token(Token = "0x401474C")]
	[FieldOffset(Offset = "0x3C")]
	public TweenPosition NickNameTween;

	[Token(Token = "0x401474D")]
	[FieldOffset(Offset = "0x40")]
	public UILabel NickNameDuplicate;

	[Token(Token = "0x401474E")]
	[FieldOffset(Offset = "0x44")]
	public UILabel RandomNickName;

	[Token(Token = "0x6016158")]
	[Address(RVA = "0x1EC6738", Offset = "0x1EC6738", VA = "0x1EC6738")]
	public UICreateCharacterView()
	{
	}

	[Token(Token = "0x6016159")]
	[Address(RVA = "0x1EC6740", Offset = "0x1EC6740", VA = "0x1EC6740", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601615A")]
	[Address(RVA = "0x1EC6D5C", Offset = "0x1EC6D5C", VA = "0x1EC6D5C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
