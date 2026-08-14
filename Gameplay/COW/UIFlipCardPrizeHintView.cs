using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200353E")]
public class UIFlipCardPrizeHintView : UIBaseView
{
	[Token(Token = "0x4015118")]
	[FieldOffset(Offset = "0x14")]
	public UIButton CloseBtn;

	[Token(Token = "0x4015119")]
	[FieldOffset(Offset = "0x18")]
	public UINetworkTexture Texture;

	[Token(Token = "0x601636A")]
	[Address(RVA = "0x1B5EA74", Offset = "0x1B5EA74", VA = "0x1B5EA74")]
	public UIFlipCardPrizeHintView()
	{
	}

	[Token(Token = "0x601636B")]
	[Address(RVA = "0x1B5EA7C", Offset = "0x1B5EA7C", VA = "0x1B5EA7C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601636C")]
	[Address(RVA = "0x1B5EC84", Offset = "0x1B5EC84", VA = "0x1B5EC84")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
