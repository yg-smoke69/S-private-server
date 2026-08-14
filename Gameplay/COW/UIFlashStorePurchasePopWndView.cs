using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200353C")]
public class UIFlashStorePurchasePopWndView : UIBaseView
{
	[Token(Token = "0x40150EC")]
	[FieldOffset(Offset = "0x14")]
	public UILabel ItemNameLabel;

	[Token(Token = "0x40150ED")]
	[FieldOffset(Offset = "0x18")]
	public UILabel limitedPurchaseLabel;

	[Token(Token = "0x40150EE")]
	[FieldOffset(Offset = "0x1C")]
	public Transform ItemContainer;

	[Token(Token = "0x40150EF")]
	[FieldOffset(Offset = "0x20")]
	public UIButton PlusBtn;

	[Token(Token = "0x40150F0")]
	[FieldOffset(Offset = "0x24")]
	public UIInput CountInput;

	[Token(Token = "0x40150F1")]
	[FieldOffset(Offset = "0x28")]
	public UILabel CountLabel;

	[Token(Token = "0x40150F2")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton MinusBtn;

	[Token(Token = "0x40150F3")]
	[FieldOffset(Offset = "0x30")]
	public UIButton MaxBtn;

	[Token(Token = "0x40150F4")]
	[FieldOffset(Offset = "0x34")]
	public UILabel LabelMax;

	[Token(Token = "0x40150F5")]
	[FieldOffset(Offset = "0x38")]
	public UIButton AddTenBtn;

	[Token(Token = "0x40150F6")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject FlashGemsContentContainer;

	[Token(Token = "0x40150F7")]
	[FieldOffset(Offset = "0x40")]
	public GameObject FlashGemsOnlyContainer;

	[Token(Token = "0x40150F8")]
	[FieldOffset(Offset = "0x44")]
	public GameObject FlashGemsAndGemsNeedContainer;

	[Token(Token = "0x40150F9")]
	[FieldOffset(Offset = "0x48")]
	public UILabel FlashGemsOnlyConfirmLabel;

	[Token(Token = "0x40150FA")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton FlashGemsOnlyPurchaseBtn;

	[Token(Token = "0x40150FB")]
	[FieldOffset(Offset = "0x50")]
	public UILabel PeriodicGemsPrice;

	[Token(Token = "0x40150FC")]
	[FieldOffset(Offset = "0x54")]
	public GameObject ModifyNumContainer;

	[Token(Token = "0x40150FD")]
	[FieldOffset(Offset = "0x58")]
	public GameObject DualCurrencyCostContainer;

	[Token(Token = "0x40150FE")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject GemsCostContainer;

	[Token(Token = "0x40150FF")]
	[FieldOffset(Offset = "0x60")]
	public GameObject PeriodicGemsCostContainer;

	[Token(Token = "0x4015100")]
	[FieldOffset(Offset = "0x64")]
	public UILabel PeriodicGemsCostLabel;

	[Token(Token = "0x4015101")]
	[FieldOffset(Offset = "0x68")]
	public UILabel GemsCostLabel;

	[Token(Token = "0x4015102")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject PlusObj;

	[Token(Token = "0x4015103")]
	[FieldOffset(Offset = "0x70")]
	public UIButton FlashGemsAndGemsNeedPurchaseBtn;

	[Token(Token = "0x4015104")]
	[FieldOffset(Offset = "0x74")]
	public UILabel FlashGemsAndGemsNeedConfirmLabel;

	[Token(Token = "0x4015105")]
	[FieldOffset(Offset = "0x78")]
	public UILabel BuyBtnLabel;

	[Token(Token = "0x4015106")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject OriginalPriceIllustrateContainer;

	[Token(Token = "0x4015107")]
	[FieldOffset(Offset = "0x80")]
	public GameObject OriginalFlashGemsAngGemsContainer;

	[Token(Token = "0x4015108")]
	[FieldOffset(Offset = "0x84")]
	public GameObject OriginalFlashGemsOnlyContainer;

	[Token(Token = "0x4015109")]
	[FieldOffset(Offset = "0x88")]
	public UILabel OriginalFlashGemsLabel;

	[Token(Token = "0x401510A")]
	[FieldOffset(Offset = "0x8C")]
	public UILabel OriginalFlashGemsLabel2;

	[Token(Token = "0x401510B")]
	[FieldOffset(Offset = "0x90")]
	public UILabel OriginalGemsCostLabel;

	[Token(Token = "0x6016364")]
	[Address(RVA = "0x1B5D814", Offset = "0x1B5D814", VA = "0x1B5D814")]
	public UIFlashStorePurchasePopWndView()
	{
	}

	[Token(Token = "0x6016365")]
	[Address(RVA = "0x1B5D81C", Offset = "0x1B5D81C", VA = "0x1B5D81C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016366")]
	[Address(RVA = "0x1B5E4B8", Offset = "0x1B5E4B8", VA = "0x1B5E4B8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
