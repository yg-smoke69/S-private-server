using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003808")]
public class UIInvUseUpgradeCardWindowView : UIBaseView
{
	[Token(Token = "0x4016C4F")]
	[FieldOffset(Offset = "0x14")]
	public GameObject InInventoryLobby;

	[Token(Token = "0x4016C50")]
	[FieldOffset(Offset = "0x18")]
	public UIEasyList AvatarEasyList;

	[Token(Token = "0x4016C51")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton LeftBtn;

	[Token(Token = "0x4016C52")]
	[FieldOffset(Offset = "0x20")]
	public UIButton RightBtn;

	[Token(Token = "0x4016C53")]
	[FieldOffset(Offset = "0x24")]
	public UILabel TipsLabel;

	[Token(Token = "0x4016C54")]
	[FieldOffset(Offset = "0x28")]
	public Transform LevelUpRewardContainer;

	[Token(Token = "0x4016C55")]
	[FieldOffset(Offset = "0x2C")]
	public UIGrid LevelUpRewardList;

	[Token(Token = "0x4016C56")]
	[FieldOffset(Offset = "0x30")]
	public BaseItemView Reward1;

	[Token(Token = "0x4016C57")]
	[FieldOffset(Offset = "0x34")]
	public UIButton LevelReward1Btn;

	[Token(Token = "0x4016C58")]
	[FieldOffset(Offset = "0x38")]
	public BaseItemView Reward2;

	[Token(Token = "0x4016C59")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton LevelReward2Btn;

	[Token(Token = "0x4016C5A")]
	[FieldOffset(Offset = "0x40")]
	public UILabel RewardLabel;

	[Token(Token = "0x4016C5B")]
	[FieldOffset(Offset = "0x44")]
	public Transform LevelUpDesc;

	[Token(Token = "0x4016C5C")]
	[FieldOffset(Offset = "0x48")]
	public UILabel roleCurrentLvTxt;

	[Token(Token = "0x4016C5D")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel roleUptoLvTxt;

	[Token(Token = "0x4016C5E")]
	[FieldOffset(Offset = "0x50")]
	public UILabel skillCurrentLvTxt;

	[Token(Token = "0x4016C5F")]
	[FieldOffset(Offset = "0x54")]
	public UILabel skillUptoLvTxt;

	[Token(Token = "0x4016C60")]
	[FieldOffset(Offset = "0x58")]
	public UIButton UseBtn;

	[Token(Token = "0x4016C61")]
	[FieldOffset(Offset = "0x5C")]
	public UISprite BtnBG;

	[Token(Token = "0x4016C62")]
	[FieldOffset(Offset = "0x60")]
	public UIButton GotoBtn;

	[Token(Token = "0x4016C63")]
	[FieldOffset(Offset = "0x64")]
	public UILabel ExpireInfo;

	[Token(Token = "0x6016BC3")]
	[Address(RVA = "0x1284DB0", Offset = "0x1284DB0", VA = "0x1284DB0")]
	public UIInvUseUpgradeCardWindowView()
	{
	}

	[Token(Token = "0x6016BC4")]
	[Address(RVA = "0x1284DB8", Offset = "0x1284DB8", VA = "0x1284DB8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016BC5")]
	[Address(RVA = "0x1285684", Offset = "0x1285684", VA = "0x1285684")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
