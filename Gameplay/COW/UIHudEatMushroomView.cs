using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200363D")]
public class UIHudEatMushroomView : UIBaseView
{
	[Token(Token = "0x4015C1F")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnEat;

	[Token(Token = "0x4015C20")]
	[FieldOffset(Offset = "0x18")]
	public UISprite Icon;

	[Token(Token = "0x4015C21")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite SpriteBg;

	[Token(Token = "0x4015C22")]
	[FieldOffset(Offset = "0x20")]
	public UILabel ActionName;

	[Token(Token = "0x4015C23")]
	[FieldOffset(Offset = "0x24")]
	public UISprite Cooldown;

	[Token(Token = "0x6016664")]
	[Address(RVA = "0x1CDDD94", Offset = "0x1CDDD94", VA = "0x1CDDD94")]
	public UIHudEatMushroomView()
	{
	}

	[Token(Token = "0x6016665")]
	[Address(RVA = "0x1CDDD9C", Offset = "0x1CDDD9C", VA = "0x1CDDD9C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016666")]
	[Address(RVA = "0x1CDE0C4", Offset = "0x1CDE0C4", VA = "0x1CDE0C4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
