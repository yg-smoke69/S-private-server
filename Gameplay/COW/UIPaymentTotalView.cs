using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038FB")]
public class UIPaymentTotalView : UIBaseView
{
	[Token(Token = "0x4017AE6")]
	[FieldOffset(Offset = "0x14")]
	public UIButton GotoButton;

	[Token(Token = "0x4017AE7")]
	[FieldOffset(Offset = "0x18")]
	public UILabel TopUpInTotalLabel;

	[Token(Token = "0x4017AE8")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel TopUpInTotalLabel_1;

	[Token(Token = "0x4017AE9")]
	[FieldOffset(Offset = "0x20")]
	public UILabel TopUpInTotalLabel_2;

	[Token(Token = "0x4017AEA")]
	[FieldOffset(Offset = "0x24")]
	public GameObject ProgressBarContainer;

	[Token(Token = "0x4017AEB")]
	[FieldOffset(Offset = "0x28")]
	public UILabel ProgressDetailLabel_1;

	[Token(Token = "0x4017AEC")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite ProgressDetailSprite_1;

	[Token(Token = "0x4017AED")]
	[FieldOffset(Offset = "0x30")]
	public UILabel ProgressDetailLabel_2;

	[Token(Token = "0x4017AEE")]
	[FieldOffset(Offset = "0x34")]
	public UISprite ProgressDetailSprite_2;

	[Token(Token = "0x4017AEF")]
	[FieldOffset(Offset = "0x38")]
	public UILabel ProgressDetailLabel_3;

	[Token(Token = "0x4017AF0")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite ProgressDetailSprite_3;

	[Token(Token = "0x4017AF1")]
	[FieldOffset(Offset = "0x40")]
	public UIWidget ProgressBarLeft;

	[Token(Token = "0x4017AF2")]
	[FieldOffset(Offset = "0x44")]
	public UIWidget ProgressBarRight;

	[Token(Token = "0x4017AF3")]
	[FieldOffset(Offset = "0x48")]
	public UITexture ProgressCursor;

	[Token(Token = "0x4017AF4")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite ProgressBarSprite;

	[Token(Token = "0x4017AF5")]
	[FieldOffset(Offset = "0x50")]
	public UIGrid ItemsGrid;

	[Token(Token = "0x4017AF6")]
	[FieldOffset(Offset = "0x54")]
	public UINetworkTextureExt CDNTexture;

	[Token(Token = "0x4017AF7")]
	[FieldOffset(Offset = "0x58")]
	public GameObject CDNFX;

	[Token(Token = "0x6016E9A")]
	[Address(RVA = "0x23DECE4", Offset = "0x23DECE4", VA = "0x23DECE4")]
	public UIPaymentTotalView()
	{
	}

	[Token(Token = "0x6016E9B")]
	[Address(RVA = "0x23DECEC", Offset = "0x23DECEC", VA = "0x23DECEC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016E9C")]
	[Address(RVA = "0x23DF4DC", Offset = "0x23DF4DC", VA = "0x23DF4DC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
