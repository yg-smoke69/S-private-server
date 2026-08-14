using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035A5")]
public class UIGameModeClassicMapListView : UIBaseView
{
	[Token(Token = "0x4015691")]
	[FieldOffset(Offset = "0x14")]
	public TweenAlpha paradiseAlpha;

	[Token(Token = "0x4015692")]
	[FieldOffset(Offset = "0x18")]
	public TweenScale paradiseScale;

	[Token(Token = "0x4015693")]
	[FieldOffset(Offset = "0x1C")]
	public UIToggleButton ParadiseBtn;

	[Token(Token = "0x4015694")]
	[FieldOffset(Offset = "0x20")]
	public GameObject paradiseclickEffect;

	[Token(Token = "0x4015695")]
	[FieldOffset(Offset = "0x24")]
	public UISprite ModeSpriteParadise;

	[Token(Token = "0x4015696")]
	[FieldOffset(Offset = "0x28")]
	public UINetworkTexture NetworkTextureParadise;

	[Token(Token = "0x4015697")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel modeNameParadise;

	[Token(Token = "0x4015698")]
	[FieldOffset(Offset = "0x30")]
	public GameObject download;

	[Token(Token = "0x4015699")]
	[FieldOffset(Offset = "0x34")]
	public TweenAlpha azoreAlpha;

	[Token(Token = "0x401569A")]
	[FieldOffset(Offset = "0x38")]
	public TweenScale azoreScale;

	[Token(Token = "0x401569B")]
	[FieldOffset(Offset = "0x3C")]
	public UIToggleButton AzoreBtn;

	[Token(Token = "0x401569C")]
	[FieldOffset(Offset = "0x40")]
	public GameObject azoreclickEffect;

	[Token(Token = "0x401569D")]
	[FieldOffset(Offset = "0x44")]
	public UISprite ModeSpriteAzore;

	[Token(Token = "0x401569E")]
	[FieldOffset(Offset = "0x48")]
	public UILabel modeNameAzore;

	[Token(Token = "0x401569F")]
	[FieldOffset(Offset = "0x4C")]
	public UINetworkTexture NetworkTextureAzore;

	[Token(Token = "0x40156A0")]
	[FieldOffset(Offset = "0x50")]
	public GameObject mask_bottom;

	[Token(Token = "0x601649D")]
	[Address(RVA = "0x217D0E8", Offset = "0x217D0E8", VA = "0x217D0E8")]
	public UIGameModeClassicMapListView()
	{
	}

	[Token(Token = "0x601649E")]
	[Address(RVA = "0x217D0F0", Offset = "0x217D0F0", VA = "0x217D0F0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601649F")]
	[Address(RVA = "0x217D808", Offset = "0x217D808", VA = "0x217D808")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
