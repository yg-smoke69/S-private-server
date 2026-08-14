using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200393B")]
public class UIPVEWeaponSkinItemView : UIBaseView
{
	[Token(Token = "0x4017F29")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ItemBtn;

	[Token(Token = "0x4017F2A")]
	[FieldOffset(Offset = "0x18")]
	public UISprite qualityBg;

	[Token(Token = "0x4017F2B")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite itemSprite;

	[Token(Token = "0x4017F2C")]
	[FieldOffset(Offset = "0x20")]
	public GameObject skillicon;

	[Token(Token = "0x4017F2D")]
	[FieldOffset(Offset = "0x24")]
	public GameObject bg_empty;

	[Token(Token = "0x4017F2E")]
	[FieldOffset(Offset = "0x28")]
	public GameObject TipsGO;

	[Token(Token = "0x4017F2F")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel TagLabel;

	[Token(Token = "0x4017F30")]
	[FieldOffset(Offset = "0x30")]
	public GameObject HL;

	[Token(Token = "0x4017F31")]
	[FieldOffset(Offset = "0x34")]
	public UISprite validSprite;

	[Token(Token = "0x4017F32")]
	[FieldOffset(Offset = "0x38")]
	public UILabel valid;

	[Token(Token = "0x4017F33")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite descSprite;

	[Token(Token = "0x4017F34")]
	[FieldOffset(Offset = "0x40")]
	public UILabel description;

	[Token(Token = "0x4017F35")]
	[FieldOffset(Offset = "0x44")]
	public UISprite Download;

	[Token(Token = "0x6016F58")]
	[Address(RVA = "0x15B0EB0", Offset = "0x15B0EB0", VA = "0x15B0EB0")]
	public UIPVEWeaponSkinItemView()
	{
	}

	[Token(Token = "0x6016F59")]
	[Address(RVA = "0x15B0EB8", Offset = "0x15B0EB8", VA = "0x15B0EB8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016F5A")]
	[Address(RVA = "0x15B14B0", Offset = "0x15B14B0", VA = "0x15B14B0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
