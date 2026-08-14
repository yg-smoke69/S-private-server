using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036A4")]
public class UIHudLWSORoundResultView : UIBaseView
{
	[Token(Token = "0x4015FF3")]
	[FieldOffset(Offset = "0x14")]
	public GameObject WinSprite;

	[Token(Token = "0x4015FF4")]
	[FieldOffset(Offset = "0x18")]
	public GameObject LoseSprite;

	[Token(Token = "0x4015FF5")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite HPKnife;

	[Token(Token = "0x4015FF6")]
	[FieldOffset(Offset = "0x20")]
	public UIGrid OppoFactionHP;

	[Token(Token = "0x4015FF7")]
	[FieldOffset(Offset = "0x24")]
	public GameObject OppoFactionEliminate;

	[Token(Token = "0x4015FF8")]
	[FieldOffset(Offset = "0x28")]
	public UILabel OppoTeamName;

	[Token(Token = "0x4015FF9")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite OppoFactionIcon;

	[Token(Token = "0x4015FFA")]
	[FieldOffset(Offset = "0x30")]
	public GameObject OppoWinVFX;

	[Token(Token = "0x4015FFB")]
	[FieldOffset(Offset = "0x34")]
	public UIGrid MyFactionHP;

	[Token(Token = "0x4015FFC")]
	[FieldOffset(Offset = "0x38")]
	public GameObject MyFactionEliminate;

	[Token(Token = "0x4015FFD")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel MyName;

	[Token(Token = "0x4015FFE")]
	[FieldOffset(Offset = "0x40")]
	public UISprite MyFactionIcon;

	[Token(Token = "0x4015FFF")]
	[FieldOffset(Offset = "0x44")]
	public GameObject MyWinVFX;

	[Token(Token = "0x6016799")]
	[Address(RVA = "0x1BCD6F4", Offset = "0x1BCD6F4", VA = "0x1BCD6F4")]
	public UIHudLWSORoundResultView()
	{
	}

	[Token(Token = "0x601679A")]
	[Address(RVA = "0x1BCD6FC", Offset = "0x1BCD6FC", VA = "0x1BCD6FC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601679B")]
	[Address(RVA = "0x1BCDCDC", Offset = "0x1BCDCDC", VA = "0x1BCDCDC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
