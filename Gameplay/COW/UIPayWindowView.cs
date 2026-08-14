using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038FE")]
public class UIPayWindowView : UIBaseView
{
	[Token(Token = "0x4017B0B")]
	[FieldOffset(Offset = "0x14")]
	public UIButton RebateCardButton;

	[Token(Token = "0x4017B0C")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BtnClose;

	[Token(Token = "0x4017B0D")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite bg;

	[Token(Token = "0x4017B0E")]
	[FieldOffset(Offset = "0x20")]
	public UINetworkTextureExt MainAdNetworkTexture;

	[Token(Token = "0x4017B0F")]
	[FieldOffset(Offset = "0x24")]
	public UIButton MainAdButton;

	[Token(Token = "0x4017B10")]
	[FieldOffset(Offset = "0x28")]
	public GameObject IOSPayContainer;

	[Token(Token = "0x4017B11")]
	[FieldOffset(Offset = "0x2C")]
	public UIScrollView IOSPayScrollview;

	[Token(Token = "0x4017B12")]
	[FieldOffset(Offset = "0x30")]
	public UIGrid IOSPayGrid;

	[Token(Token = "0x4017B13")]
	[FieldOffset(Offset = "0x34")]
	public GameObject AndroidPayContainer;

	[Token(Token = "0x4017B14")]
	[FieldOffset(Offset = "0x38")]
	public UIButton AndroidBtn1;

	[Token(Token = "0x4017B15")]
	[FieldOffset(Offset = "0x3C")]
	public UINetworkTextureExt AndroidImage1;

	[Token(Token = "0x4017B16")]
	[FieldOffset(Offset = "0x40")]
	public UIButton AndroidBtn2;

	[Token(Token = "0x4017B17")]
	[FieldOffset(Offset = "0x44")]
	public UINetworkTextureExt AndroidImage2;

	[Token(Token = "0x4017B18")]
	[FieldOffset(Offset = "0x48")]
	public UIButton AndroidBtn3;

	[Token(Token = "0x4017B19")]
	[FieldOffset(Offset = "0x4C")]
	public UINetworkTextureExt AndroidImage3;

	[Token(Token = "0x6016EA3")]
	[Address(RVA = "0x15BB92C", Offset = "0x15BB92C", VA = "0x15BB92C")]
	public UIPayWindowView()
	{
	}

	[Token(Token = "0x6016EA4")]
	[Address(RVA = "0x15BB934", Offset = "0x15BB934", VA = "0x15BB934", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016EA5")]
	[Address(RVA = "0x15BC004", Offset = "0x15BC004", VA = "0x15BC004")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
