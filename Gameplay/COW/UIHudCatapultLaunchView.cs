using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003607")]
public class UIHudCatapultLaunchView : UIBaseView
{
	[Token(Token = "0x4015A02")]
	[FieldOffset(Offset = "0x14")]
	public UISprite BGLaunch;

	[Token(Token = "0x4015A03")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BtnLaunch;

	[Token(Token = "0x4015A04")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite BtnSprite;

	[Token(Token = "0x60165C3")]
	[Address(RVA = "0x2148944", Offset = "0x2148944", VA = "0x2148944")]
	public UIHudCatapultLaunchView()
	{
	}

	[Token(Token = "0x60165C4")]
	[Address(RVA = "0x214894C", Offset = "0x214894C", VA = "0x214894C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60165C5")]
	[Address(RVA = "0x2148BB4", Offset = "0x2148BB4", VA = "0x2148BB4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
