using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200377D")]
public class UIHudTrainingMiniGameView : UIBaseView
{
	[Token(Token = "0x40167AC")]
	[FieldOffset(Offset = "0x14")]
	public GameObject MiniGameMap;

	[Token(Token = "0x40167AD")]
	[FieldOffset(Offset = "0x18")]
	public Transform CountDown;

	[Token(Token = "0x40167AE")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel labelTips;

	[Token(Token = "0x40167AF")]
	[FieldOffset(Offset = "0x20")]
	public UISprite labelbgwidget;

	[Token(Token = "0x40167B0")]
	[FieldOffset(Offset = "0x24")]
	public UISprite warningIcon;

	[Token(Token = "0x40167B1")]
	[FieldOffset(Offset = "0x28")]
	public UISprite warningwidget;

	[Token(Token = "0x40167B2")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel timeCount;

	[Token(Token = "0x40167B3")]
	[FieldOffset(Offset = "0x30")]
	public TweenAlpha TweenAlpha;

	[Token(Token = "0x40167B4")]
	[FieldOffset(Offset = "0x34")]
	public Transform ScoreInfo;

	[Token(Token = "0x40167B5")]
	[FieldOffset(Offset = "0x38")]
	public UILabel Score;

	[Token(Token = "0x40167B6")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel TargetCount;

	[Token(Token = "0x40167B7")]
	[FieldOffset(Offset = "0x40")]
	public UILabel PopScore;

	[Token(Token = "0x40167B8")]
	[FieldOffset(Offset = "0x44")]
	public Animation AddScoreAnim;

	[Token(Token = "0x40167B9")]
	[FieldOffset(Offset = "0x48")]
	public GameObject PreCountDown;

	[Token(Token = "0x40167BA")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel PreCountNum;

	[Token(Token = "0x40167BB")]
	[FieldOffset(Offset = "0x50")]
	public UIButton QuitGameBtn;

	[Token(Token = "0x40167BC")]
	[FieldOffset(Offset = "0x54")]
	public Transform Victory;

	[Token(Token = "0x40167BD")]
	[FieldOffset(Offset = "0x58")]
	public TweenScale VictoryTween;

	[Token(Token = "0x40167BE")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel VictoryTxt;

	[Token(Token = "0x40167BF")]
	[FieldOffset(Offset = "0x60")]
	public Transform Defeat;

	[Token(Token = "0x40167C0")]
	[FieldOffset(Offset = "0x64")]
	public TweenScale DefeatTween;

	[Token(Token = "0x40167C1")]
	[FieldOffset(Offset = "0x68")]
	public UILabel DefeatTxt;

	[Token(Token = "0x40167C2")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject End;

	[Token(Token = "0x40167C3")]
	[FieldOffset(Offset = "0x70")]
	public Transform Btns;

	[Token(Token = "0x40167C4")]
	[FieldOffset(Offset = "0x74")]
	public UIGrid Grid;

	[Token(Token = "0x40167C5")]
	[FieldOffset(Offset = "0x78")]
	public UIButton ShareBtn;

	[Token(Token = "0x40167C6")]
	[FieldOffset(Offset = "0x7C")]
	public UIButton BackBtn;

	[Token(Token = "0x40167C7")]
	[FieldOffset(Offset = "0x80")]
	public UILabel LabelBack;

	[Token(Token = "0x40167C8")]
	[FieldOffset(Offset = "0x84")]
	public UIButton PlayAgain;

	[Token(Token = "0x40167C9")]
	[FieldOffset(Offset = "0x88")]
	public UIButton SkipMask;

	[Token(Token = "0x40167CA")]
	[FieldOffset(Offset = "0x8C")]
	public GameObject Result;

	[Token(Token = "0x40167CB")]
	[FieldOffset(Offset = "0x90")]
	public UILabel ResultSummary;

	[Token(Token = "0x40167CC")]
	[FieldOffset(Offset = "0x94")]
	public UILabel ResultTitle1;

	[Token(Token = "0x40167CD")]
	[FieldOffset(Offset = "0x98")]
	public UILabel EndLeftTimeLabel;

	[Token(Token = "0x40167CE")]
	[FieldOffset(Offset = "0x9C")]
	public UILabel ResultTitle2;

	[Token(Token = "0x40167CF")]
	[FieldOffset(Offset = "0xA0")]
	public UILabel HeadShotCntLabel;

	[Token(Token = "0x40167D0")]
	[FieldOffset(Offset = "0xA4")]
	public UILabel ResultTitle3;

	[Token(Token = "0x40167D1")]
	[FieldOffset(Offset = "0xA8")]
	public UILabel KillLabel;

	[Token(Token = "0x40167D2")]
	[FieldOffset(Offset = "0xAC")]
	public UILabel ResultTitle4;

	[Token(Token = "0x40167D3")]
	[FieldOffset(Offset = "0xB0")]
	public UILabel EndScoreLabel;

	[Token(Token = "0x40167D4")]
	[FieldOffset(Offset = "0xB4")]
	public GameObject Reward;

	[Token(Token = "0x40167D5")]
	[FieldOffset(Offset = "0xB8")]
	public UISprite ItemIcon;

	[Token(Token = "0x40167D6")]
	[FieldOffset(Offset = "0xBC")]
	public UILabel ItemNum;

	[Token(Token = "0x40167D7")]
	[FieldOffset(Offset = "0xC0")]
	public GameObject SelectShootLevel;

	[Token(Token = "0x40167D8")]
	[FieldOffset(Offset = "0xC4")]
	public UIToggle ShootLeve_L;

	[Token(Token = "0x40167D9")]
	[FieldOffset(Offset = "0xC8")]
	public UIToggle ShootLeve_M;

	[Token(Token = "0x40167DA")]
	[FieldOffset(Offset = "0xCC")]
	public UIToggle ShootLeve_H;

	[Token(Token = "0x40167DB")]
	[FieldOffset(Offset = "0xD0")]
	public UIButton SelectShootLevelBtn;

	[Token(Token = "0x6016A22")]
	[Address(RVA = "0x1584EA0", Offset = "0x1584EA0", VA = "0x1584EA0")]
	public UIHudTrainingMiniGameView()
	{
	}

	[Token(Token = "0x6016A23")]
	[Address(RVA = "0x1584EA8", Offset = "0x1584EA8", VA = "0x1584EA8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016A24")]
	[Address(RVA = "0x15860E0", Offset = "0x15860E0", VA = "0x15860E0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
