using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003612")]
public class UIHudCommonFullScreenTutorialView : UIBaseView
{
	[Token(Token = "0x4015A2C")]
	[FieldOffset(Offset = "0x14")]
	public UINetworkTexture CDN2;

	[Token(Token = "0x4015A2D")]
	[FieldOffset(Offset = "0x18")]
	public UINetworkTexture CDN3;

	[Token(Token = "0x4015A2E")]
	[FieldOffset(Offset = "0x1C")]
	public UINetworkTexture CDN1;

	[Token(Token = "0x4015A2F")]
	[FieldOffset(Offset = "0x20")]
	public UILabel Desc1;

	[Token(Token = "0x4015A30")]
	[FieldOffset(Offset = "0x24")]
	public UILabel Desc2;

	[Token(Token = "0x4015A31")]
	[FieldOffset(Offset = "0x28")]
	public UILabel Desc3;

	[Token(Token = "0x4015A32")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel Title1;

	[Token(Token = "0x4015A33")]
	[FieldOffset(Offset = "0x30")]
	public UILabel Title2;

	[Token(Token = "0x4015A34")]
	[FieldOffset(Offset = "0x34")]
	public UIButton MaskBtn;

	[Token(Token = "0x4015A35")]
	[FieldOffset(Offset = "0x38")]
	public UILabel Tips;

	[Token(Token = "0x60165E5")]
	[Address(RVA = "0x135ED94", Offset = "0x135ED94", VA = "0x135ED94")]
	public UIHudCommonFullScreenTutorialView()
	{
	}

	[Token(Token = "0x60165E6")]
	[Address(RVA = "0x135ED9C", Offset = "0x135ED9C", VA = "0x135ED9C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60165E7")]
	[Address(RVA = "0x135F2A4", Offset = "0x135F2A4", VA = "0x135F2A4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
