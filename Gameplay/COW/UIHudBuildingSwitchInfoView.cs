using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003600")]
public class UIHudBuildingSwitchInfoView : UIBaseView
{
	[Token(Token = "0x40159D9")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BuidlingSwitchButton;

	[Token(Token = "0x40159DA")]
	[FieldOffset(Offset = "0x18")]
	public UISprite Icon;

	[Token(Token = "0x40159DB")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Highlight;

	[Token(Token = "0x60165AE")]
	[Address(RVA = "0x1EFE560", Offset = "0x1EFE560", VA = "0x1EFE560")]
	public UIHudBuildingSwitchInfoView()
	{
	}

	[Token(Token = "0x60165AF")]
	[Address(RVA = "0x1EFE568", Offset = "0x1EFE568", VA = "0x1EFE568", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60165B0")]
	[Address(RVA = "0x1EFE7C4", Offset = "0x1EFE7C4", VA = "0x1EFE7C4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
