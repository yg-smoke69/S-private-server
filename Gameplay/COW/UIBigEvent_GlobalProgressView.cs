using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033F4")]
public class UIBigEvent_GlobalProgressView : UIBaseView
{
	[Token(Token = "0x4013FDB")]
	[FieldOffset(Offset = "0x14")]
	public GameObject TopLeft;

	[Token(Token = "0x4013FDC")]
	[FieldOffset(Offset = "0x18")]
	public UINetworkTexture TextureTitle;

	[Token(Token = "0x4013FDD")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnRule;

	[Token(Token = "0x4013FDE")]
	[FieldOffset(Offset = "0x20")]
	public UILabel LabelOpenTime;

	[Token(Token = "0x4013FDF")]
	[FieldOffset(Offset = "0x24")]
	public UIButton BtnClose;

	[Token(Token = "0x4013FE0")]
	[FieldOffset(Offset = "0x28")]
	public UISprite SpriteBtnClose;

	[Token(Token = "0x4013FE1")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject Right;

	[Token(Token = "0x4013FE2")]
	[FieldOffset(Offset = "0x30")]
	public UILabel LabelProgress;

	[Token(Token = "0x4013FE3")]
	[FieldOffset(Offset = "0x34")]
	public UINetworkTexture TextureLabelProgressBg;

	[Token(Token = "0x4013FE4")]
	[FieldOffset(Offset = "0x38")]
	public UIProgressBar ProgressBar;

	[Token(Token = "0x4013FE5")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite ProcessBarBg;

	[Token(Token = "0x4013FE6")]
	[FieldOffset(Offset = "0x40")]
	public Transform TrBarItemRoot;

	[Token(Token = "0x4013FE7")]
	[FieldOffset(Offset = "0x44")]
	public Transform TrAdsScrollRoot;

	[Token(Token = "0x4013FE8")]
	[FieldOffset(Offset = "0x48")]
	public UINetworkTexture TextureAdsBg;

	[Token(Token = "0x4013FE9")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject Left;

	[Token(Token = "0x4013FEA")]
	[FieldOffset(Offset = "0x50")]
	public UIGrid GridLeftBtns;

	[Token(Token = "0x4013FEB")]
	[FieldOffset(Offset = "0x54")]
	public UIButton Mask;

	[Token(Token = "0x4013FEC")]
	[FieldOffset(Offset = "0x58")]
	public UINetworkTexture TextureBg;

	[Token(Token = "0x4013FED")]
	[FieldOffset(Offset = "0x5C")]
	public UIButton BtnShare;

	[Token(Token = "0x4013FEE")]
	[FieldOffset(Offset = "0x60")]
	public UINetworkTexture TextureShare;

	[Token(Token = "0x4013FEF")]
	[FieldOffset(Offset = "0x64")]
	public GameObject Content;

	[Token(Token = "0x4013FF0")]
	[FieldOffset(Offset = "0x68")]
	public GameObject ShareCDN;

	[Token(Token = "0x4013FF1")]
	[FieldOffset(Offset = "0x6C")]
	public UISprite IconOpenTime;

	[Token(Token = "0x4013FF2")]
	[FieldOffset(Offset = "0x70")]
	public UINetworkTexture TextureShareBtn;

	[Token(Token = "0x6015F90")]
	[Address(RVA = "0x301D354", Offset = "0x301D354", VA = "0x301D354")]
	public UIBigEvent_GlobalProgressView()
	{
	}

	[Token(Token = "0x6015F91")]
	[Address(RVA = "0x301D35C", Offset = "0x301D35C", VA = "0x301D35C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015F92")]
	[Address(RVA = "0x301DD18", Offset = "0x301DD18", VA = "0x301DD18")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
