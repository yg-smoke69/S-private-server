using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200353F")]
public class UIForgeItemView : UIBaseView
{
	[Token(Token = "0x401511A")]
	[FieldOffset(Offset = "0x14")]
	public UIButton UIForgeItem;

	[Token(Token = "0x401511B")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Default;

	[Token(Token = "0x401511C")]
	[FieldOffset(Offset = "0x1C")]
	public UITexture LocalImg;

	[Token(Token = "0x401511D")]
	[FieldOffset(Offset = "0x20")]
	public UINetworkTexture NetworkTexture;

	[Token(Token = "0x401511E")]
	[FieldOffset(Offset = "0x24")]
	public GameObject HighLightBG;

	[Token(Token = "0x401511F")]
	[FieldOffset(Offset = "0x28")]
	public SetRelativeDepth ItemVFX;

	[Token(Token = "0x4015120")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite BG;

	[Token(Token = "0x4015121")]
	[FieldOffset(Offset = "0x30")]
	public UISprite BigAward;

	[Token(Token = "0x4015122")]
	[FieldOffset(Offset = "0x34")]
	public UITable PriceContainer;

	[Token(Token = "0x4015123")]
	[FieldOffset(Offset = "0x38")]
	public UISprite Material1Icon;

	[Token(Token = "0x4015124")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel Material1Cnt;

	[Token(Token = "0x4015125")]
	[FieldOffset(Offset = "0x40")]
	public GameObject Add;

	[Token(Token = "0x4015126")]
	[FieldOffset(Offset = "0x44")]
	public UISprite Material2Icon;

	[Token(Token = "0x4015127")]
	[FieldOffset(Offset = "0x48")]
	public UILabel Material2Cnt;

	[Token(Token = "0x4015128")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite PriceBG;

	[Token(Token = "0x4015129")]
	[FieldOffset(Offset = "0x50")]
	public GameObject OwnedTitle;

	[Token(Token = "0x601636D")]
	[Address(RVA = "0x1B699F4", Offset = "0x1B699F4", VA = "0x1B699F4")]
	public UIForgeItemView()
	{
	}

	[Token(Token = "0x601636E")]
	[Address(RVA = "0x1B699FC", Offset = "0x1B699FC", VA = "0x1B699FC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601636F")]
	[Address(RVA = "0x1B6A114", Offset = "0x1B6A114", VA = "0x1B6A114")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
