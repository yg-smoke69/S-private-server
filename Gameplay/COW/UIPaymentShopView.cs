using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038F0")]
public class UIPaymentShopView : UIBaseView
{
	[Token(Token = "0x4017A70")]
	[FieldOffset(Offset = "0x14")]
	public GameObject UIPaymentShop;

	[Token(Token = "0x4017A71")]
	[FieldOffset(Offset = "0x18")]
	public GameObject AdImage;

	[Token(Token = "0x4017A72")]
	[FieldOffset(Offset = "0x1C")]
	public UINetworkTextureExt MainAdNetworkTexture;

	[Token(Token = "0x4017A73")]
	[FieldOffset(Offset = "0x20")]
	public UIButton NetworkImageBtn;

	[Token(Token = "0x4017A74")]
	[FieldOffset(Offset = "0x24")]
	public UIButton Button;

	[Token(Token = "0x4017A75")]
	[FieldOffset(Offset = "0x28")]
	public UILabel ButtonLabel;

	[Token(Token = "0x4017A76")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject BtnOperateBgYellow;

	[Token(Token = "0x4017A77")]
	[FieldOffset(Offset = "0x30")]
	public UIWidget WebViewRect;

	[Token(Token = "0x6016E79")]
	[Address(RVA = "0x29DE14C", Offset = "0x29DE14C", VA = "0x29DE14C")]
	public UIPaymentShopView()
	{
	}

	[Token(Token = "0x6016E7A")]
	[Address(RVA = "0x29DE154", Offset = "0x29DE154", VA = "0x29DE154", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016E7B")]
	[Address(RVA = "0x29DE578", Offset = "0x29DE578", VA = "0x29DE578")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
