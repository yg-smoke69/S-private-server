using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037F2")]
public class UIIAPBundlePreviewItemView : UIBaseView
{
	[Token(Token = "0x4016B2E")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ClickBtn;

	[Token(Token = "0x4016B2F")]
	[FieldOffset(Offset = "0x18")]
	public BaseItemView IAPBundleItemView;

	[Token(Token = "0x4016B30")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite BundleIconSprite;

	[Token(Token = "0x4016B31")]
	[FieldOffset(Offset = "0x20")]
	public UILabel BundleNameLabel;

	[Token(Token = "0x4016B32")]
	[FieldOffset(Offset = "0x24")]
	public UILabel BundlePriceLabel;

	[Token(Token = "0x4016B33")]
	[FieldOffset(Offset = "0x28")]
	public UILabel OriginalPriceLabel;

	[Token(Token = "0x6016B81")]
	[Address(RVA = "0xD40550", Offset = "0xD40550", VA = "0xD40550")]
	public UIIAPBundlePreviewItemView()
	{
	}

	[Token(Token = "0x6016B82")]
	[Address(RVA = "0xD40558", Offset = "0xD40558", VA = "0xD40558", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016B83")]
	[Address(RVA = "0xD408E0", Offset = "0xD408E0", VA = "0xD408E0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
