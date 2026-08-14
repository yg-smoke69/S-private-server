using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035DE")]
public class UIHudAuxFireView : UIBaseView
{
	[Token(Token = "0x4015900")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnFire;

	[Token(Token = "0x4015901")]
	[FieldOffset(Offset = "0x18")]
	public UISprite BtnSprite;

	[Token(Token = "0x4015902")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite BGFire;

	[Token(Token = "0x6016548")]
	[Address(RVA = "0x171290C", Offset = "0x171290C", VA = "0x171290C")]
	public UIHudAuxFireView()
	{
	}

	[Token(Token = "0x6016549")]
	[Address(RVA = "0x1712914", Offset = "0x1712914", VA = "0x1712914", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601654A")]
	[Address(RVA = "0x1712B7C", Offset = "0x1712B7C", VA = "0x1712B7C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
