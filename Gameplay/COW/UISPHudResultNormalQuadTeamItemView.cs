using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039CF")]
public class UISPHudResultNormalQuadTeamItemView : UIBaseView
{
	[Token(Token = "0x401852E")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget UISPHudResultNormalQuadTeamItem;

	[Token(Token = "0x401852F")]
	[FieldOffset(Offset = "0x18")]
	public UILabel TeamName;

	[Token(Token = "0x4018530")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject BG;

	[Token(Token = "0x4018531")]
	[FieldOffset(Offset = "0x20")]
	public UILabel Rank;

	[Token(Token = "0x4018532")]
	[FieldOffset(Offset = "0x24")]
	public UITable Table;

	[Token(Token = "0x4018533")]
	[FieldOffset(Offset = "0x28")]
	public UITable LeagueTable;

	[Token(Token = "0x6017113")]
	[Address(RVA = "0x1D2B38C", Offset = "0x1D2B38C", VA = "0x1D2B38C")]
	public UISPHudResultNormalQuadTeamItemView()
	{
	}

	[Token(Token = "0x6017114")]
	[Address(RVA = "0x1D2B394", Offset = "0x1D2B394", VA = "0x1D2B394", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017115")]
	[Address(RVA = "0x1D2B63C", Offset = "0x1D2B63C", VA = "0x1D2B63C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
