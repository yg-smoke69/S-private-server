using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035E4")]
public class UIHudBannerTweenTipsView : UIBaseView
{
	[Token(Token = "0x4015928")]
	[FieldOffset(Offset = "0x14")]
	public UILabel LabelHint;

	[Token(Token = "0x4015929")]
	[FieldOffset(Offset = "0x18")]
	public Transform TrRootCharacter;

	[Token(Token = "0x401592A")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject GoWithKelly;

	[Token(Token = "0x401592B")]
	[FieldOffset(Offset = "0x20")]
	public GameObject GoBanner;

	[Token(Token = "0x401592C")]
	[FieldOffset(Offset = "0x24")]
	public UILabel LabelHintBanner;

	[Token(Token = "0x401592D")]
	[FieldOffset(Offset = "0x28")]
	public UISprite Icon;

	[Token(Token = "0x601655A")]
	[Address(RVA = "0x1DF8FB4", Offset = "0x1DF8FB4", VA = "0x1DF8FB4")]
	public UIHudBannerTweenTipsView()
	{
	}

	[Token(Token = "0x601655B")]
	[Address(RVA = "0x1DF8FBC", Offset = "0x1DF8FBC", VA = "0x1DF8FBC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601655C")]
	[Address(RVA = "0x1DF9304", Offset = "0x1DF9304", VA = "0x1DF9304")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
