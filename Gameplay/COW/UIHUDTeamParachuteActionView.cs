using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200376C")]
public class UIHUDTeamParachuteActionView : UIBaseView
{
	[Token(Token = "0x4016733")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ActionBtn;

	[Token(Token = "0x4016734")]
	[FieldOffset(Offset = "0x18")]
	public UILabel ActionName;

	[Token(Token = "0x4016735")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite ActionIcon;

	[Token(Token = "0x4016736")]
	[FieldOffset(Offset = "0x20")]
	public GameObject leaderPanel;

	[Token(Token = "0x4016737")]
	[FieldOffset(Offset = "0x24")]
	public UIButton bgBtn;

	[Token(Token = "0x4016738")]
	[FieldOffset(Offset = "0x28")]
	public GameObject teammate1;

	[Token(Token = "0x4016739")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel teamid1Selected;

	[Token(Token = "0x401673A")]
	[FieldOffset(Offset = "0x30")]
	public UILabel teamid1;

	[Token(Token = "0x401673B")]
	[FieldOffset(Offset = "0x34")]
	public UIToggleButton btn1;

	[Token(Token = "0x401673C")]
	[FieldOffset(Offset = "0x38")]
	public GameObject teammate2;

	[Token(Token = "0x401673D")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel teamid2Selected;

	[Token(Token = "0x401673E")]
	[FieldOffset(Offset = "0x40")]
	public UILabel teamid2;

	[Token(Token = "0x401673F")]
	[FieldOffset(Offset = "0x44")]
	public UIToggleButton btn2;

	[Token(Token = "0x4016740")]
	[FieldOffset(Offset = "0x48")]
	public GameObject teammate3;

	[Token(Token = "0x4016741")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel teamid3Selected;

	[Token(Token = "0x4016742")]
	[FieldOffset(Offset = "0x50")]
	public UILabel teamid3;

	[Token(Token = "0x4016743")]
	[FieldOffset(Offset = "0x54")]
	public UIToggleButton btn3;

	[Token(Token = "0x60169EF")]
	[Address(RVA = "0x22211B0", Offset = "0x22211B0", VA = "0x22211B0")]
	public UIHUDTeamParachuteActionView()
	{
	}

	[Token(Token = "0x60169F0")]
	[Address(RVA = "0x22211B8", Offset = "0x22211B8", VA = "0x22211B8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60169F1")]
	[Address(RVA = "0x2221930", Offset = "0x2221930", VA = "0x2221930")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
