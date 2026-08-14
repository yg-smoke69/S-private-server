using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002CA1")]
public class UIFrontEndPreviewBundleItemController : UIEasyListItemController
{
	[Token(Token = "0x4011093")]
	[FieldOffset(Offset = "0x38")]
	private UIFrontEndPreviewBundleItemView m_View;

	[Token(Token = "0x4011094")]
	[FieldOffset(Offset = "0x3C")]
	private CSSharedItemData m_itData;

	[Token(Token = "0x4011095")]
	[FieldOffset(Offset = "0x40")]
	private UIModelInventory m_ModelInventory;

	[Token(Token = "0x4011096")]
	[FieldOffset(Offset = "0x44")]
	private ShowBoostAvatarParams m_ShowBoostAvatarParmas;

	[Token(Token = "0x4011097")]
	[FieldOffset(Offset = "0x48")]
	private BaseItemInfo m_Data;

	[Token(Token = "0x4011098")]
	[FieldOffset(Offset = "0x4C")]
	private uint m_Index;

	[Token(Token = "0x4011099")]
	[FieldOffset(Offset = "0x50")]
	private UIStandardItemMini2Controller ctrl;

	[Token(Token = "0x401109A")]
	[FieldOffset(Offset = "0x54")]
	private bool m_IsItemABReady;

	[Token(Token = "0x401109B")]
	[FieldOffset(Offset = "0x55")]
	private bool m_RefreshPreview;

	[Token(Token = "0x401109C")]
	private const uint m_itemClothFemaleMin = 203000578u;

	[Token(Token = "0x401109D")]
	private const uint m_itemClothFemaleMax = 203999999u;

	[Token(Token = "0x401109E")]
	private const uint m_itemClothMaleMin = 211000343u;

	[Token(Token = "0x401109F")]
	private const uint m_itemClothMaleMax = 211999999u;

	[Token(Token = "0x40110A0")]
	private const string HIDDEN_PAGE_DESC_TITLE_KEY = "T_34_XY_HYPERBOOK_HIDDENTITLE";

	[Token(Token = "0x40110A1")]
	private const string HIDDEN_PAGE_DESC_CONTENT_KEY = "T_34_XY_HYPERBOOK_HIDDENDEC";

	[Token(Token = "0x40110A2")]
	[FieldOffset(Offset = "0x58")]
	private uint m_OriginalItemID;

	[Token(Token = "0x40110A3")]
	[FieldOffset(Offset = "0x5C")]
	private UISmallDetailTipsController m_CurrentTips;

	[Token(Token = "0x40110A4")]
	[FieldOffset(Offset = "0x60")]
	private FrontEndPreviewComponent m_FrontEndPreviewComponent;

	[Token(Token = "0x6012A6F")]
	[Address(RVA = "0x27DD8F4", Offset = "0x27DD8F4", VA = "0x27DD8F4")]
	public UIFrontEndPreviewBundleItemController()
	{
	}

	[Token(Token = "0x6012A70")]
	[Address(RVA = "0x27DD904", Offset = "0x27DD904", VA = "0x27DD904")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012A71")]
	[Address(RVA = "0x27DD9AC", Offset = "0x27DD9AC", VA = "0x27DD9AC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6012A72")]
	[Address(RVA = "0x27DDBE8", Offset = "0x27DDBE8", VA = "0x27DDBE8")]
	public void SetFrontEndPreviewComponent(FrontEndPreviewComponent frontEndPreviewComponent)
	{
	}

	[Token(Token = "0x6012A73")]
	[Address(RVA = "0x27DDC48", Offset = "0x27DDC48", VA = "0x27DDC48")]
	public void SetRefreshPreviewState(bool flag)
	{
	}

	[Token(Token = "0x6012A74")]
	[Address(RVA = "0x27DDCA8", Offset = "0x27DDCA8", VA = "0x27DDCA8", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x6012A75")]
	[Address(RVA = "0x27DF250", Offset = "0x27DF250", VA = "0x27DF250")]
	private void SetTreasureBoxProbabilityState()
	{
	}

	[Token(Token = "0x6012A76")]
	[Address(RVA = "0x27DEF58", Offset = "0x27DEF58", VA = "0x27DEF58")]
	private void SetTreasureBoxProbabilityStateOnUnSelect()
	{
	}

	[Token(Token = "0x6012A77")]
	[Address(RVA = "0x27DF1B0", Offset = "0x27DF1B0", VA = "0x27DF1B0")]
	public bool CheckIDInvaild(uint itemid)
	{
		return default(bool);
	}

	[Token(Token = "0x6012A78")]
	[Address(RVA = "0x27DF49C", Offset = "0x27DF49C", VA = "0x27DF49C", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x6012A79")]
	[Address(RVA = "0x27DF530", Offset = "0x27DF530", VA = "0x27DF530")]
	public void RefreshData()
	{
	}

	[Token(Token = "0x6012A7A")]
	[Address(RVA = "0x27E004C", Offset = "0x27E004C", VA = "0x27E004C")]
	public void SetOriginalItemID(uint id)
	{
	}

	[Token(Token = "0x6012A7B")]
	[Address(RVA = "0x27E00AC", Offset = "0x27E00AC", VA = "0x27E00AC", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x6012A7C")]
	[Address(RVA = "0x27DFC84", Offset = "0x27DFC84", VA = "0x27DFC84")]
	private void CheckItemABReady(uint itemID)
	{
	}

	[Token(Token = "0x6012A7D")]
	[Address(RVA = "0x27DFDD4", Offset = "0x27DFDD4", VA = "0x27DFDD4")]
	private bool CheckIsHyperBookHiddenPageItem(uint originalID, uint itemID)
	{
		return default(bool);
	}

	[Token(Token = "0x6012A7E")]
	[Address(RVA = "0x27E01FC", Offset = "0x27E01FC", VA = "0x27E01FC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6012A7F")]
	[Address(RVA = "0x27E0204", Offset = "0x27E0204", VA = "0x27E0204")]
	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	[Token(Token = "0x6012A80")]
	[Address(RVA = "0x27E020C", Offset = "0x27E020C", VA = "0x27E020C")]
	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
