using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x200210E")]
public class UIGachaLengendaryExtraListBooyahDayItemController : UIBaseController
{
	[Token(Token = "0x400CEF6")]
	[FieldOffset(Offset = "0x28")]
	private ExtraRewardDesc m_ItemDesc;

	[Token(Token = "0x400CEF7")]
	[FieldOffset(Offset = "0x2C")]
	private int m_Indx;

	[Token(Token = "0x400CEF8")]
	[FieldOffset(Offset = "0x30")]
	private uint m_GachaID;

	[Token(Token = "0x400CEF9")]
	[FieldOffset(Offset = "0x34")]
	private uint m_ItemDelayCall;

	[Token(Token = "0x400CEFA")]
	[FieldOffset(Offset = "0x38")]
	private RareRewardState m_RareRewardState;

	[Token(Token = "0x400CEFB")]
	[FieldOffset(Offset = "0x3C")]
	private BaseItemInfo m_BaseItemInfo;

	[Token(Token = "0x400CEFC")]
	[FieldOffset(Offset = "0x40")]
	private ExtraAwardItemState m_State;

	[Token(Token = "0x400CEFD")]
	[FieldOffset(Offset = "0x44")]
	private UIGachaLengendaryExtraListBooyahDayItemView m_View;

	[Token(Token = "0x600AC77")]
	[Address(RVA = "0x2E6F084", Offset = "0x2E6F084", VA = "0x2E6F084")]
	public UIGachaLengendaryExtraListBooyahDayItemController()
	{
	}

	[Token(Token = "0x600AC78")]
	[Address(RVA = "0x2E6F110", Offset = "0x2E6F110", VA = "0x2E6F110")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600AC79")]
	[Address(RVA = "0x2E6F1B4", Offset = "0x2E6F1B4", VA = "0x2E6F1B4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600AC7A")]
	[Address(RVA = "0x2E6F310", Offset = "0x2E6F310", VA = "0x2E6F310", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600AC7B")]
	[Address(RVA = "0x2E6F418", Offset = "0x2E6F418", VA = "0x2E6F418")]
	public void SetViewData(ExtraRewardDesc data, int data_index, uint chestID)
	{
	}

	[Token(Token = "0x600AC7C")]
	[Address(RVA = "0x2E6F4BC", Offset = "0x2E6F4BC", VA = "0x2E6F4BC")]
	public void UpdateItemState()
	{
	}

	[Token(Token = "0x600AC7D")]
	[Address(RVA = "0x2E6F698", Offset = "0x2E6F698", VA = "0x2E6F698")]
	private void RefreshExtraAwardItemView(uint chestID)
	{
	}

	[Token(Token = "0x600AC7E")]
	[Address(RVA = "0x2E701D4", Offset = "0x2E701D4", VA = "0x2E701D4")]
	private void SetQualityBG(int Quality, UISprite QualityBG, string insert)
	{
	}

	[Token(Token = "0x600AC7F")]
	[Address(RVA = "0x2E70664", Offset = "0x2E70664", VA = "0x2E70664")]
	private void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600AC80")]
	[Address(RVA = "0x2E70C70", Offset = "0x2E70C70", VA = "0x2E70C70")]
	private void ReOpenBtnClick()
	{
	}

	[Token(Token = "0x600AC81")]
	[Address(RVA = "0x2E70D08", Offset = "0x2E70D08", VA = "0x2E70D08")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600AC82")]
	[Address(RVA = "0x2E70D10", Offset = "0x2E70D10", VA = "0x2E70D10")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
