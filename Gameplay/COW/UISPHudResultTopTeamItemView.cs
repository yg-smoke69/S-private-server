using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039D6")]
public class UISPHudResultTopTeamItemView : UIBaseView
{
	[Token(Token = "0x4018553")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget UISPHudResultTopTeamItem;

	[Token(Token = "0x4018554")]
	[FieldOffset(Offset = "0x18")]
	public GameObject FirBG;

	[Token(Token = "0x4018555")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite Banner;

	[Token(Token = "0x4018556")]
	[FieldOffset(Offset = "0x20")]
	public UILabel Id;

	[Token(Token = "0x4018557")]
	[FieldOffset(Offset = "0x24")]
	public UIGrid Grid;

	[Token(Token = "0x6017128")]
	[Address(RVA = "0x1D2E0C0", Offset = "0x1D2E0C0", VA = "0x1D2E0C0")]
	public UISPHudResultTopTeamItemView()
	{
	}

	[Token(Token = "0x6017129")]
	[Address(RVA = "0x1D2E0C8", Offset = "0x1D2E0C8", VA = "0x1D2E0C8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601712A")]
	[Address(RVA = "0x1D2E3E4", Offset = "0x1D2E3E4", VA = "0x1D2E3E4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
