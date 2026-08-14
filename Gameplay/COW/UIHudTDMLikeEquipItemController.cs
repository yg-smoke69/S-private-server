using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002867")]
internal class UIHudTDMLikeEquipItemController : UIBaseController
{
	[Token(Token = "0x400F927")]
	[FieldOffset(Offset = "0x28")]
	private UIHudInGameShopItemViewExt m_View;

	[Token(Token = "0x400F928")]
	[FieldOffset(Offset = "0x2C")]
	private TDMLikeShopConfigData m_Data;

	[Token(Token = "0x400F929")]
	[FieldOffset(Offset = "0x30")]
	private bool m_Selected;

	[Token(Token = "0x400F92A")]
	[FieldOffset(Offset = "0x34")]
	private uint m_Price;

	[Token(Token = "0x400F92B")]
	[FieldOffset(Offset = "0x38")]
	private uint m_LimitCnt;

	[Token(Token = "0x400F92C")]
	[FieldOffset(Offset = "0x3C")]
	private uint m_PurchaseCnt;

	[Token(Token = "0x600FD0A")]
	[Address(RVA = "0x1FF51E0", Offset = "0x1FF51E0", VA = "0x1FF51E0")]
	public UIHudTDMLikeEquipItemController()
	{
	}

	[Token(Token = "0x600FD0B")]
	[Address(RVA = "0x1FF5264", Offset = "0x1FF5264", VA = "0x1FF5264")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FD0C")]
	[Address(RVA = "0x1FF530C", Offset = "0x1FF530C", VA = "0x1FF530C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FD0D")]
	[Address(RVA = "0x1FF572C", Offset = "0x1FF572C", VA = "0x1FF572C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600FD0E")]
	[Address(RVA = "0x1FF5A68", Offset = "0x1FF5A68", VA = "0x1FF5A68")]
	private void Update()
	{
	}

	[Token(Token = "0x600FD0F")]
	[Address(RVA = "0x1FF5AD4", Offset = "0x1FF5AD4", VA = "0x1FF5AD4")]
	private void OnItemBtnClick()
	{
	}

	[Token(Token = "0x600FD10")]
	[Address(RVA = "0x1FF5D38", Offset = "0x1FF5D38", VA = "0x1FF5D38")]
	public void SetUIData(TDMLikeShopConfigData data)
	{
	}

	[Token(Token = "0x600FD11")]
	[Address(RVA = "0x1FF6738", Offset = "0x1FF6738", VA = "0x1FF6738")]
	private void RefreshPrice(object[] data)
	{
	}

	[Token(Token = "0x600FD12")]
	[Address(RVA = "0x1FF63FC", Offset = "0x1FF63FC", VA = "0x1FF63FC")]
	private void CheckLimitation()
	{
	}

	[Token(Token = "0x600FD13")]
	[Address(RVA = "0x1FF6854", Offset = "0x1FF6854", VA = "0x1FF6854")]
	private uint GetLimitCount()
	{
		return default(uint);
	}

	[Token(Token = "0x600FD14")]
	[Address(RVA = "0x1FF68D0", Offset = "0x1FF68D0", VA = "0x1FF68D0")]
	private void OnItemPurchased(object[] data)
	{
	}

	[Token(Token = "0x600FD15")]
	[Address(RVA = "0x1FF6218", Offset = "0x1FF6218", VA = "0x1FF6218")]
	private void CheckPriceValid()
	{
	}

	[Token(Token = "0x600FD16")]
	[Address(RVA = "0x1FF63A8", Offset = "0x1FF63A8", VA = "0x1FF63A8")]
	private void CheckItemsValid()
	{
	}

	[Token(Token = "0x600FD17")]
	[Address(RVA = "0x1FF6A98", Offset = "0x1FF6A98", VA = "0x1FF6A98")]
	private void OnItemSelected(object[] data)
	{
	}

	[Token(Token = "0x600FD18")]
	[Address(RVA = "0x1FF5C9C", Offset = "0x1FF5C9C", VA = "0x1FF5C9C")]
	private void SetSelected(bool v)
	{
	}

	[Token(Token = "0x600FD19")]
	[Address(RVA = "0x1FF6BB8", Offset = "0x1FF6BB8", VA = "0x1FF6BB8")]
	private void OnCoinChanged(object[] data)
	{
	}

	[Token(Token = "0x600FD1A")]
	[Address(RVA = "0x1FF6C28", Offset = "0x1FF6C28", VA = "0x1FF6C28")]
	private void OnPurchaseSuccess(object[] data)
	{
	}

	[Token(Token = "0x600FD1B")]
	[Address(RVA = "0x1FF6E68", Offset = "0x1FF6E68", VA = "0x1FF6E68")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FD1C")]
	[Address(RVA = "0x1FF6E70", Offset = "0x1FF6E70", VA = "0x1FF6E70")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
