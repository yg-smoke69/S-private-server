using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200384F")]
public class UILobbySkyboardDisplayItemView : UIBaseView
{
	[Token(Token = "0x4017108")]
	[FieldOffset(Offset = "0x14")]
	public UIButton UILobbySkyboardDisplayItem;

	[Token(Token = "0x4017109")]
	[FieldOffset(Offset = "0x18")]
	public UISprite Quality;

	[Token(Token = "0x401710A")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite QualityBg;

	[Token(Token = "0x401710B")]
	[FieldOffset(Offset = "0x20")]
	public UISprite SpriteQualityPlus;

	[Token(Token = "0x401710C")]
	[FieldOffset(Offset = "0x24")]
	public GameObject DownloadRoot;

	[Token(Token = "0x401710D")]
	[FieldOffset(Offset = "0x28")]
	public UISprite EffectBg;

	[Token(Token = "0x401710E")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite SkateboardSprite;

	[Token(Token = "0x401710F")]
	[FieldOffset(Offset = "0x30")]
	public GameObject HL;

	[Token(Token = "0x4017110")]
	[FieldOffset(Offset = "0x34")]
	public GameObject TipsNew;

	[Token(Token = "0x4017111")]
	[FieldOffset(Offset = "0x38")]
	public UISprite SpriteOrangeQualityPlus;

	[Token(Token = "0x6016C98")]
	[Address(RVA = "0x1CB9F34", Offset = "0x1CB9F34", VA = "0x1CB9F34")]
	public UILobbySkyboardDisplayItemView()
	{
	}

	[Token(Token = "0x6016C99")]
	[Address(RVA = "0x1CB9F3C", Offset = "0x1CB9F3C", VA = "0x1CB9F3C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016C9A")]
	[Address(RVA = "0x1CBA420", Offset = "0x1CBA420", VA = "0x1CBA420")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
