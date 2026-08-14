using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200365E")]
public class UIHudGameModeIntroBasicView : UIBaseView
{
	[Token(Token = "0x4015D18")]
	[FieldOffset(Offset = "0x14")]
	public GameObject contentcontainer;

	[Token(Token = "0x4015D19")]
	[FieldOffset(Offset = "0x18")]
	public UISprite ModeIcon;

	[Token(Token = "0x4015D1A")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel ModeTitleLable;

	[Token(Token = "0x4015D1B")]
	[FieldOffset(Offset = "0x20")]
	public UILabel ModeDescLabel;

	[Token(Token = "0x60166C7")]
	[Address(RVA = "0x1888B04", Offset = "0x1888B04", VA = "0x1888B04")]
	public UIHudGameModeIntroBasicView()
	{
	}

	[Token(Token = "0x60166C8")]
	[Address(RVA = "0x1888B0C", Offset = "0x1888B0C", VA = "0x1888B0C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60166C9")]
	[Address(RVA = "0x1888DC8", Offset = "0x1888DC8", VA = "0x1888DC8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
