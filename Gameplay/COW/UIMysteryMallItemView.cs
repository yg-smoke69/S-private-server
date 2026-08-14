using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038BA")]
public class UIMysteryMallItemView : UIBaseView
{
	[Token(Token = "0x4017784")]
	[FieldOffset(Offset = "0x14")]
	public GameObject PriceContainer;

	[Token(Token = "0x4017785")]
	[FieldOffset(Offset = "0x18")]
	public UILabel LabelOriginPrice;

	[Token(Token = "0x4017786")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LabelDiscountPrice;

	[Token(Token = "0x4017787")]
	[FieldOffset(Offset = "0x20")]
	public UILabel LabelLimit;

	[Token(Token = "0x4017788")]
	[FieldOffset(Offset = "0x24")]
	public UIButton ItemBtn;

	[Token(Token = "0x4017789")]
	[FieldOffset(Offset = "0x28")]
	public UIWidget ItemWidget;

	[Token(Token = "0x401778A")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject NewLabel;

	[Token(Token = "0x401778B")]
	[FieldOffset(Offset = "0x30")]
	public GameObject LimitedLabel;

	[Token(Token = "0x401778C")]
	[FieldOffset(Offset = "0x34")]
	public GameObject LimitedPurchaseLabel;

	[Token(Token = "0x401778D")]
	[FieldOffset(Offset = "0x38")]
	public GameObject HotLabel;

	[Token(Token = "0x401778E")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject EarlyBirdLabel;

	[Token(Token = "0x401778F")]
	[FieldOffset(Offset = "0x40")]
	public GameObject BaseItemView;

	[Token(Token = "0x4017790")]
	[FieldOffset(Offset = "0x44")]
	public BaseItemView BaseInfoView;

	[Token(Token = "0x4017791")]
	[FieldOffset(Offset = "0x48")]
	public UISprite VoucherIcon;

	[Token(Token = "0x4017792")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject LockedTitle;

	[Token(Token = "0x4017793")]
	[FieldOffset(Offset = "0x50")]
	public GameObject Owned;

	[Token(Token = "0x4017794")]
	[FieldOffset(Offset = "0x54")]
	public GameObject ClaimedTitle;

	[Token(Token = "0x4017795")]
	[FieldOffset(Offset = "0x58")]
	public GameObject LimitedTitle;

	[Token(Token = "0x4017796")]
	[FieldOffset(Offset = "0x5C")]
	public UISprite IPTag;

	[Token(Token = "0x4017797")]
	[FieldOffset(Offset = "0x60")]
	public UILabel LabelItemName;

	[Token(Token = "0x4017798")]
	[FieldOffset(Offset = "0x64")]
	public UIButton BtnPurchase;

	[Token(Token = "0x4017799")]
	[FieldOffset(Offset = "0x68")]
	public UISprite Purchased;

	[Token(Token = "0x401779A")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject Purchasable;

	[Token(Token = "0x401779B")]
	[FieldOffset(Offset = "0x70")]
	public UINetworkTextureExt CdnItem;

	[Token(Token = "0x401779C")]
	[FieldOffset(Offset = "0x74")]
	public MeshRenderer VFXDiscout;

	[Token(Token = "0x401779D")]
	[FieldOffset(Offset = "0x78")]
	public UISprite ItemNameQualityBg;

	[Token(Token = "0x401779E")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject LabelOwned;

	[Token(Token = "0x6016DD9")]
	[Address(RVA = "0x1B27040", Offset = "0x1B27040", VA = "0x1B27040")]
	public UIMysteryMallItemView()
	{
	}

	[Token(Token = "0x6016DDA")]
	[Address(RVA = "0x1B27048", Offset = "0x1B27048", VA = "0x1B27048", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016DDB")]
	[Address(RVA = "0x1B27B14", Offset = "0x1B27B14", VA = "0x1B27B14")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
