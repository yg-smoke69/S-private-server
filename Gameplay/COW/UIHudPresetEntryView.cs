using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036E9")]
public class UIHudPresetEntryView : UIBaseView
{
	[Token(Token = "0x4016304")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnShop;

	[Token(Token = "0x4016305")]
	[FieldOffset(Offset = "0x18")]
	public UISprite SpriteBg;

	[Token(Token = "0x4016306")]
	[FieldOffset(Offset = "0x1C")]
	public ParticleSystem FlashEffect;

	[Token(Token = "0x6016866")]
	[Address(RVA = "0x1FC4A9C", Offset = "0x1FC4A9C", VA = "0x1FC4A9C")]
	public UIHudPresetEntryView()
	{
	}

	[Token(Token = "0x6016867")]
	[Address(RVA = "0x1FC4AA4", Offset = "0x1FC4AA4", VA = "0x1FC4AA4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016868")]
	[Address(RVA = "0x1FC4D0C", Offset = "0x1FC4D0C", VA = "0x1FC4D0C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
