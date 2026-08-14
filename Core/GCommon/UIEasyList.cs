using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x200413F")]
public class UIEasyList : MonoBehaviour
{
	[Token(Token = "0x2004140")]
	public delegate void OnDataListShowFinished();

	[Token(Token = "0x401B631")]
	[FieldOffset(Offset = "0xC")]
	public UIScrollView m_ListScrollView;

	[Token(Token = "0x401B632")]
	[FieldOffset(Offset = "0x10")]
	public GameObject m_ListContainer;

	[Token(Token = "0x401B633")]
	[FieldOffset(Offset = "0x14")]
	public float m_ItemWidth;

	[Token(Token = "0x401B634")]
	[FieldOffset(Offset = "0x18")]
	public float m_ItemHeight;

	[Token(Token = "0x401B635")]
	[FieldOffset(Offset = "0x1C")]
	public int m_Columns;

	[Token(Token = "0x401B636")]
	[FieldOffset(Offset = "0x20")]
	private bool m_DisableRefreshWhenInvisible;

	[Token(Token = "0x401B637")]
	[FieldOffset(Offset = "0x24")]
	private IEasyList m_EasyListCallBack;

	[Token(Token = "0x401B638")]
	[FieldOffset(Offset = "0x28")]
	private UIWrapContentExtend m_WrapContent;

	[Token(Token = "0x401B639")]
	[FieldOffset(Offset = "0x2C")]
	private List<object> m_DataList;

	[Token(Token = "0x401B63A")]
	[FieldOffset(Offset = "0x30")]
	private Vector2 m_PanelSize;

	[Token(Token = "0x401B63B")]
	[FieldOffset(Offset = "0x38")]
	private Vector2 m_ItemSize;

	[Token(Token = "0x401B63C")]
	[FieldOffset(Offset = "0x40")]
	private UIPanel m_ScrollViewPanel;

	[Token(Token = "0x401B63D")]
	[FieldOffset(Offset = "0x44")]
	public int m_RealIndexInList;

	[Token(Token = "0x401B63E")]
	[FieldOffset(Offset = "0x48")]
	private int m_LastIndexClicked;

	[Token(Token = "0x401B63F")]
	[FieldOffset(Offset = "0x4C")]
	private Dictionary<object, int> m_DataWrapIndexDict;

	[Token(Token = "0x401B640")]
	[FieldOffset(Offset = "0x50")]
	public OnDataListShowFinished onDataListShowFinished;

	[Token(Token = "0x401B641")]
	[FieldOffset(Offset = "0x54")]
	private UIEasyListItemController[] m_CreatedItemCache;

	[Token(Token = "0x401B642")]
	[FieldOffset(Offset = "0x58")]
	private bool m_IsInited;

	[Token(Token = "0x401B643")]
	[FieldOffset(Offset = "0x5C")]
	private int m_LineCountPerPage;

	[Token(Token = "0x17001D5D")]
	protected UIPanel ScrollViewPanel
	{
		[Token(Token = "0x601AA83")]
		[Address(RVA = "0x2C9E600", Offset = "0x2C9E600", VA = "0x2C9E600")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D5E")]
	public UIEasyListItemController[] CreatedItemCache
	{
		[Token(Token = "0x601AA84")]
		[Address(RVA = "0x2C9E710", Offset = "0x2C9E710", VA = "0x2C9E710")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D5F")]
	public int MaxCachedCount
	{
		[Token(Token = "0x601AA85")]
		[Address(RVA = "0x2C9E718", Offset = "0x2C9E718", VA = "0x2C9E718")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x601AA82")]
	[Address(RVA = "0x2C9E4C8", Offset = "0x2C9E4C8", VA = "0x2C9E4C8")]
	public UIEasyList()
	{
	}

	[Token(Token = "0x601AA86")]
	[Address(RVA = "0x2C9E720", Offset = "0x2C9E720", VA = "0x2C9E720")]
	public void InitEasyList(IEasyList eastlistCallBack, bool disableRefreshWhenInvisible = false)
	{
	}

	[Token(Token = "0x601AA87")]
	[Address(RVA = "0x2C9EBDC", Offset = "0x2C9EBDC", VA = "0x2C9EBDC")]
	private bool CheckInitial()
	{
		return default(bool);
	}

	[Token(Token = "0x601AA88")]
	[Address(RVA = "0x2C9ED20", Offset = "0x2C9ED20", VA = "0x2C9ED20")]
	private void OnDragExcessBounds()
	{
	}

	[Token(Token = "0x601AA89")]
	[Address(RVA = "0x2C9EFF8", Offset = "0x2C9EFF8", VA = "0x2C9EFF8")]
	private void PrepareQuickChildControllers(bool createCache = false)
	{
	}

	[Token(Token = "0x601AA8A")]
	[Address(RVA = "0x2C9FB64", Offset = "0x2C9FB64", VA = "0x2C9FB64")]
	private void PrepareChildControllers(bool useCache = false)
	{
	}

	[Token(Token = "0x601AA8B")]
	[Address(RVA = "0x2CA04C0", Offset = "0x2CA04C0", VA = "0x2CA04C0")]
	private void onWrapInitializeItem(GameObject go, int wrapIndex, int realIndex)
	{
	}

	[Token(Token = "0x601AA8C")]
	[Address(RVA = "0x2CA0738", Offset = "0x2CA0738", VA = "0x2CA0738")]
	private UIEasyListItemController GetItemControllerFromCache(GameObject go, int wrapIndex)
	{
		return null;
	}

	[Token(Token = "0x601AA8D")]
	[Address(RVA = "0x2CA0A00", Offset = "0x2CA0A00", VA = "0x2CA0A00")]
	public bool ScrollTo(int index, bool Restrictflag = true, float offset = 0f)
	{
		return default(bool);
	}

	[Token(Token = "0x601AA8E")]
	[Address(RVA = "0x2CA0E4C", Offset = "0x2CA0E4C", VA = "0x2CA0E4C")]
	public void ForceUpdateWrapContent()
	{
	}

	[Token(Token = "0x601AA8F")]
	[Address(RVA = "0x2CA0E78", Offset = "0x2CA0E78", VA = "0x2CA0E78")]
	public int GetCurrentRealIndex(out float offset)
	{
		return default(int);
	}

	[Token(Token = "0x601AA90")]
	[Address(RVA = "0x2CA0F44", Offset = "0x2CA0F44", VA = "0x2CA0F44")]
	public void ClearAllEasyListItem()
	{
	}

	[Token(Token = "0x601AA91")]
	[Address(RVA = "0x2CA10CC", Offset = "0x2CA10CC", VA = "0x2CA10CC")]
	public int GetDataListCount()
	{
		return default(int);
	}

	[Token(Token = "0x601AA92")]
	public void RefreshEasyListView<DataType>(List<DataType> dataList, int columns = 1, float itemWidth = 0f, float itemHeight = 0f, int defaultScrollIndex = 0, bool resetScroll = true)
	{
	}

	[Token(Token = "0x601AA93")]
	[Address(RVA = "0x2CA1174", Offset = "0x2CA1174", VA = "0x2CA1174")]
	private void TryPlayItemAnimQueue()
	{
	}

	[Token(Token = "0x601AA94")]
	public void RefreshEasyListViewNoClear<DataType>(List<DataType> dataList, int columns = 1, float itemWidth = 0f, float itemHeight = 0f, int defaultScrollIndex = 0, bool resetScroll = true)
	{
	}

	[Token(Token = "0x601AA95")]
	public void RefreshEasyListViewQuickNoClear<DataType>(List<DataType> dataList, int columns = 1, float itemWidth = 0f, float itemHeight = 0f, int defaultScrollIndex = 0, bool resetScroll = true, bool createCache = false)
	{
	}

	[Token(Token = "0x601AA96")]
	[Address(RVA = "0x2CA14F0", Offset = "0x2CA14F0", VA = "0x2CA14F0")]
	private void SetItemsCount(int count, bool resetScroll)
	{
	}

	[Token(Token = "0x601AA97")]
	[Address(RVA = "0x2CA157C", Offset = "0x2CA157C", VA = "0x2CA157C")]
	public object GetItemData(int index)
	{
		return null;
	}

	[Token(Token = "0x601AA98")]
	public T GetItemController<T>(object data, bool needScroll = true, bool Restrictflag = true) where T : UIEasyListItemController
	{
		return null;
	}

	[Token(Token = "0x601AA99")]
	[Address(RVA = "0x2CA1294", Offset = "0x2CA1294", VA = "0x2CA1294")]
	public UIEasyListItemController[] GetItemControllersInCurrentPage()
	{
		return null;
	}

	[Token(Token = "0x601AA9A")]
	[Address(RVA = "0x2CA1650", Offset = "0x2CA1650", VA = "0x2CA1650")]
	public UIEasyListItemController GetFirstItemControllerInCurrentPage()
	{
		return null;
	}

	[Token(Token = "0x601AA9B")]
	[Address(RVA = "0x2CA1804", Offset = "0x2CA1804", VA = "0x2CA1804")]
	public UIEasyListItemController GetLastItemControllerInCurrentPage()
	{
		return null;
	}

	[Token(Token = "0x601AA9C")]
	public T GetItemController<T>(int index, bool needScroll = true, bool Restrictflag = true) where T : UIEasyListItemController
	{
		return null;
	}

	[Token(Token = "0x601AA9D")]
	[Address(RVA = "0x2CA19B0", Offset = "0x2CA19B0", VA = "0x2CA19B0")]
	public void SelectItem(int index, bool Restrictflag = true)
	{
	}

	[Token(Token = "0x601AA9E")]
	[Address(RVA = "0x2CA1AF8", Offset = "0x2CA1AF8", VA = "0x2CA1AF8")]
	public void UnSelectItem(int index, bool Restrictflag = true)
	{
	}

	[Token(Token = "0x601AA9F")]
	[Address(RVA = "0x2CA1BF0", Offset = "0x2CA1BF0", VA = "0x2CA1BF0")]
	public int GetLastIndexClick()
	{
		return default(int);
	}

	[Token(Token = "0x601AAA0")]
	[Address(RVA = "0x2CA1BF8", Offset = "0x2CA1BF8", VA = "0x2CA1BF8")]
	public void SetLastClickIndex(int click)
	{
	}

	[Token(Token = "0x601AAA1")]
	[Address(RVA = "0x2CA1C00", Offset = "0x2CA1C00", VA = "0x2CA1C00")]
	public Transform GetItemTransform(int index, bool needScroll = true)
	{
		return null;
	}

	[Token(Token = "0x601AAA2")]
	[Address(RVA = "0x2CA1DF4", Offset = "0x2CA1DF4", VA = "0x2CA1DF4")]
	public void RefreshView()
	{
	}

	[Token(Token = "0x601AAA3")]
	[Address(RVA = "0x2CA1E28", Offset = "0x2CA1E28", VA = "0x2CA1E28")]
	private void ItemSelectCallBack(int index)
	{
	}

	[Token(Token = "0x601AAA4")]
	[Address(RVA = "0x2CA1FE8", Offset = "0x2CA1FE8", VA = "0x2CA1FE8")]
	private void ItemClickCallBack(int index)
	{
	}
}
