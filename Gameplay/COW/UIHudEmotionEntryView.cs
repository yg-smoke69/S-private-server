using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200363F")]
public class UIHudEmotionEntryView : UIBaseView
{
	[Token(Token = "0x4015C25")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnEmotionEntry;

	[Token(Token = "0x4015C26")]
	[FieldOffset(Offset = "0x18")]
	public Transform iconEmotion;

	[Token(Token = "0x4015C27")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite iconWidget;

	[Token(Token = "0x4015C28")]
	[FieldOffset(Offset = "0x20")]
	public UISprite SpriteNormal;

	[Token(Token = "0x601666A")]
	[Address(RVA = "0x1CE1C7C", Offset = "0x1CE1C7C", VA = "0x1CE1C7C")]
	public UIHudEmotionEntryView()
	{
	}

	[Token(Token = "0x601666B")]
	[Address(RVA = "0x1CE1C84", Offset = "0x1CE1C84", VA = "0x1CE1C84", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601666C")]
	[Address(RVA = "0x1CE1F24", Offset = "0x1CE1F24", VA = "0x1CE1F24")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
