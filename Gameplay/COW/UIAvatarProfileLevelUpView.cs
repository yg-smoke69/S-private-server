using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033D3")]
public class UIAvatarProfileLevelUpView : UIBaseView
{
	[Token(Token = "0x4013D92")]
	[FieldOffset(Offset = "0x14")]
	public Transform BGTopPos2;

	[Token(Token = "0x4013D93")]
	[FieldOffset(Offset = "0x18")]
	public Transform BGBottomPos2;

	[Token(Token = "0x4013D94")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel TitleLabel;

	[Token(Token = "0x4013D95")]
	[FieldOffset(Offset = "0x20")]
	public UIGrid InfoGrid;

	[Token(Token = "0x4013D96")]
	[FieldOffset(Offset = "0x24")]
	public Transform LevelUpDesc;

	[Token(Token = "0x4013D97")]
	[FieldOffset(Offset = "0x28")]
	public UIGrid LevelGrid;

	[Token(Token = "0x4013D98")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject ProfileLv;

	[Token(Token = "0x4013D99")]
	[FieldOffset(Offset = "0x30")]
	public UILabel oldProfileLv;

	[Token(Token = "0x4013D9A")]
	[FieldOffset(Offset = "0x34")]
	public UILabel nowProfileLv;

	[Token(Token = "0x4013D9B")]
	[FieldOffset(Offset = "0x38")]
	public GameObject SkillLv;

	[Token(Token = "0x4013D9C")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel oldSkillLv;

	[Token(Token = "0x4013D9D")]
	[FieldOffset(Offset = "0x40")]
	public UILabel nowSkillLv;

	[Token(Token = "0x4013D9E")]
	[FieldOffset(Offset = "0x44")]
	public GameObject RewardInfo;

	[Token(Token = "0x4013D9F")]
	[FieldOffset(Offset = "0x48")]
	public Transform RewardContainer;

	[Token(Token = "0x4013DA0")]
	[FieldOffset(Offset = "0x4C")]
	public UIGrid RewardList;

	[Token(Token = "0x4013DA1")]
	[FieldOffset(Offset = "0x50")]
	public BaseItemView Reward1;

	[Token(Token = "0x4013DA2")]
	[FieldOffset(Offset = "0x54")]
	public UIButton LevelReward1Btn;

	[Token(Token = "0x4013DA3")]
	[FieldOffset(Offset = "0x58")]
	public BaseItemView Reward2;

	[Token(Token = "0x4013DA4")]
	[FieldOffset(Offset = "0x5C")]
	public UIButton LevelReward2Btn;

	[Token(Token = "0x4013DA5")]
	[FieldOffset(Offset = "0x60")]
	public UILabel RewardLabel;

	[Token(Token = "0x4013DA6")]
	[FieldOffset(Offset = "0x64")]
	public UIButton ConfirmBtn;

	[Token(Token = "0x4013DA7")]
	[FieldOffset(Offset = "0x68")]
	public UISprite BtnBG;

	[Token(Token = "0x4013DA8")]
	[FieldOffset(Offset = "0x6C")]
	public UILabel Info;

	[Token(Token = "0x6015F2F")]
	[Address(RVA = "0x2B74DF0", Offset = "0x2B74DF0", VA = "0x2B74DF0")]
	public UIAvatarProfileLevelUpView()
	{
	}

	[Token(Token = "0x6015F30")]
	[Address(RVA = "0x2B74DF8", Offset = "0x2B74DF8", VA = "0x2B74DF8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015F31")]
	[Address(RVA = "0x2B7571C", Offset = "0x2B7571C", VA = "0x2B7571C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
