using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003841")]
public class UILobbyIceWallDisplayItemView : UIBaseView
{
	[Token(Token = "0x4016F94")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ItemButton;

	[Token(Token = "0x4016F95")]
	[FieldOffset(Offset = "0x18")]
	public UISprite Quality;

	[Token(Token = "0x4016F96")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite SpriteQualityPlus;

	[Token(Token = "0x4016F97")]
	[FieldOffset(Offset = "0x20")]
	public UISprite QualityBG;

	[Token(Token = "0x4016F98")]
	[FieldOffset(Offset = "0x24")]
	public GameObject effectBg;

	[Token(Token = "0x4016F99")]
	[FieldOffset(Offset = "0x28")]
	public UISprite IceSprite;

	[Token(Token = "0x4016F9A")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject HL;

	[Token(Token = "0x4016F9B")]
	[FieldOffset(Offset = "0x30")]
	public GameObject NewTips;

	[Token(Token = "0x4016F9C")]
	[FieldOffset(Offset = "0x34")]
	public UIWidget GuideRoot;

	[Token(Token = "0x4016F9D")]
	[FieldOffset(Offset = "0x38")]
	public UISprite SpriteOrangeQualityPlus;

	[Token(Token = "0x4016F9E")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject DownloadRoot;

	[Token(Token = "0x6016C6E")]
	[Address(RVA = "0xDB9BF0", Offset = "0xDB9BF0", VA = "0xDB9BF0")]
	public UILobbyIceWallDisplayItemView()
	{
	}

	[Token(Token = "0x6016C6F")]
	[Address(RVA = "0xDB9BF8", Offset = "0xDB9BF8", VA = "0xDB9BF8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016C70")]
	[Address(RVA = "0xDBA130", Offset = "0xDBA130", VA = "0xDBA130")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
