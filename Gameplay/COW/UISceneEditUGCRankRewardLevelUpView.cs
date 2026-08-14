using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200399F")]
public class UISceneEditUGCRankRewardLevelUpView : UIBaseView
{
	[Token(Token = "0x4018297")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ContinueBtn;

	[Token(Token = "0x4018298")]
	[FieldOffset(Offset = "0x18")]
	public UISprite Before;

	[Token(Token = "0x4018299")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite After;

	[Token(Token = "0x401829A")]
	[FieldOffset(Offset = "0x20")]
	public Animation RewardAni;

	[Token(Token = "0x401829B")]
	[FieldOffset(Offset = "0x24")]
	public GameObject RewardResult;

	[Token(Token = "0x401829C")]
	[FieldOffset(Offset = "0x28")]
	public GameObject LevelUpResult;

	[Token(Token = "0x401829D")]
	[FieldOffset(Offset = "0x2C")]
	public Transform LeftAwardGrid;

	[Token(Token = "0x401829E")]
	[FieldOffset(Offset = "0x30")]
	public Transform MidAwardGrid;

	[Token(Token = "0x401829F")]
	[FieldOffset(Offset = "0x34")]
	public Transform RightAwardGrid;

	[Token(Token = "0x40182A0")]
	[FieldOffset(Offset = "0x38")]
	public Transform FirstAwardGrid;

	[Token(Token = "0x40182A1")]
	[FieldOffset(Offset = "0x3C")]
	public Transform SecondAwardGrid;

	[Token(Token = "0x40182A2")]
	[FieldOffset(Offset = "0x40")]
	public GameObject RewardTitle;

	[Token(Token = "0x40182A3")]
	[FieldOffset(Offset = "0x44")]
	public UILabel RankNameBefore;

	[Token(Token = "0x40182A4")]
	[FieldOffset(Offset = "0x48")]
	public UILabel RankNameAfter;

	[Token(Token = "0x6017084")]
	[Address(RVA = "0x1A40D8C", Offset = "0x1A40D8C", VA = "0x1A40D8C")]
	public UISceneEditUGCRankRewardLevelUpView()
	{
	}

	[Token(Token = "0x6017085")]
	[Address(RVA = "0x1A40D94", Offset = "0x1A40D94", VA = "0x1A40D94", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017086")]
	[Address(RVA = "0x1A41330", Offset = "0x1A41330", VA = "0x1A41330")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
