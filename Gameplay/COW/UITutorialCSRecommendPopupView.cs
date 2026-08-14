using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A14")]
public class UITutorialCSRecommendPopupView : UIBaseView
{
	[Token(Token = "0x4018866")]
	[FieldOffset(Offset = "0x14")]
	public UINetworkTextureExt TextureCdn;

	[Token(Token = "0x4018867")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BtnConfirm;

	[Token(Token = "0x4018868")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnSkip;

	[Token(Token = "0x60171E2")]
	[Address(RVA = "0x1C3B170", Offset = "0x1C3B170", VA = "0x1C3B170")]
	public UITutorialCSRecommendPopupView()
	{
	}

	[Token(Token = "0x60171E3")]
	[Address(RVA = "0x1C3B178", Offset = "0x1C3B178", VA = "0x1C3B178", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60171E4")]
	[Address(RVA = "0x1C3B3E0", Offset = "0x1C3B3E0", VA = "0x1C3B3E0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
