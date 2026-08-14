using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033EB")]
public class UIBigEvent_GlobalProgress_BarItemView : UIBaseView
{
	[Token(Token = "0x4013F76")]
	[FieldOffset(Offset = "0x14")]
	public UILabel LabelPercentage;

	[Token(Token = "0x4013F77")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BtnAward;

	[Token(Token = "0x4013F78")]
	[FieldOffset(Offset = "0x1C")]
	public UINetworkTexture TextureRewardCantClaimMask;

	[Token(Token = "0x4013F79")]
	[FieldOffset(Offset = "0x20")]
	public UISprite SpriteRedDot;

	[Token(Token = "0x4013F7A")]
	[FieldOffset(Offset = "0x24")]
	public UINetworkTexture TextureRewardBg;

	[Token(Token = "0x4013F7B")]
	[FieldOffset(Offset = "0x28")]
	public Transform TrItemRoot;

	[Token(Token = "0x4013F7C")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject GoFinish;

	[Token(Token = "0x6015F75")]
	[Address(RVA = "0x301EE70", Offset = "0x301EE70", VA = "0x301EE70")]
	public UIBigEvent_GlobalProgress_BarItemView()
	{
	}

	[Token(Token = "0x6015F76")]
	[Address(RVA = "0x301EE78", Offset = "0x301EE78", VA = "0x301EE78", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015F77")]
	[Address(RVA = "0x301F22C", Offset = "0x301F22C", VA = "0x301F22C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
