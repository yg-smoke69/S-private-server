using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039DF")]
internal class UISPHudTeamRankingListView : UIBaseView
{
	[Token(Token = "0x40185BF")]
	[FieldOffset(Offset = "0x14")]
	public GameObject InfoPanel;

	[Token(Token = "0x40185C0")]
	[FieldOffset(Offset = "0x18")]
	public TweenPosition TweenPosition;

	[Token(Token = "0x40185C1")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject team;

	[Token(Token = "0x40185C2")]
	[FieldOffset(Offset = "0x20")]
	public UIScrollView TeamList;

	[Token(Token = "0x40185C3")]
	[FieldOffset(Offset = "0x24")]
	public UIEasyList TeamGrid;

	[Token(Token = "0x40185C4")]
	[FieldOffset(Offset = "0x28")]
	public GameObject CombatLevelGo;

	[Token(Token = "0x6017143")]
	[Address(RVA = "0x149B3E0", Offset = "0x149B3E0", VA = "0x149B3E0")]
	public UISPHudTeamRankingListView()
	{
	}

	[Token(Token = "0x6017144")]
	[Address(RVA = "0x149B3E8", Offset = "0x149B3E8", VA = "0x149B3E8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017145")]
	[Address(RVA = "0x149B690", Offset = "0x149B690", VA = "0x149B690")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
