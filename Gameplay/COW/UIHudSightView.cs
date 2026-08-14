using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003744")]
public class UIHudSightView : UIBaseView
{
	[Token(Token = "0x401659E")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnToggleSight;

	[Token(Token = "0x401659F")]
	[FieldOffset(Offset = "0x18")]
	public UISprite AimHighlightSprite;

	[Token(Token = "0x40165A0")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtClose;

	[Token(Token = "0x40165A1")]
	[FieldOffset(Offset = "0x20")]
	public UISprite AimSprite;

	[Token(Token = "0x40165A2")]
	[FieldOffset(Offset = "0x24")]
	public UISprite BGToggleSight;

	[Token(Token = "0x6016977")]
	[Address(RVA = "0x16BA9B4", Offset = "0x16BA9B4", VA = "0x16BA9B4")]
	public UIHudSightView()
	{
	}

	[Token(Token = "0x6016978")]
	[Address(RVA = "0x16BA9BC", Offset = "0x16BA9BC", VA = "0x16BA9BC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016979")]
	[Address(RVA = "0x16BACE4", Offset = "0x16BACE4", VA = "0x16BACE4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
