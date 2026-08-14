using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003601")]
public class UIHudCamouflageView : UIBaseView
{
	[Token(Token = "0x40159DC")]
	[FieldOffset(Offset = "0x14")]
	public UIButton Btn;

	[Token(Token = "0x40159DD")]
	[FieldOffset(Offset = "0x18")]
	public UISprite icon;

	[Token(Token = "0x40159DE")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite getOn;

	[Token(Token = "0x40159DF")]
	[FieldOffset(Offset = "0x20")]
	public UISprite getOff;

	[Token(Token = "0x40159E0")]
	[FieldOffset(Offset = "0x24")]
	public GameObject CDMask;

	[Token(Token = "0x40159E1")]
	[FieldOffset(Offset = "0x28")]
	public UISprite CDProgress;

	[Token(Token = "0x60165B1")]
	[Address(RVA = "0x2144E30", Offset = "0x2144E30", VA = "0x2144E30")]
	public UIHudCamouflageView()
	{
	}

	[Token(Token = "0x60165B2")]
	[Address(RVA = "0x2144E38", Offset = "0x2144E38", VA = "0x2144E38", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60165B3")]
	[Address(RVA = "0x21451B4", Offset = "0x21451B4", VA = "0x21451B4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
