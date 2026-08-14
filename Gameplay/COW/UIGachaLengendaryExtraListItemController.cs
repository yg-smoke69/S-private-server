using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002650")]
public class UIGachaLengendaryExtraListItemController : UIBaseController
{
	[Token(Token = "0x400EC90")]
	[FieldOffset(Offset = "0x28")]
	private ExtraRewardDesc m_ItemDesc;

	[Token(Token = "0x400EC91")]
	[FieldOffset(Offset = "0x2C")]
	private int m_Indx;

	[Token(Token = "0x400EC92")]
	[FieldOffset(Offset = "0x30")]
	private uint m_GachaID;

	[Token(Token = "0x400EC93")]
	[FieldOffset(Offset = "0x34")]
	private RareRewardState m_RareRewardState;

	[Token(Token = "0x400EC94")]
	[FieldOffset(Offset = "0x38")]
	private BaseItemInfo m_BaseItemInfo;

	[Token(Token = "0x400EC95")]
	[FieldOffset(Offset = "0x3C")]
	private ExtraAwardItemState m_State;

	[Token(Token = "0x400EC96")]
	[FieldOffset(Offset = "0x40")]
	private UIGachaLengendaryExtraListItemView m_View;

	[Token(Token = "0x600E49B")]
	[Address(RVA = "0x2E714DC", Offset = "0x2E714DC", VA = "0x2E714DC")]
	public UIGachaLengendaryExtraListItemController()
	{
	}

	[Token(Token = "0x600E49C")]
	[Address(RVA = "0x2E71568", Offset = "0x2E71568", VA = "0x2E71568")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E49D")]
	[Address(RVA = "0x2E7160C", Offset = "0x2E7160C", VA = "0x2E7160C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E49E")]
	[Address(RVA = "0x2E717A0", Offset = "0x2E717A0", VA = "0x2E717A0")]
	public void SetViewData(ExtraRewardDesc data, int data_index, uint chestID, bool isLegendCloth = true)
	{
	}

	[Token(Token = "0x600E49F")]
	[Address(RVA = "0x2E71848", Offset = "0x2E71848", VA = "0x2E71848")]
	public void UpdateItemState()
	{
	}

	[Token(Token = "0x600E4A0")]
	[Address(RVA = "0x2E71A24", Offset = "0x2E71A24", VA = "0x2E71A24")]
	private void RefreshExtraAwardItemView(uint chestID)
	{
	}

	[Token(Token = "0x600E4A1")]
	[Address(RVA = "0x2E729D4", Offset = "0x2E729D4", VA = "0x2E729D4")]
	private void SetQualityBG(int Quality, UISprite QualityBG, UISprite prizeBg)
	{
	}

	[Token(Token = "0x600E4A2")]
	[Address(RVA = "0x2E72EF4", Offset = "0x2E72EF4", VA = "0x2E72EF4")]
	private void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600E4A3")]
	[Address(RVA = "0x2E734C0", Offset = "0x2E734C0", VA = "0x2E734C0")]
	private void ReOpenBtnClick()
	{
	}

	[Token(Token = "0x600E4A4")]
	[Address(RVA = "0x2E73550", Offset = "0x2E73550", VA = "0x2E73550")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
