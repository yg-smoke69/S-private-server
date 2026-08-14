using GCommon;
using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x2002041")]
internal class UIHudCSEquipItemController : UIBaseController
{
	[Token(Token = "0x400CA38")]
	[FieldOffset(Offset = "0x28")]
	protected UIHudInGameShopItemViewExt m_View;

	[Token(Token = "0x400CA39")]
	[FieldOffset(Offset = "0x2C")]
	protected CSShopItemData m_Data;

	[Token(Token = "0x400CA3A")]
	[FieldOffset(Offset = "0x30")]
	protected bool m_Selected;

	[Token(Token = "0x400CA3B")]
	[FieldOffset(Offset = "0x34")]
	private uint m_PurchaseCnt;

	[Token(Token = "0x400CA3C")]
	[FieldOffset(Offset = "0x38")]
	private uint m_LimitCnt;

	[Token(Token = "0x400CA3D")]
	[FieldOffset(Offset = "0x3C")]
	protected uint m_Quality;

	[Token(Token = "0x400CA3E")]
	[FieldOffset(Offset = "0x40")]
	private uint m_Price;

	[Token(Token = "0x600A3CB")]
	[Address(RVA = "0x1F02C50", Offset = "0x1F02C50", VA = "0x1F02C50")]
	public UIHudCSEquipItemController()
	{
	}

	[Token(Token = "0x600A3CC")]
	[Address(RVA = "0x1F02CD4", Offset = "0x1F02CD4", VA = "0x1F02CD4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A3CD")]
	[Address(RVA = "0x1F02D7C", Offset = "0x1F02D7C", VA = "0x1F02D7C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A3CE")]
	[Address(RVA = "0x1F032D4", Offset = "0x1F032D4", VA = "0x1F032D4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A3CF")]
	[Address(RVA = "0x1F03748", Offset = "0x1F03748", VA = "0x1F03748")]
	private void Update()
	{
	}

	[Token(Token = "0x600A3D0")]
	[Address(RVA = "0x1F037B4", Offset = "0x1F037B4", VA = "0x1F037B4")]
	private void OnItemBtnClick()
	{
	}

	[Token(Token = "0x600A3D1")]
	[Address(RVA = "0x1F03AD0", Offset = "0x1F03AD0", VA = "0x1F03AD0")]
	public UIButton GetTutorialBindingBtn()
	{
		return null;
	}

	[Token(Token = "0x600A3D2")]
	[Address(RVA = "0x1F03BA0", Offset = "0x1F03BA0", VA = "0x1F03BA0")]
	public UIWidget GetTutorialBindingWidget()
	{
		return null;
	}

	[Token(Token = "0x600A3D3")]
	[Address(RVA = "0x1F00914", Offset = "0x1F00914", VA = "0x1F00914")]
	public void SetUIData(CSShopItemData data, uint quality = 0u, bool isPurchaseRefresh = false)
	{
	}

	[Token(Token = "0x600A3D4")]
	[Address(RVA = "0x1F02798", Offset = "0x1F02798", VA = "0x1F02798")]
	public UIToggleButton GetToggleButton()
	{
		return null;
	}

	[Token(Token = "0x600A3D5")]
	[Address(RVA = "0x1F04598", Offset = "0x1F04598", VA = "0x1F04598")]
	private void RefreshPrice(object[] data)
	{
	}

	[Token(Token = "0x600A3D6")]
	[Address(RVA = "0x1F03F40", Offset = "0x1F03F40", VA = "0x1F03F40")]
	private void CheckItemsValid()
	{
	}

	[Token(Token = "0x600A3D7")]
	[Address(RVA = "0x1F04200", Offset = "0x1F04200", VA = "0x1F04200")]
	private void CheckLimitation()
	{
	}

	[Token(Token = "0x600A3D8")]
	[Address(RVA = "0x1F03C70", Offset = "0x1F03C70", VA = "0x1F03C70")]
	private uint GetLimitCount()
	{
		return default(uint);
	}

	[Token(Token = "0x600A3D9")]
	[Address(RVA = "0x1F046C8", Offset = "0x1F046C8", VA = "0x1F046C8")]
	private void OnItemPurchased(object[] data)
	{
	}

	[Token(Token = "0x600A3DA")]
	[Address(RVA = "0x1F03CEC", Offset = "0x1F03CEC", VA = "0x1F03CEC")]
	private bool CheckPriceValid()
	{
		return default(bool);
	}

	[Token(Token = "0x600A3DB")]
	[Address(RVA = "0x1F04890", Offset = "0x1F04890", VA = "0x1F04890")]
	private void OnItemSelected(object[] data)
	{
	}

	[Token(Token = "0x600A3DC")]
	[Address(RVA = "0x1F039F0", Offset = "0x1F039F0", VA = "0x1F039F0")]
	private void SetSelected(bool v)
	{
	}

	[Token(Token = "0x600A3DD")]
	[Address(RVA = "0x1F049F8", Offset = "0x1F049F8", VA = "0x1F049F8")]
	private void OnCoinChanged(object[] data)
	{
	}

	[Token(Token = "0x600A3DE")]
	[Address(RVA = "0x1F04A68", Offset = "0x1F04A68", VA = "0x1F04A68")]
	private void OnShow(object[] data)
	{
	}

	[Token(Token = "0x600A3DF")]
	[Address(RVA = "0x1F04AD0", Offset = "0x1F04AD0", VA = "0x1F04AD0")]
	private void RefreshLimitation(object[] data)
	{
	}

	[Token(Token = "0x600A3E0")]
	[Address(RVA = "0x1F04C60", Offset = "0x1F04C60", VA = "0x1F04C60")]
	private void OnFreeCardCountChanged(object[] data)
	{
	}

	[Token(Token = "0x600A3E1")]
	[Address(RVA = "0x1F04DE8", Offset = "0x1F04DE8", VA = "0x1F04DE8")]
	public void ShowTutorial(TutorialEventEnum eTutorialEvent)
	{
	}

	[Token(Token = "0x600A3E2")]
	[Address(RVA = "0x1F04F70", Offset = "0x1F04F70", VA = "0x1F04F70")]
	private void OnODFactionChange(object[] data)
	{
	}

	[Token(Token = "0x600A3E3")]
	[Address(RVA = "0x1F04FD8", Offset = "0x1F04FD8", VA = "0x1F04FD8")]
	private void OnItemAccountChanged(object[] data)
	{
	}

	[Token(Token = "0x600A3E4")]
	[Address(RVA = "0x1F050D0", Offset = "0x1F050D0", VA = "0x1F050D0")]
	private bool _003CRefreshLimitation_003Em__0(CHEEGFNLIOE i)
	{
		return default(bool);
	}

	[Token(Token = "0x600A3E5")]
	[Address(RVA = "0x1F0511C", Offset = "0x1F0511C", VA = "0x1F0511C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A3E6")]
	[Address(RVA = "0x1F05124", Offset = "0x1F05124", VA = "0x1F05124")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
