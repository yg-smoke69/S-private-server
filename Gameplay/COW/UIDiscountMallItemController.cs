using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20021AF")]
public class UIDiscountMallItemController : UIMallItemBaseController
{
	[Token(Token = "0x20021B0")]
	private enum DiscountLevel
	{
		[Token(Token = "0x400D2F8")]
		Free,
		[Token(Token = "0x400D2F9")]
		NormalDiscount,
		[Token(Token = "0x400D2FA")]
		SuperDiscount,
		[Token(Token = "0x400D2FB")]
		SuperfineDiscount
	}

	[Token(Token = "0x400D2F4")]
	[FieldOffset(Offset = "0x12C")]
	private UIStandardItemMAXBView m_View;

	[Token(Token = "0x400D2F5")]
	[FieldOffset(Offset = "0x130")]
	private DiscountStoreDesc m_DiscountItem;

	[Token(Token = "0x400D2F6")]
	[FieldOffset(Offset = "0x134")]
	private DiscountLevel m_DiscountLevel;

	[Token(Token = "0x600B350")]
	[Address(RVA = "0x275B5A8", Offset = "0x275B5A8", VA = "0x275B5A8")]
	public UIDiscountMallItemController()
	{
	}

	[Token(Token = "0x600B351")]
	[Address(RVA = "0x275B5B0", Offset = "0x275B5B0", VA = "0x275B5B0", Slot = "30")]
	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B352")]
	[Address(RVA = "0x275B60C", Offset = "0x275B60C", VA = "0x275B60C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B353")]
	[Address(RVA = "0x275B6B0", Offset = "0x275B6B0", VA = "0x275B6B0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B354")]
	[Address(RVA = "0x275B94C", Offset = "0x275B94C", VA = "0x275B94C", Slot = "42")]
	protected override void RefreshItemView()
	{
	}

	[Token(Token = "0x600B355")]
	[Address(RVA = "0x275BE9C", Offset = "0x275BE9C", VA = "0x275BE9C")]
	private void RefreshItemViewByCanEquip(bool canEquip)
	{
	}

	[Token(Token = "0x600B356")]
	[Address(RVA = "0x275C070", Offset = "0x275C070", VA = "0x275C070", Slot = "47")]
	public override void RefreshItemBGState()
	{
	}

	[Token(Token = "0x600B357")]
	[Address(RVA = "0x275C14C", Offset = "0x275C14C", VA = "0x275C14C")]
	private void RefreshUnFreeItemView()
	{
	}

	[Token(Token = "0x600B358")]
	[Address(RVA = "0x275C9B4", Offset = "0x275C9B4", VA = "0x275C9B4", Slot = "43")]
	protected override void ResetState()
	{
	}

	[Token(Token = "0x600B359")]
	[Address(RVA = "0x275CCD4", Offset = "0x275CCD4", VA = "0x275CCD4", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600B35A")]
	[Address(RVA = "0x275CE38", Offset = "0x275CE38", VA = "0x275CE38", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x600B35B")]
	[Address(RVA = "0x275B884", Offset = "0x275B884", VA = "0x275B884")]
	private void InitCommonWidget()
	{
	}

	[Token(Token = "0x600B35C")]
	[Address(RVA = "0x275BC78", Offset = "0x275BC78", VA = "0x275BC78")]
	private void SetDiscountLevel()
	{
	}

	[Token(Token = "0x600B35D")]
	[Address(RVA = "0x275BD7C", Offset = "0x275BD7C", VA = "0x275BD7C")]
	private void RefreshItemViewByDiscountLevel()
	{
	}

	[Token(Token = "0x600B35E")]
	[Address(RVA = "0x275CE9C", Offset = "0x275CE9C", VA = "0x275CE9C")]
	private void RefreshFreeItemView()
	{
	}

	[Token(Token = "0x600B35F")]
	[Address(RVA = "0x275CFA8", Offset = "0x275CFA8", VA = "0x275CFA8", Slot = "37")]
	protected override void SendItemClickEvent()
	{
	}

	[Token(Token = "0x600B360")]
	[Address(RVA = "0x275D1F8", Offset = "0x275D1F8", VA = "0x275D1F8", Slot = "38")]
	protected override void SendClothClickEvent()
	{
	}

	[Token(Token = "0x600B361")]
	[Address(RVA = "0x275D448", Offset = "0x275D448", VA = "0x275D448", Slot = "48")]
	protected override void OnStartToggleMove()
	{
	}

	[Token(Token = "0x600B362")]
	[Address(RVA = "0x275D53C", Offset = "0x275D53C", VA = "0x275D53C", Slot = "49")]
	protected override void OnFinishToggleMove()
	{
	}

	[Token(Token = "0x600B363")]
	[Address(RVA = "0x275D650", Offset = "0x275D650", VA = "0x275D650")]
	public void HideEffect()
	{
	}

	[Token(Token = "0x600B364")]
	[Address(RVA = "0x275D700", Offset = "0x275D700", VA = "0x275D700")]
	public ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B365")]
	[Address(RVA = "0x275D708", Offset = "0x275D708", VA = "0x275D708")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B366")]
	[Address(RVA = "0x275D710", Offset = "0x275D710", VA = "0x275D710")]
	public void _003C_003EiFixBaseProxy_RefreshItemView()
	{
	}

	[Token(Token = "0x600B367")]
	[Address(RVA = "0x275D718", Offset = "0x275D718", VA = "0x275D718")]
	public void _003C_003EiFixBaseProxy_RefreshItemBGState()
	{
	}

	[Token(Token = "0x600B368")]
	[Address(RVA = "0x275D720", Offset = "0x275D720", VA = "0x275D720")]
	public void _003C_003EiFixBaseProxy_ResetState()
	{
	}

	[Token(Token = "0x600B369")]
	[Address(RVA = "0x275D728", Offset = "0x275D728", VA = "0x275D728")]
	public void _003C_003EiFixBaseProxy_SetViewData(object P0, int P1)
	{
	}

	[Token(Token = "0x600B36A")]
	[Address(RVA = "0x275D730", Offset = "0x275D730", VA = "0x275D730")]
	public new void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x600B36B")]
	[Address(RVA = "0x275D738", Offset = "0x275D738", VA = "0x275D738")]
	public void _003C_003EiFixBaseProxy_SendItemClickEvent()
	{
	}

	[Token(Token = "0x600B36C")]
	[Address(RVA = "0x275D740", Offset = "0x275D740", VA = "0x275D740")]
	public void _003C_003EiFixBaseProxy_SendClothClickEvent()
	{
	}

	[Token(Token = "0x600B36D")]
	[Address(RVA = "0x275D748", Offset = "0x275D748", VA = "0x275D748")]
	public void _003C_003EiFixBaseProxy_OnStartToggleMove()
	{
	}

	[Token(Token = "0x600B36E")]
	[Address(RVA = "0x275D750", Offset = "0x275D750", VA = "0x275D750")]
	public void _003C_003EiFixBaseProxy_OnFinishToggleMove()
	{
	}
}
