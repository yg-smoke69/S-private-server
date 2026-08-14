using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003386")]
public class LadderMatchLeaderboardView : UIBaseView
{
	[Token(Token = "0x4013A05")]
	[FieldOffset(Offset = "0x14")]
	public TweenPosition BoardTween;

	[Token(Token = "0x4013A06")]
	[FieldOffset(Offset = "0x18")]
	public UIEasyList EasyList;

	[Token(Token = "0x4013A07")]
	[FieldOffset(Offset = "0x1C")]
	public UIToggleButton BtnFriend;

	[Token(Token = "0x4013A08")]
	[FieldOffset(Offset = "0x20")]
	public UIToggleButton BtnAll;

	[Token(Token = "0x4013A09")]
	[FieldOffset(Offset = "0x24")]
	public Transform SelfRank;

	[Token(Token = "0x4013A0A")]
	[FieldOffset(Offset = "0x28")]
	public UIButton BtnClose;

	[Token(Token = "0x4013A0B")]
	[FieldOffset(Offset = "0x2C")]
	public Transform Arrow;

	[Token(Token = "0x4013A0C")]
	[FieldOffset(Offset = "0x30")]
	public UIButton BtnHide;

	[Token(Token = "0x4013A0D")]
	[FieldOffset(Offset = "0x34")]
	public TweenAlpha Mask;

	[Token(Token = "0x4013A0E")]
	[FieldOffset(Offset = "0x38")]
	public UIWidget MainWidget;

	[Token(Token = "0x4013A0F")]
	[FieldOffset(Offset = "0x3C")]
	public UIPanel ScrollViewPanel;

	[Token(Token = "0x6015E49")]
	[Address(RVA = "0x1EF20A4", Offset = "0x1EF20A4", VA = "0x1EF20A4")]
	public LadderMatchLeaderboardView()
	{
	}

	[Token(Token = "0x6015E4A")]
	[Address(RVA = "0x1EF20AC", Offset = "0x1EF20AC", VA = "0x1EF20AC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015E4B")]
	[Address(RVA = "0x1EF25C4", Offset = "0x1EF25C4", VA = "0x1EF25C4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
