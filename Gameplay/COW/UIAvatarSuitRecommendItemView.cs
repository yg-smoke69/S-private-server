using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033DD")]
public class UIAvatarSuitRecommendItemView : UIBaseView
{
	[Token(Token = "0x4013EC9")]
	[FieldOffset(Offset = "0x14")]
	public UIButton RecommendBuyBtn;

	[Token(Token = "0x4013ECA")]
	[FieldOffset(Offset = "0x18")]
	public UILabel SetName;

	[Token(Token = "0x4013ECB")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton CloseBtn;

	[Token(Token = "0x4013ECC")]
	[FieldOffset(Offset = "0x20")]
	public UILabel FakeSetKey;

	[Token(Token = "0x4013ECD")]
	[FieldOffset(Offset = "0x24")]
	public UISprite SuitSprite;

	[Token(Token = "0x6015F4D")]
	[Address(RVA = "0x2FA5DD4", Offset = "0x2FA5DD4", VA = "0x2FA5DD4")]
	public UIAvatarSuitRecommendItemView()
	{
	}

	[Token(Token = "0x6015F4E")]
	[Address(RVA = "0x2FA5DDC", Offset = "0x2FA5DDC", VA = "0x2FA5DDC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015F4F")]
	[Address(RVA = "0x2FA6104", Offset = "0x2FA6104", VA = "0x2FA6104")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
