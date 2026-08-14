using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035F3")]
public class UIHudBombView : UIBaseView
{
	[Token(Token = "0x40159A2")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnBomb;

	[Token(Token = "0x40159A3")]
	[FieldOffset(Offset = "0x18")]
	public UILabel ActionNameTxt;

	[Token(Token = "0x40159A4")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite BtnBg;

	[Token(Token = "0x40159A5")]
	[FieldOffset(Offset = "0x20")]
	public UISprite BtnIcon;

	[Token(Token = "0x6016587")]
	[Address(RVA = "0x1E12CF0", Offset = "0x1E12CF0", VA = "0x1E12CF0")]
	public UIHudBombView()
	{
	}

	[Token(Token = "0x6016588")]
	[Address(RVA = "0x1E12CF8", Offset = "0x1E12CF8", VA = "0x1E12CF8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016589")]
	[Address(RVA = "0x1E12FC0", Offset = "0x1E12FC0", VA = "0x1E12FC0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
