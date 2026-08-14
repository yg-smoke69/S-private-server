using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200346F")]
public class UICollectionMusicItemView : UIBaseView
{
	[Token(Token = "0x401463C")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ItemBtn;

	[Token(Token = "0x401463D")]
	[FieldOffset(Offset = "0x18")]
	public GameObject gray;

	[Token(Token = "0x401463E")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite itemSprite;

	[Token(Token = "0x401463F")]
	[FieldOffset(Offset = "0x20")]
	public UILabel name;

	[Token(Token = "0x4014640")]
	[FieldOffset(Offset = "0x24")]
	public UISprite SpriteQualityPlus;

	[Token(Token = "0x4014641")]
	[FieldOffset(Offset = "0x28")]
	public UISprite Quality;

	[Token(Token = "0x4014642")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite QualityBG;

	[Token(Token = "0x4014643")]
	[FieldOffset(Offset = "0x30")]
	public GameObject HL;

	[Token(Token = "0x4014644")]
	[FieldOffset(Offset = "0x34")]
	public GameObject equipState;

	[Token(Token = "0x4014645")]
	[FieldOffset(Offset = "0x38")]
	public UISprite validSprite;

	[Token(Token = "0x4014646")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel valid;

	[Token(Token = "0x4014647")]
	[FieldOffset(Offset = "0x40")]
	public GameObject Download;

	[Token(Token = "0x4014648")]
	[FieldOffset(Offset = "0x44")]
	public UISprite defaultTagIcon;

	[Token(Token = "0x4014649")]
	[FieldOffset(Offset = "0x48")]
	public UISprite ipTagIcon;

	[Token(Token = "0x401464A")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite SpriteOrangeQualityPlus;

	[Token(Token = "0x6016101")]
	[Address(RVA = "0x2CD4B7C", Offset = "0x2CD4B7C", VA = "0x2CD4B7C")]
	public UICollectionMusicItemView()
	{
	}

	[Token(Token = "0x6016102")]
	[Address(RVA = "0x2CD4B84", Offset = "0x2CD4B84", VA = "0x2CD4B84", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016103")]
	[Address(RVA = "0x2CD523C", Offset = "0x2CD523C", VA = "0x2CD523C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
