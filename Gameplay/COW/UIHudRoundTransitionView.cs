using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003718")]
public class UIHudRoundTransitionView : UIBaseView
{
	[Token(Token = "0x401640C")]
	[FieldOffset(Offset = "0x14")]
	public Animator Animator;

	[Token(Token = "0x401640D")]
	[FieldOffset(Offset = "0x18")]
	public GameObject roundResultDetailsContainer;

	[Token(Token = "0x401640E")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel coins;

	[Token(Token = "0x401640F")]
	[FieldOffset(Offset = "0x20")]
	public UILabel coinValue;

	[Token(Token = "0x4016410")]
	[FieldOffset(Offset = "0x24")]
	public UILabel roundInfo;

	[Token(Token = "0x4016411")]
	[FieldOffset(Offset = "0x28")]
	public GameObject winSprite;

	[Token(Token = "0x4016412")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject loseSprite;

	[Token(Token = "0x4016413")]
	[FieldOffset(Offset = "0x30")]
	public UIGrid bonusGrid;

	[Token(Token = "0x4016414")]
	[FieldOffset(Offset = "0x34")]
	public GameObject bonusItem;

	[Token(Token = "0x4016415")]
	[FieldOffset(Offset = "0x38")]
	public GameObject mvpPlayer;

	[Token(Token = "0x4016416")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel MVPPlayerName;

	[Token(Token = "0x4016417")]
	[FieldOffset(Offset = "0x40")]
	public GameObject VS;

	[Token(Token = "0x4016418")]
	[FieldOffset(Offset = "0x44")]
	public GameObject nextRoundContainer;

	[Token(Token = "0x4016419")]
	[FieldOffset(Offset = "0x48")]
	public UILabel matchpoint;

	[Token(Token = "0x401641A")]
	[FieldOffset(Offset = "0x4C")]
	public Transform roundNum_noMatchPointTrans;

	[Token(Token = "0x401641B")]
	[FieldOffset(Offset = "0x50")]
	public UILabel roundNum;

	[Token(Token = "0x401641C")]
	[FieldOffset(Offset = "0x54")]
	public Transform gamezoneName_noMatchPointTrans;

	[Token(Token = "0x401641D")]
	[FieldOffset(Offset = "0x58")]
	public UILabel gamezoneName;

	[Token(Token = "0x401641E")]
	[FieldOffset(Offset = "0x5C")]
	public Transform roundNum_matchPointTrans;

	[Token(Token = "0x401641F")]
	[FieldOffset(Offset = "0x60")]
	public Transform gamezoneName_matchPointTrans;

	[Token(Token = "0x4016420")]
	[FieldOffset(Offset = "0x64")]
	public UISprite myFactionIcon;

	[Token(Token = "0x4016421")]
	[FieldOffset(Offset = "0x68")]
	public UISprite myTeamIcon;

	[Token(Token = "0x4016422")]
	[FieldOffset(Offset = "0x6C")]
	public UILabel myTeamName;

	[Token(Token = "0x4016423")]
	[FieldOffset(Offset = "0x70")]
	public GameObject myScores;

	[Token(Token = "0x4016424")]
	[FieldOffset(Offset = "0x74")]
	public UILabel myScoreCurrent;

	[Token(Token = "0x4016425")]
	[FieldOffset(Offset = "0x78")]
	public UILabel myScorePrevious;

	[Token(Token = "0x4016426")]
	[FieldOffset(Offset = "0x7C")]
	public TweenAlpha myTweenAlpha;

	[Token(Token = "0x4016427")]
	[FieldOffset(Offset = "0x80")]
	public TweenPosition myTweenPos;

	[Token(Token = "0x4016428")]
	[FieldOffset(Offset = "0x84")]
	public GameObject myVFX;

	[Token(Token = "0x4016429")]
	[FieldOffset(Offset = "0x88")]
	public UISprite oppoFactionIcon;

	[Token(Token = "0x401642A")]
	[FieldOffset(Offset = "0x8C")]
	public UILabel oppoTeamName;

	[Token(Token = "0x401642B")]
	[FieldOffset(Offset = "0x90")]
	public UISprite oppoTeamIcon;

	[Token(Token = "0x401642C")]
	[FieldOffset(Offset = "0x94")]
	public GameObject oppScores;

	[Token(Token = "0x401642D")]
	[FieldOffset(Offset = "0x98")]
	public UILabel oppoScoreCurrent;

	[Token(Token = "0x401642E")]
	[FieldOffset(Offset = "0x9C")]
	public UILabel oppoScorePrevious;

	[Token(Token = "0x401642F")]
	[FieldOffset(Offset = "0xA0")]
	public TweenAlpha oppoTweenAlpha;

	[Token(Token = "0x4016430")]
	[FieldOffset(Offset = "0xA4")]
	public TweenPosition oppoTweenPos;

	[Token(Token = "0x4016431")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject oppoVFX;

	[Token(Token = "0x4016432")]
	[FieldOffset(Offset = "0xAC")]
	public UILabel LastRoundHint;

	[Token(Token = "0x60168F3")]
	[Address(RVA = "0x1C45C18", Offset = "0x1C45C18", VA = "0x1C45C18")]
	public UIHudRoundTransitionView()
	{
	}

	[Token(Token = "0x60168F4")]
	[Address(RVA = "0x1C45C20", Offset = "0x1C45C20", VA = "0x1C45C20", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60168F5")]
	[Address(RVA = "0x1C46AE4", Offset = "0x1C46AE4", VA = "0x1C46AE4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
