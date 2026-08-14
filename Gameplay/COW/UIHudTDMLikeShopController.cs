using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002868")]
internal class UIHudTDMLikeShopController : UIHudInGameShopBaseController
{
	[Token(Token = "0x400F92D")]
	[FieldOffset(Offset = "0x34")]
	private List<uint> m_ChoosedItemList;

	[Token(Token = "0x400F92E")]
	[FieldOffset(Offset = "0x38")]
	private Dictionary<uint, UIHudCSEquipCategoryController> m_CategroyMap;

	[Token(Token = "0x400F92F")]
	[FieldOffset(Offset = "0x3C")]
	private TDMLikeShopConfigDataManager shopManager;

	[Token(Token = "0x400F930")]
	[FieldOffset(Offset = "0x40")]
	private bool _003CPurchased_003Ek__BackingField;

	[Token(Token = "0x170011F6")]
	public bool Purchased
	{
		[Token(Token = "0x600FD1F")]
		[Address(RVA = "0x1FF6F40", Offset = "0x1FF6F40", VA = "0x1FF6F40")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600FD1E")]
		[Address(RVA = "0x1FF6F38", Offset = "0x1FF6F38", VA = "0x1FF6F38")]
		set
		{
		}
	}

	[Token(Token = "0x600FD1D")]
	[Address(RVA = "0x1FF6E78", Offset = "0x1FF6E78", VA = "0x1FF6E78")]
	public UIHudTDMLikeShopController()
	{
	}

	[Token(Token = "0x600FD20")]
	[Address(RVA = "0x1FF6F48", Offset = "0x1FF6F48", VA = "0x1FF6F48")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FD21")]
	[Address(RVA = "0x1FF6FF0", Offset = "0x1FF6FF0", VA = "0x1FF6FF0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FD22")]
	[Address(RVA = "0x1FF7710", Offset = "0x1FF7710", VA = "0x1FF7710", Slot = "31")]
	protected override void OnInitSpecialUIElement()
	{
	}

	[Token(Token = "0x600FD23")]
	[Address(RVA = "0x1FF782C", Offset = "0x1FF782C", VA = "0x1FF782C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600FD24")]
	[Address(RVA = "0x1FF7890", Offset = "0x1FF7890", VA = "0x1FF7890", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600FD25")]
	[Address(RVA = "0x1FF71BC", Offset = "0x1FF71BC", VA = "0x1FF71BC")]
	private void SetUIData()
	{
	}

	[Token(Token = "0x600FD26")]
	[Address(RVA = "0x1FF8004", Offset = "0x1FF8004", VA = "0x1FF8004", Slot = "34")]
	protected override void OnPurchaseBtnClick()
	{
	}

	[Token(Token = "0x600FD27")]
	[Address(RVA = "0x1FF8A68", Offset = "0x1FF8A68", VA = "0x1FF8A68", Slot = "37")]
	protected override void OnPurchaseTimeOut()
	{
	}

	[Token(Token = "0x600FD28")]
	[Address(RVA = "0x1FF8C58", Offset = "0x1FF8C58", VA = "0x1FF8C58", Slot = "36")]
	protected override void OnCloseBtnClick()
	{
	}

	[Token(Token = "0x600FD29")]
	[Address(RVA = "0x1FF79C8", Offset = "0x1FF79C8", VA = "0x1FF79C8")]
	private void ClearUIData()
	{
	}

	[Token(Token = "0x600FD2A")]
	[Address(RVA = "0x1FF9258", Offset = "0x1FF9258", VA = "0x1FF9258", Slot = "33")]
	protected override void OnItemSelected(object[] data)
	{
	}

	[Token(Token = "0x600FD2B")]
	[Address(RVA = "0x1FF7B98", Offset = "0x1FF7B98", VA = "0x1FF7B98")]
	private void RefreshPrices()
	{
	}

	[Token(Token = "0x600FD2C")]
	[Address(RVA = "0x1FF93A0", Offset = "0x1FF93A0", VA = "0x1FF93A0", Slot = "35")]
	protected override void OnBuySameBtnClick()
	{
	}

	[Token(Token = "0x600FD2D")]
	[Address(RVA = "0x1FF8918", Offset = "0x1FF8918", VA = "0x1FF8918")]
	public void UpdateBuySameButtonEnable(bool isEnable)
	{
	}

	[Token(Token = "0x600FD2E")]
	[Address(RVA = "0x1FF9190", Offset = "0x1FF9190", VA = "0x1FF9190")]
	private bool CanModeCloseShopTemparory()
	{
		return default(bool);
	}

	[Token(Token = "0x600FD2F")]
	[Address(RVA = "0x1FF94C0", Offset = "0x1FF94C0", VA = "0x1FF94C0")]
	private void OnHelpButtonClick()
	{
	}

	[Token(Token = "0x600FD30")]
	[Address(RVA = "0x1FF9644", Offset = "0x1FF9644", VA = "0x1FF9644")]
	private void OnPurchased(object[] data)
	{
	}

	[Token(Token = "0x600FD31")]
	[Address(RVA = "0x1FF96AC", Offset = "0x1FF96AC", VA = "0x1FF96AC")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FD32")]
	[Address(RVA = "0x1FF96B4", Offset = "0x1FF96B4", VA = "0x1FF96B4")]
	public void _003C_003EiFixBaseProxy_OnInitSpecialUIElement()
	{
	}

	[Token(Token = "0x600FD33")]
	[Address(RVA = "0x1FF96BC", Offset = "0x1FF96BC", VA = "0x1FF96BC")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600FD34")]
	[Address(RVA = "0x1FF96C4", Offset = "0x1FF96C4", VA = "0x1FF96C4")]
	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600FD35")]
	[Address(RVA = "0x1FF96CC", Offset = "0x1FF96CC", VA = "0x1FF96CC")]
	public void _003C_003EiFixBaseProxy_OnPurchaseBtnClick()
	{
	}

	[Token(Token = "0x600FD36")]
	[Address(RVA = "0x1FF96D4", Offset = "0x1FF96D4", VA = "0x1FF96D4")]
	public void _003C_003EiFixBaseProxy_OnPurchaseTimeOut()
	{
	}

	[Token(Token = "0x600FD37")]
	[Address(RVA = "0x1FF96DC", Offset = "0x1FF96DC", VA = "0x1FF96DC")]
	public void _003C_003EiFixBaseProxy_OnCloseBtnClick()
	{
	}

	[Token(Token = "0x600FD38")]
	[Address(RVA = "0x1FF96E4", Offset = "0x1FF96E4", VA = "0x1FF96E4")]
	public void _003C_003EiFixBaseProxy_OnItemSelected(object[] P0)
	{
	}

	[Token(Token = "0x600FD39")]
	[Address(RVA = "0x1FF96EC", Offset = "0x1FF96EC", VA = "0x1FF96EC")]
	public void _003C_003EiFixBaseProxy_OnBuySameBtnClick()
	{
	}
}
