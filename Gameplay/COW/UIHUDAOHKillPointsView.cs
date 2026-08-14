using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035CA")]
public class UIHUDAOHKillPointsView : UIBaseView
{
	[Token(Token = "0x401589A")]
	[FieldOffset(Offset = "0x14")]
	public UIGrid PointsGrid;

	[Token(Token = "0x401589B")]
	[FieldOffset(Offset = "0x18")]
	public UIHUDArmsRacePointItem PointItem;

	[Token(Token = "0x401589C")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite LevelIcon;

	[Token(Token = "0x601650C")]
	[Address(RVA = "0x166B528", Offset = "0x166B528", VA = "0x166B528")]
	public UIHUDAOHKillPointsView()
	{
	}

	[Token(Token = "0x601650D")]
	[Address(RVA = "0x166B530", Offset = "0x166B530", VA = "0x166B530", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601650E")]
	[Address(RVA = "0x166B798", Offset = "0x166B798", VA = "0x166B798")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
