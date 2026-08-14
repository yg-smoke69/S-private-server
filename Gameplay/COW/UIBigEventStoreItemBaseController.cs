using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2001F92")]
public class UIBigEventStoreItemBaseController : UIEasyListItemController
{
	[Token(Token = "0x400C61C")]
	[FieldOffset(Offset = "0x38")]
	private UIBigEventStoreItemBaseView m_View;

	[Token(Token = "0x400C61D")]
	[FieldOffset(Offset = "0x3C")]
	private UIModelInventory m_ModelInventory;

	[Token(Token = "0x400C61E")]
	[FieldOffset(Offset = "0x40")]
	private UIModelBigEvent m_ModelBigEvent;

	[Token(Token = "0x400C61F")]
	[FieldOffset(Offset = "0x44")]
	protected BigEventStoreCommodityDesc m_Data;

	[Token(Token = "0x400C620")]
	[FieldOffset(Offset = "0x48")]
	private UIStandardItemMiniController m_ItemCtrl;

	[Token(Token = "0x400C621")]
	[FieldOffset(Offset = "0x4C")]
	private ELimitedEvent.EventID m_EventId;

	[Token(Token = "0x400C622")]
	[FieldOffset(Offset = "0x50")]
	private ELimitedEvent.StoreType m_StoreType;

	[Token(Token = "0x400C623")]
	[FieldOffset(Offset = "0x54")]
	private Vector3 m_LimitBtnPos;

	[Token(Token = "0x17000F9C")]
	public UIBigEventStoreItemBaseView BaseView
	{
		[Token(Token = "0x6009D28")]
		[Address(RVA = "0x3017AB0", Offset = "0x3017AB0", VA = "0x3017AB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6009D29")]
		[Address(RVA = "0x3017BAC", Offset = "0x3017BAC", VA = "0x3017BAC")]
		set
		{
		}
	}

	[Token(Token = "0x6009D20")]
	[Address(RVA = "0x30177C0", Offset = "0x30177C0", VA = "0x30177C0")]
	public UIBigEventStoreItemBaseController()
	{
	}

	[Token(Token = "0x6009D21")]
	[Address(RVA = "0x30177C8", Offset = "0x30177C8", VA = "0x30177C8", Slot = "37")]
	public virtual uint GetTokenEnoughColor()
	{
		return default(uint);
	}

	[Token(Token = "0x6009D22")]
	[Address(RVA = "0x3017820", Offset = "0x3017820", VA = "0x3017820", Slot = "38")]
	public virtual uint GetTokenNotEnoughColor()
	{
		return default(uint);
	}

	[Token(Token = "0x6009D23")]
	[Address(RVA = "0x3017880", Offset = "0x3017880", VA = "0x3017880", Slot = "39")]
	public virtual uint GetTokenEnoughBgColor()
	{
		return default(uint);
	}

	[Token(Token = "0x6009D24")]
	[Address(RVA = "0x30178D8", Offset = "0x30178D8", VA = "0x30178D8", Slot = "40")]
	public virtual uint GetTokenNotEnoughBgColor()
	{
		return default(uint);
	}

	[Token(Token = "0x6009D25")]
	[Address(RVA = "0x3017938", Offset = "0x3017938", VA = "0x3017938")]
	public uint GetStoreId()
	{
		return default(uint);
	}

	[Token(Token = "0x6009D26")]
	[Address(RVA = "0x30179A8", Offset = "0x30179A8", VA = "0x30179A8", Slot = "41")]
	public virtual UIStandardItemMiniController GetItemController()
	{
		return null;
	}

	[Token(Token = "0x6009D27")]
	[Address(RVA = "0x30176C4", Offset = "0x30176C4", VA = "0x30176C4")]
	public void SetStoreData(ELimitedEvent.EventID eventID, ELimitedEvent.StoreType storeType)
	{
	}

	[Token(Token = "0x6009D2A")]
	[Address(RVA = "0x3017C0C", Offset = "0x3017C0C", VA = "0x3017C0C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009D2B")]
	[Address(RVA = "0x3017EC0", Offset = "0x3017EC0", VA = "0x3017EC0", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x6009D2C")]
	[Address(RVA = "0x3017FE0", Offset = "0x3017FE0", VA = "0x3017FE0")]
	private void SetAwardView()
	{
	}

	[Token(Token = "0x6009D2D")]
	[Address(RVA = "0x3018214", Offset = "0x3018214", VA = "0x3018214")]
	private void SetTokenView()
	{
	}

	[Token(Token = "0x6009D2E")]
	[Address(RVA = "0x30183FC", Offset = "0x30183FC", VA = "0x30183FC")]
	private void SetLimitView()
	{
	}

	[Token(Token = "0x6009D2F")]
	[Address(RVA = "0x3019128", Offset = "0x3019128", VA = "0x3019128", Slot = "42")]
	protected virtual void OnBtnCanBuyClick()
	{
	}

	[Token(Token = "0x6009D30")]
	[Address(RVA = "0x30191D0", Offset = "0x30191D0", VA = "0x30191D0", Slot = "43")]
	public virtual bool IsStoreLock()
	{
		return default(bool);
	}

	[Token(Token = "0x6009D31")]
	[Address(RVA = "0x3019228", Offset = "0x3019228", VA = "0x3019228")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
