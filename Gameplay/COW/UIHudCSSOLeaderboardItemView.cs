using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003628")]
public class UIHudCSSOLeaderboardItemView : UIBaseView
{
	[Token(Token = "0x4015B0C")]
	[FieldOffset(Offset = "0x14")]
	public UIHudCSSOTeamInfoView TeamInfoView;

	[Token(Token = "0x4015B0D")]
	[FieldOffset(Offset = "0x18")]
	public TweenScale TweenScale;

	[Token(Token = "0x4015B0E")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel TeamTitle;

	[Token(Token = "0x4015B0F")]
	[FieldOffset(Offset = "0x20")]
	public UILabel LabelTeam;

	[Token(Token = "0x4015B10")]
	[FieldOffset(Offset = "0x24")]
	public GameObject HP;

	[Token(Token = "0x4015B11")]
	[FieldOffset(Offset = "0x28")]
	public UILabel LabelPlayer4Name;

	[Token(Token = "0x4015B12")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel LabelPlayer2Name;

	[Token(Token = "0x4015B13")]
	[FieldOffset(Offset = "0x30")]
	public UILabel LabelPlayer3Name;

	[Token(Token = "0x4015B14")]
	[FieldOffset(Offset = "0x34")]
	public UILabel LabelPlayer1Name;

	[Token(Token = "0x4015B15")]
	[FieldOffset(Offset = "0x38")]
	public UILabel LabelPlayer1Kills;

	[Token(Token = "0x4015B16")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel LabelPlayer2Kills;

	[Token(Token = "0x4015B17")]
	[FieldOffset(Offset = "0x40")]
	public UILabel LabelPlayer3Kills;

	[Token(Token = "0x4015B18")]
	[FieldOffset(Offset = "0x44")]
	public UILabel LabelPlayer4Kills;

	[Token(Token = "0x4015B19")]
	[FieldOffset(Offset = "0x48")]
	public GameObject Eliminate;

	[Token(Token = "0x4015B1A")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject Up;

	[Token(Token = "0x4015B1B")]
	[FieldOffset(Offset = "0x50")]
	public UILabel UpRank;

	[Token(Token = "0x4015B1C")]
	[FieldOffset(Offset = "0x54")]
	public GameObject Win;

	[Token(Token = "0x4015B1D")]
	[FieldOffset(Offset = "0x58")]
	public GameObject Lose;

	[Token(Token = "0x4015B1E")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject Down;

	[Token(Token = "0x4015B1F")]
	[FieldOffset(Offset = "0x60")]
	public UILabel DownRank;

	[Token(Token = "0x4015B20")]
	[FieldOffset(Offset = "0x64")]
	public UISprite BG;

	[Token(Token = "0x4015B21")]
	[FieldOffset(Offset = "0x68")]
	public UISprite IndexIcon1;

	[Token(Token = "0x4015B22")]
	[FieldOffset(Offset = "0x6C")]
	public UILabel Index;

	[Token(Token = "0x4015B23")]
	[FieldOffset(Offset = "0x70")]
	public UISprite IndexIcon2;

	[Token(Token = "0x4015B24")]
	[FieldOffset(Offset = "0x74")]
	public UISprite IndexIcon3;

	[Token(Token = "0x4015B25")]
	[FieldOffset(Offset = "0x78")]
	public GameObject NormalMatch;

	[Token(Token = "0x4015B26")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject SpecialMatch;

	[Token(Token = "0x6016625")]
	[Address(RVA = "0x212E358", Offset = "0x212E358", VA = "0x212E358")]
	public UIHudCSSOLeaderboardItemView()
	{
	}

	[Token(Token = "0x6016626")]
	[Address(RVA = "0x212E360", Offset = "0x212E360", VA = "0x212E360", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016627")]
	[Address(RVA = "0x212EE68", Offset = "0x212EE68", VA = "0x212EE68")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
