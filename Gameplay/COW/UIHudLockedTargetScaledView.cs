using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003695")]
public class UIHudLockedTargetScaledView : UIBaseView
{
	[Token(Token = "0x4015F68")]
	[FieldOffset(Offset = "0x14")]
	public UISprite Boarder;

	[Token(Token = "0x4015F69")]
	[FieldOffset(Offset = "0x18")]
	public TweenAlpha TweenAlpha;

	[Token(Token = "0x601676C")]
	[Address(RVA = "0xFEE018", Offset = "0xFEE018", VA = "0xFEE018")]
	public UIHudLockedTargetScaledView()
	{
	}

	[Token(Token = "0x601676D")]
	[Address(RVA = "0xFEE020", Offset = "0xFEE020", VA = "0xFEE020", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601676E")]
	[Address(RVA = "0xFEE228", Offset = "0xFEE228", VA = "0xFEE228")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
