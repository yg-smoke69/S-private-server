using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200371B")]
public class UIHUDRushingPetsLevelEndShowView : UIBaseView
{
	[Token(Token = "0x4016439")]
	[FieldOffset(Offset = "0x14")]
	public GameObject RankRoot;

	[Token(Token = "0x401643A")]
	[FieldOffset(Offset = "0x18")]
	public UIEasyList PlayerList;

	[Token(Token = "0x401643B")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel NextRoundTimeLabel;

	[Token(Token = "0x401643C")]
	[FieldOffset(Offset = "0x20")]
	public Transform LocalPlayerInfo;

	[Token(Token = "0x401643D")]
	[FieldOffset(Offset = "0x24")]
	public GameObject RoundEndTipRoot;

	[Token(Token = "0x401643E")]
	[FieldOffset(Offset = "0x28")]
	public UILabel CurRoundRankLabel;

	[Token(Token = "0x401643F")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel CurRoundScoreLabel;

	[Token(Token = "0x4016440")]
	[FieldOffset(Offset = "0x30")]
	public GameObject VictoryRoot;

	[Token(Token = "0x60168FC")]
	[Address(RVA = "0x220D168", Offset = "0x220D168", VA = "0x220D168")]
	public UIHUDRushingPetsLevelEndShowView()
	{
	}

	[Token(Token = "0x60168FD")]
	[Address(RVA = "0x220D170", Offset = "0x220D170", VA = "0x220D170", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60168FE")]
	[Address(RVA = "0x220D56C", Offset = "0x220D56C", VA = "0x220D56C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
