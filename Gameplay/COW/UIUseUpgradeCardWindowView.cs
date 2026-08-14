using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A4D")]
public class UIUseUpgradeCardWindowView : UIBaseView
{
	[Token(Token = "0x4018A54")]
	[FieldOffset(Offset = "0x14")]
	public GameObject InAvatarProfile;

	[Token(Token = "0x4018A55")]
	[FieldOffset(Offset = "0x18")]
	public UISprite cAvatarHeadSp;

	[Token(Token = "0x4018A56")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel cAavatarName;

	[Token(Token = "0x4018A57")]
	[FieldOffset(Offset = "0x20")]
	public UIGrid LevelCardList;

	[Token(Token = "0x4018A58")]
	[FieldOffset(Offset = "0x24")]
	public GameObject InInventoryLobby;

	[Token(Token = "0x4018A59")]
	[FieldOffset(Offset = "0x28")]
	public UIEasyList AvatarEasyList;

	[Token(Token = "0x4018A5A")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton LeftBtn;

	[Token(Token = "0x4018A5B")]
	[FieldOffset(Offset = "0x30")]
	public UIButton RightBtn;

	[Token(Token = "0x4018A5C")]
	[FieldOffset(Offset = "0x34")]
	public UILabel TipsLabel;

	[Token(Token = "0x4018A5D")]
	[FieldOffset(Offset = "0x38")]
	public Transform LevelUpRewardContainer;

	[Token(Token = "0x4018A5E")]
	[FieldOffset(Offset = "0x3C")]
	public UIGrid LevelUpRewardList;

	[Token(Token = "0x4018A5F")]
	[FieldOffset(Offset = "0x40")]
	public BaseItemView Reward1;

	[Token(Token = "0x4018A60")]
	[FieldOffset(Offset = "0x44")]
	public UIButton LevelReward1Btn;

	[Token(Token = "0x4018A61")]
	[FieldOffset(Offset = "0x48")]
	public BaseItemView Reward2;

	[Token(Token = "0x4018A62")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton LevelReward2Btn;

	[Token(Token = "0x4018A63")]
	[FieldOffset(Offset = "0x50")]
	public UILabel RewardLabel;

	[Token(Token = "0x4018A64")]
	[FieldOffset(Offset = "0x54")]
	public Transform LevelUpDesc;

	[Token(Token = "0x4018A65")]
	[FieldOffset(Offset = "0x58")]
	public UILabel roleCurrentLvTxt;

	[Token(Token = "0x4018A66")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel roleUptoLvTxt;

	[Token(Token = "0x4018A67")]
	[FieldOffset(Offset = "0x60")]
	public UILabel skillCurrentLvTxt;

	[Token(Token = "0x4018A68")]
	[FieldOffset(Offset = "0x64")]
	public UILabel skillUptoLvTxt;

	[Token(Token = "0x4018A69")]
	[FieldOffset(Offset = "0x68")]
	public UIButton UseBtn;

	[Token(Token = "0x4018A6A")]
	[FieldOffset(Offset = "0x6C")]
	public UISprite BtnBG;

	[Token(Token = "0x4018A6B")]
	[FieldOffset(Offset = "0x70")]
	public UIButton GotoBtn;

	[Token(Token = "0x4018A6C")]
	[FieldOffset(Offset = "0x74")]
	public UILabel ExpireInfo;

	[Token(Token = "0x601728D")]
	[Address(RVA = "0xF5AB50", Offset = "0xF5AB50", VA = "0xF5AB50")]
	public UIUseUpgradeCardWindowView()
	{
	}

	[Token(Token = "0x601728E")]
	[Address(RVA = "0xF5AB58", Offset = "0xF5AB58", VA = "0xF5AB58", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601728F")]
	[Address(RVA = "0xF5B598", Offset = "0xF5B598", VA = "0xF5B598")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
