using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200381C")]
public class UILegendClothVaultColorView : UIBaseView
{
	[Token(Token = "0x4016D8D")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnColor;

	[Token(Token = "0x4016D8E")]
	[FieldOffset(Offset = "0x18")]
	public UISprite SpriteColor;

	[Token(Token = "0x4016D8F")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite SpriteNotArmedMask;

	[Token(Token = "0x4016D90")]
	[FieldOffset(Offset = "0x20")]
	public GameObject GoColorSelect;

	[Token(Token = "0x4016D91")]
	[FieldOffset(Offset = "0x24")]
	public UISprite SpriteLock;

	[Token(Token = "0x4016D92")]
	[FieldOffset(Offset = "0x28")]
	public UIButton BtnColorLittle;

	[Token(Token = "0x4016D93")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite SpriteColorLittle;

	[Token(Token = "0x4016D94")]
	[FieldOffset(Offset = "0x30")]
	public UISprite SpriteLockLittle;

	[Token(Token = "0x4016D95")]
	[FieldOffset(Offset = "0x34")]
	public UISprite SpriteColorLittleSelect;

	[Token(Token = "0x6016BFF")]
	[Address(RVA = "0x1AA5614", Offset = "0x1AA5614", VA = "0x1AA5614")]
	public UILegendClothVaultColorView()
	{
	}

	[Token(Token = "0x6016C00")]
	[Address(RVA = "0x1AA561C", Offset = "0x1AA561C", VA = "0x1AA561C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016C01")]
	[Address(RVA = "0x1AA5AB8", Offset = "0x1AA5AB8", VA = "0x1AA5AB8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
