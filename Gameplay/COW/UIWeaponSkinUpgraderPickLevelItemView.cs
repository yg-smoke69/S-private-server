using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A78")]
public class UIWeaponSkinUpgraderPickLevelItemView : UIBaseView
{
	[Token(Token = "0x4018D31")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnWeaponSkinPickLevel;

	[Token(Token = "0x4018D32")]
	[FieldOffset(Offset = "0x18")]
	public UISprite SpriteRoundLight;

	[Token(Token = "0x4018D33")]
	[FieldOffset(Offset = "0x1C")]
	public UIGrid propertyGrid;

	[Token(Token = "0x4018D34")]
	[FieldOffset(Offset = "0x20")]
	public UISprite SpriteWeaponSkinPickLevel;

	[Token(Token = "0x4018D35")]
	[FieldOffset(Offset = "0x24")]
	public UISprite SpriteLock;

	[Token(Token = "0x4018D36")]
	[FieldOffset(Offset = "0x28")]
	public UILabel LabelLevel;

	[Token(Token = "0x601730E")]
	[Address(RVA = "0x1B74FCC", Offset = "0x1B74FCC", VA = "0x1B74FCC")]
	public UIWeaponSkinUpgraderPickLevelItemView()
	{
	}

	[Token(Token = "0x601730F")]
	[Address(RVA = "0x1B74FD4", Offset = "0x1B74FD4", VA = "0x1B74FD4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017310")]
	[Address(RVA = "0x1B7535C", Offset = "0x1B7535C", VA = "0x1B7535C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
