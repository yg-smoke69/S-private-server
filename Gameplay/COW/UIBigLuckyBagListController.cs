using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20024F8")]
public class UIBigLuckyBagListController : UIEasyListItemController
{
	[Token(Token = "0x400E584")]
	[FieldOffset(Offset = "0x38")]
	private UIBigLuckyBagListView m_View;

	[Token(Token = "0x400E585")]
	[FieldOffset(Offset = "0x3C")]
	private ClanLuckyBagInfoDesc m_data;

	[Token(Token = "0x400E586")]
	[FieldOffset(Offset = "0x40")]
	private List<UIStandardItemMiniController> m_ItemMiniList;

	[Token(Token = "0x400E587")]
	[FieldOffset(Offset = "0x44")]
	private UIModelClan m_ModelClan;

	[Token(Token = "0x600D5AF")]
	[Address(RVA = "0x10C1E28", Offset = "0x10C1E28", VA = "0x10C1E28")]
	public UIBigLuckyBagListController()
	{
	}

	[Token(Token = "0x600D5B0")]
	[Address(RVA = "0x10C1EB4", Offset = "0x10C1EB4", VA = "0x10C1EB4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D5B1")]
	[Address(RVA = "0x10C1F5C", Offset = "0x10C1F5C", VA = "0x10C1F5C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D5B2")]
	[Address(RVA = "0x10C2088", Offset = "0x10C2088", VA = "0x10C2088", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600D5B3")]
	[Address(RVA = "0x10C21D8", Offset = "0x10C21D8", VA = "0x10C21D8")]
	private void RefreshView(int index)
	{
	}

	[Token(Token = "0x600D5B4")]
	[Address(RVA = "0x10C225C", Offset = "0x10C225C", VA = "0x10C225C")]
	private void RefreshMessage(int index)
	{
	}

	[Token(Token = "0x600D5B5")]
	[Address(RVA = "0x10C2454", Offset = "0x10C2454", VA = "0x10C2454")]
	private void ResetItem(int index)
	{
	}

	[Token(Token = "0x600D5B6")]
	[Address(RVA = "0x10C2A2C", Offset = "0x10C2A2C", VA = "0x10C2A2C", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600D5B7")]
	[Address(RVA = "0x10C2AC8", Offset = "0x10C2AC8", VA = "0x10C2AC8", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x600D5B8")]
	[Address(RVA = "0x10C2B64", Offset = "0x10C2B64", VA = "0x10C2B64")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D5B9")]
	[Address(RVA = "0x10C2B6C", Offset = "0x10C2B6C", VA = "0x10C2B6C")]
	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600D5BA")]
	[Address(RVA = "0x10C2B74", Offset = "0x10C2B74", VA = "0x10C2B74")]
	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
