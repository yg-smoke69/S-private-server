using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035C4")]
public class UIHudActionView : UIBaseView
{
	[Token(Token = "0x4015862")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnAction;

	[Token(Token = "0x4015863")]
	[FieldOffset(Offset = "0x18")]
	public UILabel ActionNameTxt;

	[Token(Token = "0x4015864")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite SpriteBg;

	[Token(Token = "0x4015865")]
	[FieldOffset(Offset = "0x20")]
	public UISprite BtnIcon;

	[Token(Token = "0x4015866")]
	[FieldOffset(Offset = "0x24")]
	public UISprite Cooldown;

	[Token(Token = "0x4015867")]
	[FieldOffset(Offset = "0x28")]
	public UIButton Block;

	[Token(Token = "0x60164FA")]
	[Address(RVA = "0x16FEE60", Offset = "0x16FEE60", VA = "0x16FEE60")]
	public UIHudActionView()
	{
	}

	[Token(Token = "0x60164FB")]
	[Address(RVA = "0x16FEE68", Offset = "0x16FEE68", VA = "0x16FEE68", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60164FC")]
	[Address(RVA = "0x16FF1F0", Offset = "0x16FF1F0", VA = "0x16FF1F0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
