using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003410")]
public class UIChampionshipGameStatsView : UIBaseView
{
	[Token(Token = "0x401418E")]
	[FieldOffset(Offset = "0x14")]
	public UILabel SeasonLabel;

	[Token(Token = "0x401418F")]
	[FieldOffset(Offset = "0x18")]
	public UILabel SeasonInfoLabel;

	[Token(Token = "0x4014190")]
	[FieldOffset(Offset = "0x1C")]
	public UITable MatchStatsTable;

	[Token(Token = "0x4014191")]
	[FieldOffset(Offset = "0x20")]
	public UILabel mMatchCount;

	[Token(Token = "0x4014192")]
	[FieldOffset(Offset = "0x24")]
	public UILabel mMostRankPoint;

	[Token(Token = "0x4014193")]
	[FieldOffset(Offset = "0x28")]
	public UILabel mWins;

	[Token(Token = "0x4014194")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel mTop10P;

	[Token(Token = "0x4014195")]
	[FieldOffset(Offset = "0x30")]
	public UILabel mTop50P;

	[Token(Token = "0x4014196")]
	[FieldOffset(Offset = "0x34")]
	public UILabel mSurvialTime;

	[Token(Token = "0x4014197")]
	[FieldOffset(Offset = "0x38")]
	public UILabel mMoveDistance;

	[Token(Token = "0x4014198")]
	[FieldOffset(Offset = "0x3C")]
	public UITable BattleStatsTable;

	[Token(Token = "0x4014199")]
	[FieldOffset(Offset = "0x40")]
	public UILabel bTotalKill;

	[Token(Token = "0x401419A")]
	[FieldOffset(Offset = "0x44")]
	public UILabel bAvgKill;

	[Token(Token = "0x401419B")]
	[FieldOffset(Offset = "0x48")]
	public UILabel bAvgDamage;

	[Token(Token = "0x401419C")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel bKD;

	[Token(Token = "0x401419D")]
	[FieldOffset(Offset = "0x50")]
	public UILabel bMostKill;

	[Token(Token = "0x401419E")]
	[FieldOffset(Offset = "0x54")]
	public UILabel bMostDamage;

	[Token(Token = "0x401419F")]
	[FieldOffset(Offset = "0x58")]
	public UILabel bHeadShot;

	[Token(Token = "0x40141A0")]
	[FieldOffset(Offset = "0x5C")]
	public UIButton ViewMatchHistoryBtn;

	[Token(Token = "0x40141A1")]
	[FieldOffset(Offset = "0x60")]
	public UIButton ShareBtn;

	[Token(Token = "0x40141A2")]
	[FieldOffset(Offset = "0x64")]
	public Animator ShareIconAnimator;

	[Token(Token = "0x40141A3")]
	[FieldOffset(Offset = "0x68")]
	public UISprite ScreenshotTopBanner;

	[Token(Token = "0x40141A4")]
	[FieldOffset(Offset = "0x6C")]
	public UINetworkTexture HeadshotRemote;

	[Token(Token = "0x40141A5")]
	[FieldOffset(Offset = "0x70")]
	public GameObject HeadshotDefault;

	[Token(Token = "0x40141A6")]
	[FieldOffset(Offset = "0x74")]
	public UIEffectSprite HeadshotLocal;

	[Token(Token = "0x40141A7")]
	[FieldOffset(Offset = "0x78")]
	public UILabel PlayerNickname;

	[Token(Token = "0x40141A8")]
	[FieldOffset(Offset = "0x7C")]
	public UILabel PlayerID;

	[Token(Token = "0x40141A9")]
	[FieldOffset(Offset = "0x80")]
	public UISprite FreeFireLogo;

	[Token(Token = "0x40141AA")]
	[FieldOffset(Offset = "0x84")]
	public Transform TeamOverview;

	[Token(Token = "0x6015FE4")]
	[Address(RVA = "0x282BD34", Offset = "0x282BD34", VA = "0x282BD34")]
	public UIChampionshipGameStatsView()
	{
	}

	[Token(Token = "0x6015FE5")]
	[Address(RVA = "0x282BD3C", Offset = "0x282BD3C", VA = "0x282BD3C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015FE6")]
	[Address(RVA = "0x282C930", Offset = "0x282C930", VA = "0x282C930")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
