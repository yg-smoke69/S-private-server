using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039CE")]
public class UISPHudResultNormalLiteTeamItemView : UIBaseView
{
	[Token(Token = "0x4018528")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget UISPHudResultNormalLiteTeamItem;

	[Token(Token = "0x4018529")]
	[FieldOffset(Offset = "0x18")]
	public UILabel TeamName;

	[Token(Token = "0x401852A")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Rank;

	[Token(Token = "0x401852B")]
	[FieldOffset(Offset = "0x20")]
	public GameObject BG;

	[Token(Token = "0x401852C")]
	[FieldOffset(Offset = "0x24")]
	public UITable Table;

	[Token(Token = "0x401852D")]
	[FieldOffset(Offset = "0x28")]
	public UITable LeagueTable;

	[Token(Token = "0x6017110")]
	[Address(RVA = "0x1D2B0D4", Offset = "0x1D2B0D4", VA = "0x1D2B0D4")]
	public UISPHudResultNormalLiteTeamItemView()
	{
	}

	[Token(Token = "0x6017111")]
	[Address(RVA = "0x1D2B0DC", Offset = "0x1D2B0DC", VA = "0x1D2B0DC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017112")]
	[Address(RVA = "0x1D2B384", Offset = "0x1D2B384", VA = "0x1D2B384")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
