using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003504")]
public class UIElitePassIngameHudRankingView : UIBaseView
{
	[Token(Token = "0x4014E28")]
	[FieldOffset(Offset = "0x14")]
	public UIPanel ElitepassPanel;

	[Token(Token = "0x4014E29")]
	[FieldOffset(Offset = "0x18")]
	public UIGrid Grid;

	[Token(Token = "0x4014E2A")]
	[FieldOffset(Offset = "0x1C")]
	public ElitePassIngameRanking Top1Player;

	[Token(Token = "0x4014E2B")]
	[FieldOffset(Offset = "0x20")]
	public ElitePassIngameRanking Top2Player;

	[Token(Token = "0x4014E2C")]
	[FieldOffset(Offset = "0x24")]
	public ElitePassIngameRanking Top3Player;

	[Token(Token = "0x60162BC")]
	[Address(RVA = "0x2A57CEC", Offset = "0x2A57CEC", VA = "0x2A57CEC")]
	public UIElitePassIngameHudRankingView()
	{
	}

	[Token(Token = "0x60162BD")]
	[Address(RVA = "0x2A57CF4", Offset = "0x2A57CF4", VA = "0x2A57CF4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60162BE")]
	[Address(RVA = "0x2A5801C", Offset = "0x2A5801C", VA = "0x2A5801C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
