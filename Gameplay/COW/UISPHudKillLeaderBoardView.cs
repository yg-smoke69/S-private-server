using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039C2")]
internal class UISPHudKillLeaderBoardView : UIBaseView
{
	[Token(Token = "0x401846F")]
	[FieldOffset(Offset = "0x14")]
	public GameObject InfoPanel;

	[Token(Token = "0x4018470")]
	[FieldOffset(Offset = "0x18")]
	public TweenPosition TweenPosition;

	[Token(Token = "0x4018471")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Title;

	[Token(Token = "0x4018472")]
	[FieldOffset(Offset = "0x20")]
	public UISprite TeamIcon;

	[Token(Token = "0x4018473")]
	[FieldOffset(Offset = "0x24")]
	public UISprite TeamFakeIcon;

	[Token(Token = "0x4018474")]
	[FieldOffset(Offset = "0x28")]
	public UILabel KillCount;

	[Token(Token = "0x4018475")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel KillLabel;

	[Token(Token = "0x60170ED")]
	[Address(RVA = "0x1D20498", Offset = "0x1D20498", VA = "0x1D20498")]
	public UISPHudKillLeaderBoardView()
	{
	}

	[Token(Token = "0x60170EE")]
	[Address(RVA = "0x1D204A0", Offset = "0x1D204A0", VA = "0x1D204A0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60170EF")]
	[Address(RVA = "0x1D20784", Offset = "0x1D20784", VA = "0x1D20784")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
