using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200369E")]
public class UIHUDLudoPlayerHeadInfoView : UIBaseView
{
	[Token(Token = "0x4015F99")]
	[FieldOffset(Offset = "0x14")]
	public UIEffectSprite RandomSprite;

	[Token(Token = "0x4015F9A")]
	[FieldOffset(Offset = "0x18")]
	public UIEffectSprite MovingSprite;

	[Token(Token = "0x4015F9B")]
	[FieldOffset(Offset = "0x1C")]
	public UIEffectSprite PersonHeadSprite;

	[Token(Token = "0x4015F9C")]
	[FieldOffset(Offset = "0x20")]
	public UISprite ProcessSprite;

	[Token(Token = "0x4015F9D")]
	[FieldOffset(Offset = "0x24")]
	public GameObject Trust;

	[Token(Token = "0x4015F9E")]
	[FieldOffset(Offset = "0x28")]
	public UILabel ChessType;

	[Token(Token = "0x4015F9F")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite ChessBg;

	[Token(Token = "0x4015FA0")]
	[FieldOffset(Offset = "0x30")]
	public UIEffectSprite LocalPlayerBg;

	[Token(Token = "0x6016787")]
	[Address(RVA = "0x16800CC", Offset = "0x16800CC", VA = "0x16800CC")]
	public UIHUDLudoPlayerHeadInfoView()
	{
	}

	[Token(Token = "0x6016788")]
	[Address(RVA = "0x16800D4", Offset = "0x16800D4", VA = "0x16800D4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016789")]
	[Address(RVA = "0x1680510", Offset = "0x1680510", VA = "0x1680510")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
