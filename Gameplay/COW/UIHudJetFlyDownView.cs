using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003688")]
public class UIHudJetFlyDownView : UIBaseView
{
	[Token(Token = "0x4015EE7")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnJetFlyDown;

	[Token(Token = "0x4015EE8")]
	[FieldOffset(Offset = "0x18")]
	public UISprite BtnSprite;

	[Token(Token = "0x6016745")]
	[Address(RVA = "0x20B1F70", Offset = "0x20B1F70", VA = "0x20B1F70")]
	public UIHudJetFlyDownView()
	{
	}

	[Token(Token = "0x6016746")]
	[Address(RVA = "0x20B1F78", Offset = "0x20B1F78", VA = "0x20B1F78", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016747")]
	[Address(RVA = "0x20B2180", Offset = "0x20B2180", VA = "0x20B2180")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
