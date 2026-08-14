using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037F1")]
public class UIIAPBundleContentItemView : UIBaseView
{
	[Token(Token = "0x4016B24")]
	[FieldOffset(Offset = "0x14")]
	public UIButton IAPBundleButton;

	[Token(Token = "0x4016B25")]
	[FieldOffset(Offset = "0x18")]
	public BaseItemView IAPBundleItemView;

	[Token(Token = "0x4016B26")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite BG;

	[Token(Token = "0x4016B27")]
	[FieldOffset(Offset = "0x20")]
	public UISprite IconSprite;

	[Token(Token = "0x4016B28")]
	[FieldOffset(Offset = "0x24")]
	public UISprite NotchSprite;

	[Token(Token = "0x4016B29")]
	[FieldOffset(Offset = "0x28")]
	public UILabel DurationLabel;

	[Token(Token = "0x4016B2A")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite ClockSprite;

	[Token(Token = "0x4016B2B")]
	[FieldOffset(Offset = "0x30")]
	public UILabel AmountLabel;

	[Token(Token = "0x4016B2C")]
	[FieldOffset(Offset = "0x34")]
	public GameObject Owned;

	[Token(Token = "0x4016B2D")]
	[FieldOffset(Offset = "0x38")]
	public UILabel OwnedLabel;

	[Token(Token = "0x6016B7E")]
	[Address(RVA = "0xD3937C", Offset = "0xD3937C", VA = "0xD3937C")]
	public UIIAPBundleContentItemView()
	{
	}

	[Token(Token = "0x6016B7F")]
	[Address(RVA = "0xD39384", Offset = "0xD39384", VA = "0xD39384", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016B80")]
	[Address(RVA = "0xD39880", Offset = "0xD39880", VA = "0xD39880")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
