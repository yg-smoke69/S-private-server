using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039DA")]
public class UISPHudTeamAccStatsListView : UIBaseView
{
	[Token(Token = "0x401857C")]
	[FieldOffset(Offset = "0x14")]
	public TweenPosition InfoPanel;

	[Token(Token = "0x401857D")]
	[FieldOffset(Offset = "0x18")]
	public GameObject team;

	[Token(Token = "0x401857E")]
	[FieldOffset(Offset = "0x1C")]
	public UIScrollView TeamList;

	[Token(Token = "0x401857F")]
	[FieldOffset(Offset = "0x20")]
	public UIGrid TeamGrid;

	[Token(Token = "0x6017134")]
	[Address(RVA = "0x1494F44", Offset = "0x1494F44", VA = "0x1494F44")]
	public UISPHudTeamAccStatsListView()
	{
	}

	[Token(Token = "0x6017135")]
	[Address(RVA = "0x1494F4C", Offset = "0x1494F4C", VA = "0x1494F4C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017136")]
	[Address(RVA = "0x1495154", Offset = "0x1495154", VA = "0x1495154")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
