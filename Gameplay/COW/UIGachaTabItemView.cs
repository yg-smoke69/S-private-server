using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003599")]
public class UIGachaTabItemView : UIBaseView
{
	[Token(Token = "0x40155BC")]
	[FieldOffset(Offset = "0x14")]
	public Animation AnimationScale;

	[Token(Token = "0x40155BD")]
	[FieldOffset(Offset = "0x18")]
	public UINetworkTexture NetworkTexture;

	[Token(Token = "0x40155BE")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton ItemBtn;

	[Token(Token = "0x40155BF")]
	[FieldOffset(Offset = "0x20")]
	public UISprite Icon;

	[Token(Token = "0x40155C0")]
	[FieldOffset(Offset = "0x24")]
	public UISprite NewsIcon;

	[Token(Token = "0x40155C1")]
	[FieldOffset(Offset = "0x28")]
	public GameObject Effect_Glow;

	[Token(Token = "0x40155C2")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject RoyalVFX;

	[Token(Token = "0x601647B")]
	[Address(RVA = "0x2A2FABC", Offset = "0x2A2FABC", VA = "0x2A2FABC")]
	public UIGachaTabItemView()
	{
	}

	[Token(Token = "0x601647C")]
	[Address(RVA = "0x2A2FAC4", Offset = "0x2A2FAC4", VA = "0x2A2FAC4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601647D")]
	[Address(RVA = "0x2A2FE94", Offset = "0x2A2FE94", VA = "0x2A2FE94")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
