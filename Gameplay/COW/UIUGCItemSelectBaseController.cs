using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using ReactUI;

namespace COW;

[Token(Token = "0x2002BBA")]
public class UIUGCItemSelectBaseController : UIPopupWindowController
{
	[Token(Token = "0x4010B56")]
	[FieldOffset(Offset = "0x48")]
	protected UIModelUGCResourceSelect.ETableType m_viewTableType;

	[Token(Token = "0x4010B57")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelUGCResourceSelect.OnFinalSelected m_confirmCallback;

	[Token(Token = "0x4010B58")]
	[FieldOffset(Offset = "0x50")]
	protected int m_selectedTypeIndex;

	[Token(Token = "0x4010B59")]
	[FieldOffset(Offset = "0x54")]
	protected object m_selectedData;

	[Token(Token = "0x4010B5A")]
	[FieldOffset(Offset = "0x58")]
	protected int m_selectedItemIndex;

	[Token(Token = "0x4010B5B")]
	[FieldOffset(Offset = "0x5C")]
	protected int m_selectedItemID;

	[Token(Token = "0x4010B5C")]
	[FieldOffset(Offset = "0x60")]
	protected List<object> m_itemDatas;

	[Token(Token = "0x4010B5D")]
	[FieldOffset(Offset = "0x64")]
	protected List<int> m_itemTypes;

	[Token(Token = "0x4010B5E")]
	[FieldOffset(Offset = "0x68")]
	protected List<string> m_itemTypeKeys;

	[Token(Token = "0x4010B5F")]
	[FieldOffset(Offset = "0x6C")]
	protected UIVariable var_CurrentItemName;

	[Token(Token = "0x4010B60")]
	[FieldOffset(Offset = "0x70")]
	protected UIVariable var_CurrentItemResourceID;

	[Token(Token = "0x4010B61")]
	[FieldOffset(Offset = "0x74")]
	protected UIVariable var_CurrentItemIsShowPreview;

	[Token(Token = "0x4010B62")]
	[FieldOffset(Offset = "0x78")]
	protected UIVariable var_CurrentItemBGCdnImage;

	[Token(Token = "0x4010B63")]
	[FieldOffset(Offset = "0x7C")]
	protected UIVariable var_CurrentItemID;

	[Token(Token = "0x4010B64")]
	[FieldOffset(Offset = "0x80")]
	protected UIVariable var_CurrentItemIndex;

	[Token(Token = "0x4010B65")]
	[FieldOffset(Offset = "0x84")]
	protected UIVariable var_CurrentTypeIndex;

	[Token(Token = "0x4010B66")]
	[FieldOffset(Offset = "0x88")]
	protected UIVariable var_CurrentItemList;

	[Token(Token = "0x4010B67")]
	[FieldOffset(Offset = "0x8C")]
	protected UIVariable var_TypeList;

	[Token(Token = "0x17001301")]
	public int CurrentItemIndex
	{
		[Token(Token = "0x6012157")]
		[Address(RVA = "0x277B864", Offset = "0x277B864", VA = "0x277B864")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6012158")]
		[Address(RVA = "0x277B384", Offset = "0x277B384", VA = "0x277B384")]
		set
		{
		}
	}

	[Token(Token = "0x17001302")]
	public int CurrentTypeIndex
	{
		[Token(Token = "0x6012159")]
		[Address(RVA = "0x277B8D8", Offset = "0x277B8D8", VA = "0x277B8D8")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x601215A")]
		[Address(RVA = "0x277B168", Offset = "0x277B168", VA = "0x277B168")]
		set
		{
		}
	}

	[Token(Token = "0x17001303")]
	public int CurrentType
	{
		[Token(Token = "0x601215B")]
		[Address(RVA = "0x277B94C", Offset = "0x277B94C", VA = "0x277B94C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001304")]
	public int CurrentItemID
	{
		[Token(Token = "0x601215C")]
		[Address(RVA = "0x277BA64", Offset = "0x277BA64", VA = "0x277BA64")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x601215D")]
		[Address(RVA = "0x277B0D4", Offset = "0x277B0D4", VA = "0x277B0D4")]
		set
		{
		}
	}

	[Token(Token = "0x601214D")]
	[Address(RVA = "0x277A0F0", Offset = "0x277A0F0", VA = "0x277A0F0")]
	public UIUGCItemSelectBaseController()
	{
	}

	[Token(Token = "0x601214E")]
	[Address(RVA = "0x277A1E4", Offset = "0x277A1E4", VA = "0x277A1E4", Slot = "46")]
	public virtual void GetItemTypeList(List<int> retTypeIDList, List<string> retTypeLocKeyList)
	{
	}

	[Token(Token = "0x601214F")]
	[Address(RVA = "0x277A388", Offset = "0x277A388", VA = "0x277A388", Slot = "47")]
	public virtual void GetItemDataListByType(int itemType, List<object> retResIconList)
	{
	}

	[Token(Token = "0x6012150")]
	[Address(RVA = "0x277A504", Offset = "0x277A504", VA = "0x277A504", Slot = "48")]
	public virtual void OnSelectItem(object item)
	{
	}

	[Token(Token = "0x6012151")]
	[Address(RVA = "0x277A560", Offset = "0x277A560", VA = "0x277A560", Slot = "49")]
	public virtual int GetItemID(object item)
	{
		return default(int);
	}

	[Token(Token = "0x6012152")]
	[Address(RVA = "0x277A6A0", Offset = "0x277A6A0", VA = "0x277A6A0", Slot = "50")]
	public virtual string GetItemName(object item)
	{
		return null;
	}

	[Token(Token = "0x6012153")]
	[Address(RVA = "0x277A7E0", Offset = "0x277A7E0", VA = "0x277A7E0", Slot = "51")]
	public virtual string GetItemResourceID(object item)
	{
		return null;
	}

	[Token(Token = "0x6012154")]
	[Address(RVA = "0x277A920", Offset = "0x277A920", VA = "0x277A920", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6012155")]
	[Address(RVA = "0x277AA90", Offset = "0x277AA90", VA = "0x277AA90")]
	public void InitOpeningSelectByResID(string currentResIDName, [Optional] UIModelUGCResourceSelect.OnFinalSelected callback)
	{
	}

	[Token(Token = "0x6012156")]
	[Address(RVA = "0x277B800", Offset = "0x277B800", VA = "0x277B800", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x601215E")]
	[Address(RVA = "0x277BAD8", Offset = "0x277BAD8", VA = "0x277BAD8")]
	private void event_OnSelectItem(object[] args)
	{
	}

	[Token(Token = "0x601215F")]
	[Address(RVA = "0x277B418", Offset = "0x277B418", VA = "0x277B418")]
	private void RefreshCurrentItemInfo()
	{
	}

	[Token(Token = "0x6012160")]
	[Address(RVA = "0x277BCB8", Offset = "0x277BCB8", VA = "0x277BCB8")]
	private void event_OnSelectType(object[] args)
	{
	}

	[Token(Token = "0x6012161")]
	[Address(RVA = "0x277BEA4", Offset = "0x277BEA4", VA = "0x277BEA4")]
	private void event_RefreshItemList(object[] args)
	{
	}

	[Token(Token = "0x6012162")]
	[Address(RVA = "0x277BF0C", Offset = "0x277BF0C", VA = "0x277BF0C")]
	private void event_OnConfirm(object[] args)
	{
	}

	[Token(Token = "0x6012163")]
	[Address(RVA = "0x277B1FC", Offset = "0x277B1FC", VA = "0x277B1FC")]
	protected void RefreshShowingItems()
	{
	}

	[Token(Token = "0x6012164")]
	[Address(RVA = "0x277C0B8", Offset = "0x277C0B8", VA = "0x277C0B8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6012165")]
	[Address(RVA = "0x277C0C0", Offset = "0x277C0C0", VA = "0x277C0C0")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
