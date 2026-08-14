using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033EC")]
public class UIBigEvent_GlobalProgress_BtnItemView : UIBaseView
{
	[Token(Token = "0x4013F7D")]
	[FieldOffset(Offset = "0x14")]
	public UIButton Btn;

	[Token(Token = "0x4013F7E")]
	[FieldOffset(Offset = "0x18")]
	public UINetworkTexture TextureIcon;

	[Token(Token = "0x4013F7F")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LabelTitle;

	[Token(Token = "0x4013F80")]
	[FieldOffset(Offset = "0x20")]
	public UISprite SpriteRedDot;

	[Token(Token = "0x4013F81")]
	[FieldOffset(Offset = "0x24")]
	public GameObject GoBubble;

	[Token(Token = "0x4013F82")]
	[FieldOffset(Offset = "0x28")]
	public UILabel LabelBubble;

	[Token(Token = "0x4013F83")]
	[FieldOffset(Offset = "0x2C")]
	public TweenScale PeakDayBubbleShake;

	[Token(Token = "0x4013F84")]
	[FieldOffset(Offset = "0x30")]
	public UINetworkTexture TextureBubble;

	[Token(Token = "0x6015F78")]
	[Address(RVA = "0x302080C", Offset = "0x302080C", VA = "0x302080C")]
	public UIBigEvent_GlobalProgress_BtnItemView()
	{
	}

	[Token(Token = "0x6015F79")]
	[Address(RVA = "0x3020814", Offset = "0x3020814", VA = "0x3020814", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015F7A")]
	[Address(RVA = "0x3020C50", Offset = "0x3020C50", VA = "0x3020C50")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
