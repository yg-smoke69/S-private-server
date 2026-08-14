using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035D1")]
public class UIHUDArmsRaceKillPointsView : UIBaseView
{
	[Token(Token = "0x40158AA")]
	[FieldOffset(Offset = "0x14")]
	public UIGrid PointsGrid;

	[Token(Token = "0x40158AB")]
	[FieldOffset(Offset = "0x18")]
	public UIHUDArmsRacePointItem PointItem;

	[Token(Token = "0x40158AC")]
	[FieldOffset(Offset = "0x1C")]
	public Animator KillLeaderEffect;

	[Token(Token = "0x6016521")]
	[Address(RVA = "0x166E600", Offset = "0x166E600", VA = "0x166E600")]
	public UIHUDArmsRaceKillPointsView()
	{
	}

	[Token(Token = "0x6016522")]
	[Address(RVA = "0x166E608", Offset = "0x166E608", VA = "0x166E608", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016523")]
	[Address(RVA = "0x166E870", Offset = "0x166E870", VA = "0x166E870")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
