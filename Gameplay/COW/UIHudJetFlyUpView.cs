using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003689")]
public class UIHudJetFlyUpView : UIBaseView
{
	[Token(Token = "0x4015EE9")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnJetFlyUp;

	[Token(Token = "0x4015EEA")]
	[FieldOffset(Offset = "0x18")]
	public UISprite BtnSprite;

	[Token(Token = "0x6016748")]
	[Address(RVA = "0x20B23C4", Offset = "0x20B23C4", VA = "0x20B23C4")]
	public UIHudJetFlyUpView()
	{
	}

	[Token(Token = "0x6016749")]
	[Address(RVA = "0x20B23CC", Offset = "0x20B23CC", VA = "0x20B23CC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601674A")]
	[Address(RVA = "0x20B25D4", Offset = "0x20B25D4", VA = "0x20B25D4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
