using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003831")]
public class UILoadingPlayerInfoView : UIBaseView
{
	[Token(Token = "0x4016E97")]
	[FieldOffset(Offset = "0x14")]
	public UISprite SpriteBg;

	[Token(Token = "0x4016E98")]
	[FieldOffset(Offset = "0x18")]
	public UISprite SpriteHeadIcon;

	[Token(Token = "0x4016E99")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LabelNickName;

	[Token(Token = "0x4016E9A")]
	[FieldOffset(Offset = "0x20")]
	public UISprite SpriteBgName;

	[Token(Token = "0x4016E9B")]
	[FieldOffset(Offset = "0x24")]
	public UISprite SpriteEP;

	[Token(Token = "0x4016E9C")]
	[FieldOffset(Offset = "0x28")]
	public UILabel LabelEPCount;

	[Token(Token = "0x4016E9D")]
	[FieldOffset(Offset = "0x2C")]
	public UIPanel PanelCharacter;

	[Token(Token = "0x4016E9E")]
	[FieldOffset(Offset = "0x30")]
	public UISprite SpriteCharacter;

	[Token(Token = "0x4016E9F")]
	[FieldOffset(Offset = "0x34")]
	public UISprite SpriteFormerMaster;

	[Token(Token = "0x4016EA0")]
	[FieldOffset(Offset = "0x38")]
	public UISprite SpriteRankIcon;

	[Token(Token = "0x4016EA1")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel LabelRankPoint;

	[Token(Token = "0x4016EA2")]
	[FieldOffset(Offset = "0x40")]
	public UIGrid Grid;

	[Token(Token = "0x4016EA3")]
	[FieldOffset(Offset = "0x44")]
	public UISprite SpriteInfoPanelBg;

	[Token(Token = "0x4016EA4")]
	[FieldOffset(Offset = "0x48")]
	public UIGrid GridInfo;

	[Token(Token = "0x6016C3E")]
	[Address(RVA = "0x2158978", Offset = "0x2158978", VA = "0x2158978")]
	public UILoadingPlayerInfoView()
	{
	}

	[Token(Token = "0x6016C3F")]
	[Address(RVA = "0x215B91C", Offset = "0x215B91C", VA = "0x215B91C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016C40")]
	[Address(RVA = "0x215BFA4", Offset = "0x215BFA4", VA = "0x215BFA4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
