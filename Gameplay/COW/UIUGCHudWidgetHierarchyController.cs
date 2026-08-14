using System;
using System.Collections.Generic;
using COW.UGCHudEdit;
using GCommon;
using GCommon.UGCUI;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200242D")]
public class UIUGCHudWidgetHierarchyController : UIBaseController
{
	[Token(Token = "0x200242E")]
	private sealed class _003CGetNodeItemIndex_003Ec__AnonStorey0
	{
		[Token(Token = "0x400E135")]
		[FieldOffset(Offset = "0x8")]
		internal UIUGCHudWidgetHierarchyNodeItemController item;

		[Token(Token = "0x600CD20")]
		[Address(RVA = "0x3002564", Offset = "0x3002564", VA = "0x3002564")]
		public _003CGetNodeItemIndex_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600CD21")]
		[Address(RVA = "0x3002A7C", Offset = "0x3002A7C", VA = "0x3002A7C")]
		internal bool _003C_003Em__0(UIUGCHudWidgetHierarchyNodeItemController x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400E127")]
	[FieldOffset(Offset = "0x28")]
	private UIModelUGCHudEdit m_Model;

	[Token(Token = "0x400E128")]
	[FieldOffset(Offset = "0x2C")]
	private UIUGCHudWidgetHierarchyView m_View;

	[Token(Token = "0x400E129")]
	[FieldOffset(Offset = "0x30")]
	private List<UIUGCHudWidgetHierarchyNodeItemController> m_NodeItemList;

	[Token(Token = "0x400E12A")]
	[FieldOffset(Offset = "0x34")]
	private List<UIUGCHudWidgetHierarchyNodeItemController> m_ValidItemList;

	[Token(Token = "0x400E12B")]
	[FieldOffset(Offset = "0x38")]
	private UIUGCHudWidgetHierarchyNodeItemController m_SelectedItem;

	[Token(Token = "0x400E12C")]
	[FieldOffset(Offset = "0x3C")]
	private RecordUGCHudWidgetHierarchyCommand m_RecordCommand;

	[Token(Token = "0x400E12D")]
	[FieldOffset(Offset = "0x40")]
	private bool m_IsExpand;

	[Token(Token = "0x400E12E")]
	[FieldOffset(Offset = "0x44")]
	private float m_ScrollViewTop;

	[Token(Token = "0x400E12F")]
	[FieldOffset(Offset = "0x48")]
	private float m_ScrollViewBottom;

	[Token(Token = "0x400E130")]
	[FieldOffset(Offset = "0x4C")]
	private int m_DragFrameDefaultHeight;

	[Token(Token = "0x400E131")]
	[FieldOffset(Offset = "0x50")]
	private float m_ItemSpace;

	[Token(Token = "0x400E132")]
	private const int DRAG_FRAME_MIN_HEIGHT = 6;

	[Token(Token = "0x400E133")]
	private const float THRESHOLD_Y = 10f;

	[Token(Token = "0x400E134")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<UIUGCHudWidgetHierarchyNodeItemController> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x17001106")]
	public Transform NodeRoot
	{
		[Token(Token = "0x600CD04")]
		[Address(RVA = "0x2FFED64", Offset = "0x2FFED64", VA = "0x2FFED64")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600CD01")]
	[Address(RVA = "0x2FFE7E4", Offset = "0x2FFE7E4", VA = "0x2FFE7E4")]
	public UIUGCHudWidgetHierarchyController()
	{
	}

	[Token(Token = "0x600CD02")]
	[Address(RVA = "0x2FFE8BC", Offset = "0x2FFE8BC", VA = "0x2FFE8BC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CD03")]
	[Address(RVA = "0x2FFE960", Offset = "0x2FFE960", VA = "0x2FFE960", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CD05")]
	[Address(RVA = "0x2FF1BCC", Offset = "0x2FF1BCC", VA = "0x2FF1BCC")]
	public void SetSelectedWidget(UGCHudWidget widget)
	{
	}

	[Token(Token = "0x600CD06")]
	[Address(RVA = "0x2FF2018", Offset = "0x2FF2018", VA = "0x2FF2018")]
	public void SetAddHudWidget(UGCHudWidget widget, bool includeChildren)
	{
	}

	[Token(Token = "0x600CD07")]
	[Address(RVA = "0x2FF22B4", Offset = "0x2FF22B4", VA = "0x2FF22B4")]
	public void SetRemoveHudWidget(UGCHudWidget widget, bool includeChildren)
	{
	}

	[Token(Token = "0x600CD08")]
	[Address(RVA = "0x2FEF930", Offset = "0x2FEF930", VA = "0x2FEF930")]
	public void InitNodeItems(GameObject go)
	{
	}

	[Token(Token = "0x600CD09")]
	[Address(RVA = "0x2FEF13C", Offset = "0x2FEF13C", VA = "0x2FEF13C")]
	public void SetExpand(bool expand)
	{
	}

	[Token(Token = "0x600CD0A")]
	[Address(RVA = "0x30005E0", Offset = "0x30005E0", VA = "0x30005E0")]
	public Vector3 GetItemRelativePositon(Vector3 position)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600CD0B")]
	[Address(RVA = "0x30006C8", Offset = "0x30006C8", VA = "0x30006C8")]
	public void LongPressItem(UIUGCHudWidgetHierarchyNodeItemController item)
	{
	}

	[Token(Token = "0x600CD0C")]
	[Address(RVA = "0x3000EBC", Offset = "0x3000EBC", VA = "0x3000EBC")]
	public void DragItem(UIUGCHudWidgetHierarchyNodeItemController item, Vector2 delta)
	{
	}

	[Token(Token = "0x600CD0D")]
	[Address(RVA = "0x3001420", Offset = "0x3001420", VA = "0x3001420")]
	public void ReleaseItem(UIUGCHudWidgetHierarchyNodeItemController item)
	{
	}

	[Token(Token = "0x600CD0E")]
	[Address(RVA = "0x3001EE8", Offset = "0x3001EE8", VA = "0x3001EE8")]
	public void Reset()
	{
	}

	[Token(Token = "0x600CD0F")]
	[Address(RVA = "0x3001FD0", Offset = "0x3001FD0", VA = "0x3001FD0")]
	public void AddNodeToRoot(UIUGCHudWidgetHierarchyNodeItemController node)
	{
	}

	[Token(Token = "0x600CD10")]
	[Address(RVA = "0x300046C", Offset = "0x300046C", VA = "0x300046C")]
	public void UpdateLayout()
	{
	}

	[Token(Token = "0x600CD11")]
	[Address(RVA = "0x2FFFFEC", Offset = "0x2FFFFEC", VA = "0x2FFFFEC")]
	private void AddNodeFromChildren(Transform trans, UIUGCHudWidgetHierarchyNodeItemController node)
	{
	}

	[Token(Token = "0x600CD12")]
	[Address(RVA = "0x300025C", Offset = "0x300025C", VA = "0x300025C")]
	private void DeleteNode(UIUGCHudWidgetHierarchyNodeItemController node, bool includeChildren)
	{
	}

	[Token(Token = "0x600CD13")]
	[Address(RVA = "0x2FFF070", Offset = "0x2FFF070", VA = "0x2FFF070")]
	private UIUGCHudWidgetHierarchyNodeItemController FindNodeItem(UGCHudWidget widget)
	{
		return null;
	}

	[Token(Token = "0x600CD14")]
	[Address(RVA = "0x2FFF2BC", Offset = "0x2FFF2BC", VA = "0x2FFF2BC")]
	private UIUGCHudWidgetHierarchyNodeItemController GetNodeItem()
	{
		return null;
	}

	[Token(Token = "0x600CD15")]
	[Address(RVA = "0x3000C50", Offset = "0x3000C50", VA = "0x3000C50")]
	private void UpdateValidItemList()
	{
	}

	[Token(Token = "0x600CD16")]
	[Address(RVA = "0x3002420", Offset = "0x3002420", VA = "0x3002420")]
	private int GetNodeItemIndex(UIUGCHudWidgetHierarchyNodeItemController item)
	{
		return default(int);
	}

	[Token(Token = "0x600CD17")]
	[Address(RVA = "0x300256C", Offset = "0x300256C", VA = "0x300256C")]
	private void OnSwitchBtnClick()
	{
	}

	[Token(Token = "0x600CD18")]
	[Address(RVA = "0x30025E0", Offset = "0x30025E0", VA = "0x30025E0")]
	private void OnClickItemCallback(UIUGCHudWidgetHierarchyNodeItemController item)
	{
	}

	[Token(Token = "0x600CD19")]
	[Address(RVA = "0x3002714", Offset = "0x3002714", VA = "0x3002714")]
	private void OnExpandItemCallback()
	{
	}

	[Token(Token = "0x600CD1A")]
	[Address(RVA = "0x2FFEE48", Offset = "0x2FFEE48", VA = "0x2FFEE48")]
	private bool SetSelectedItem(UIUGCHudWidgetHierarchyNodeItemController item)
	{
		return default(bool);
	}

	[Token(Token = "0x600CD1B")]
	[Address(RVA = "0x30027A8", Offset = "0x30027A8", VA = "0x30027A8")]
	private void OnDragItemCallback(UIUGCHudWidgetHierarchyNodeItemController item, Vector2 delta)
	{
	}

	[Token(Token = "0x600CD1C")]
	[Address(RVA = "0x3001300", Offset = "0x3001300", VA = "0x3001300")]
	private void StartRecord(UIUGCHudWidgetHierarchyNodeItemController item)
	{
	}

	[Token(Token = "0x600CD1D")]
	[Address(RVA = "0x3001C30", Offset = "0x3001C30", VA = "0x3001C30")]
	private void EndRecord()
	{
	}

	[Token(Token = "0x600CD1E")]
	[Address(RVA = "0x3002988", Offset = "0x3002988", VA = "0x3002988")]
	private static int _003CUpdateValidItemList_003Em__0(UIUGCHudWidgetHierarchyNodeItemController a, UIUGCHudWidgetHierarchyNodeItemController b)
	{
		return default(int);
	}

	[Token(Token = "0x600CD1F")]
	[Address(RVA = "0x3002A74", Offset = "0x3002A74", VA = "0x3002A74")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
