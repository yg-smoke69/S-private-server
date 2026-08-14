using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2001F6C")]
internal class UIActivityPopWindowBase : UINaviPopController
{
	[Token(Token = "0x2001F6D")]
	private class GoToArgs
	{
		[Token(Token = "0x400C567")]
		[FieldOffset(Offset = "0x8")]
		public int categoryType;

		[Token(Token = "0x400C568")]
		[FieldOffset(Offset = "0xC")]
		public uint id;

		[Token(Token = "0x6009BDA")]
		[Address(RVA = "0x2FBD844", Offset = "0x2FBD844", VA = "0x2FBD844")]
		public GoToArgs()
		{
		}
	}

	[Token(Token = "0x2001F6E")]
	protected delegate UIActivityBaseController ContentCreator();

	[Token(Token = "0x2001F6F")]
	protected class CategoryTabData
	{
		[Token(Token = "0x400C569")]
		[FieldOffset(Offset = "0x8")]
		public ContentCreator content;

		[Token(Token = "0x400C56A")]
		[FieldOffset(Offset = "0xC")]
		public string title;

		[Token(Token = "0x400C56B")]
		[FieldOffset(Offset = "0x10")]
		public string icon;

		[Token(Token = "0x400C56C")]
		[FieldOffset(Offset = "0x14")]
		public ETipsType redPoint;

		[Token(Token = "0x400C56D")]
		[FieldOffset(Offset = "0x18")]
		public object data;

		[Token(Token = "0x400C56E")]
		[FieldOffset(Offset = "0x1C")]
		public string colorValue;

		[Token(Token = "0x400C56F")]
		[FieldOffset(Offset = "0x20")]
		public string selectLine;

		[Token(Token = "0x400C570")]
		[FieldOffset(Offset = "0x24")]
		public uint prioritySelectItemID;

		[Token(Token = "0x400C571")]
		[FieldOffset(Offset = "0x28")]
		public int optActivityCategory;

		[Token(Token = "0x6009BDF")]
		[Address(RVA = "0x2FB8434", Offset = "0x2FB8434", VA = "0x2FB8434")]
		public CategoryTabData()
		{
		}
	}

	[Token(Token = "0x2001F70")]
	private sealed class _003CGotoSpecificCategory_003Ec__AnonStorey0
	{
		[Token(Token = "0x400C572")]
		[FieldOffset(Offset = "0x8")]
		internal int categoryType;

		[Token(Token = "0x6009BE0")]
		[Address(RVA = "0x2FBD83C", Offset = "0x2FBD83C", VA = "0x2FBD83C")]
		public _003CGotoSpecificCategory_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6009BE1")]
		[Address(RVA = "0x2FBE5FC", Offset = "0x2FBE5FC", VA = "0x2FBE5FC")]
		internal bool _003C_003Em__0(CategoryTabData e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400C55B")]
	[FieldOffset(Offset = "0x70")]
	private UIActivityMasterView m_View;

	[Token(Token = "0x400C55C")]
	[FieldOffset(Offset = "0x74")]
	private Dictionary<int, UIActivityBaseController> m_Contents;

	[Token(Token = "0x400C55D")]
	[FieldOffset(Offset = "0x78")]
	private int m_CurrentTabIndex;

	[Token(Token = "0x400C55E")]
	[FieldOffset(Offset = "0x7C")]
	protected Dictionary<uint, int> m_TabTypeActivityCategoryMap;

	[Token(Token = "0x400C55F")]
	[FieldOffset(Offset = "0x0")]
	public static ResourceID m_UIResourceID;

	[Token(Token = "0x400C560")]
	[FieldOffset(Offset = "0x80")]
	protected float m_RequestTimeout;

	[Token(Token = "0x400C561")]
	[FieldOffset(Offset = "0x84")]
	protected int m_CurrentType;

	[Token(Token = "0x400C562")]
	[FieldOffset(Offset = "0x88")]
	private int m_TabSpace;

	[Token(Token = "0x400C563")]
	[FieldOffset(Offset = "0x8C")]
	protected List<CategoryTabData> m_CategoryDatas;

	[Token(Token = "0x400C564")]
	[FieldOffset(Offset = "0x90")]
	private GoToArgs m_GoToArgs;

	[Token(Token = "0x400C565")]
	[FieldOffset(Offset = "0x94")]
	private List<StandardTopTabItemViewData> m_TabDataList;

	[Token(Token = "0x400C566")]
	[FieldOffset(Offset = "0x98")]
	private UIStandardTopTabController m_TabCtrl;

	[Token(Token = "0x6009BBB")]
	[Address(RVA = "0x2FB69B4", Offset = "0x2FB69B4", VA = "0x2FB69B4")]
	public UIActivityPopWindowBase()
	{
	}

	[Token(Token = "0x6009BBC")]
	[Address(RVA = "0x2FB6FD4", Offset = "0x2FB6FD4", VA = "0x2FB6FD4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009BBD")]
	[Address(RVA = "0x2FB7C58", Offset = "0x2FB7C58", VA = "0x2FB7C58", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6009BBE")]
	[Address(RVA = "0x2FB8F0C", Offset = "0x2FB8F0C", VA = "0x2FB8F0C")]
	protected Transform ContentMountPoint()
	{
		return null;
	}

	[Token(Token = "0x6009BBF")]
	[Address(RVA = "0x2FBBFB0", Offset = "0x2FBBFB0", VA = "0x2FBBFB0")]
	protected void WaitForNetworkDataUI(bool noData)
	{
	}

	[Token(Token = "0x6009BC0")]
	[Address(RVA = "0x2FBC068", Offset = "0x2FBC068", VA = "0x2FBC068", Slot = "43")]
	public virtual void UpdateUI()
	{
	}

	[Token(Token = "0x6009BC1")]
	[Address(RVA = "0x2FB83E0", Offset = "0x2FB83E0", VA = "0x2FB83E0", Slot = "44")]
	public virtual void PrepareTopTabData()
	{
	}

	[Token(Token = "0x6009BC2")]
	[Address(RVA = "0x2FBCAB0", Offset = "0x2FBCAB0", VA = "0x2FBCAB0")]
	private int GetFullWidth()
	{
		return default(int);
	}

	[Token(Token = "0x6009BC3")]
	[Address(RVA = "0x2FBC2DC", Offset = "0x2FBC2DC", VA = "0x2FBC2DC")]
	private void CreateTopTabs()
	{
	}

	[Token(Token = "0x6009BC4")]
	[Address(RVA = "0x2FBCCD8", Offset = "0x2FBCCD8", VA = "0x2FBCCD8")]
	public void UpdateTabs()
	{
	}

	[Token(Token = "0x6009BC5")]
	[Address(RVA = "0x2FBD2FC", Offset = "0x2FBD2FC", VA = "0x2FBD2FC")]
	private void AdjustTabsWidth(UIToggleButton tab, int index, int width)
	{
	}

	[Token(Token = "0x6009BC6")]
	[Address(RVA = "0x2FB75AC", Offset = "0x2FB75AC", VA = "0x2FB75AC")]
	protected CategoryTabData GetCurCategoryData()
	{
		return null;
	}

	[Token(Token = "0x6009BC7")]
	[Address(RVA = "0x2FBC7D8", Offset = "0x2FBC7D8", VA = "0x2FBC7D8")]
	public void GotoSpecificCategory(int categoryType, uint id)
	{
	}

	[Token(Token = "0x6009BC8")]
	[Address(RVA = "0x2FBDA84", Offset = "0x2FBDA84", VA = "0x2FBDA84")]
	public void GotoSpecificTCategoryByTabType(uint tabTabType, uint id)
	{
	}

	[Token(Token = "0x6009BC9")]
	[Address(RVA = "0x2FBDB18", Offset = "0x2FBDB18", VA = "0x2FBDB18")]
	private void TopTabSelected(int index)
	{
	}

	[Token(Token = "0x6009BCA")]
	[Address(RVA = "0x2FBE0AC", Offset = "0x2FBE0AC", VA = "0x2FBE0AC", Slot = "45")]
	protected virtual void OnMainTabSelect(CategoryTabData data)
	{
	}

	[Token(Token = "0x6009BCB")]
	[Address(RVA = "0x2FBDD90", Offset = "0x2FBDD90", VA = "0x2FBDD90")]
	private void HideCurrentContent()
	{
	}

	[Token(Token = "0x6009BCC")]
	[Address(RVA = "0x2FB8940", Offset = "0x2FB8940", VA = "0x2FB8940")]
	protected UIActivityBaseController GetCurrentContent()
	{
		return null;
	}

	[Token(Token = "0x6009BCD")]
	[Address(RVA = "0x2FBD84C", Offset = "0x2FBD84C", VA = "0x2FBD84C")]
	private void ShowHighestPriorityTab()
	{
	}

	[Token(Token = "0x6009BCE")]
	[Address(RVA = "0x2FB9150", Offset = "0x2FB9150", VA = "0x2FB9150", Slot = "46")]
	protected virtual int GetTabPriority(CategoryTabData tabData)
	{
		return default(int);
	}

	[Token(Token = "0x6009BCF")]
	[Address(RVA = "0x2FBE108", Offset = "0x2FBE108", VA = "0x2FBE108")]
	protected void SelectToggle(UIToggleButton toggle)
	{
	}

	[Token(Token = "0x6009BD0")]
	[Address(RVA = "0x2FBE1F0", Offset = "0x2FBE1F0", VA = "0x2FBE1F0")]
	private void OnActivityGotoClick(object[] data)
	{
	}

	[Token(Token = "0x6009BD1")]
	[Address(RVA = "0x2FB8450", Offset = "0x2FB8450", VA = "0x2FB8450")]
	public int TabType2ActivityCategory(uint tabType)
	{
		return default(int);
	}

	[Token(Token = "0x6009BD2")]
	[Address(RVA = "0x2FBD0D8", Offset = "0x2FBD0D8", VA = "0x2FBD0D8")]
	public uint ActivityCategory2TabType(int category)
	{
		return default(uint);
	}

	[Token(Token = "0x6009BD3")]
	[Address(RVA = "0x2FBE300", Offset = "0x2FBE300", VA = "0x2FBE300", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x6009BD4")]
	[Address(RVA = "0x2FBE430", Offset = "0x2FBE430", VA = "0x2FBE430", Slot = "33")]
	protected override void OnPopupWindowListChange()
	{
	}

	[Token(Token = "0x6009BD6")]
	[Address(RVA = "0x2FBE5DC", Offset = "0x2FBE5DC", VA = "0x2FBE5DC")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009BD7")]
	[Address(RVA = "0x2FBE5E4", Offset = "0x2FBE5E4", VA = "0x2FBE5E4")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x6009BD8")]
	[Address(RVA = "0x2FBE5EC", Offset = "0x2FBE5EC", VA = "0x2FBE5EC")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x6009BD9")]
	[Address(RVA = "0x2FBE5F4", Offset = "0x2FBE5F4", VA = "0x2FBE5F4")]
	public void _003C_003EiFixBaseProxy_OnPopupWindowListChange()
	{
	}
}
