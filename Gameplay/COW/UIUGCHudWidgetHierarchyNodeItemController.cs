using System;
using System.Collections.Generic;
using GCommon;
using GCommon.UGCUI;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200242F")]
public class UIUGCHudWidgetHierarchyNodeItemController : UIBaseController
{
	[Token(Token = "0x2002430")]
	public enum OperateStateEnum
	{
		[Token(Token = "0x400E149")]
		None,
		[Token(Token = "0x400E14A")]
		Drag
	}

	[Token(Token = "0x2002431")]
	private sealed class _003C_003Ec__AnonStorey0
	{
		[Token(Token = "0x400E14B")]
		[FieldOffset(Offset = "0x8")]
		internal uint value;

		[Token(Token = "0x600CD4C")]
		[Address(RVA = "0x3003374", Offset = "0x3003374", VA = "0x3003374")]
		public _003C_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600CD4D")]
		[Address(RVA = "0x3004C64", Offset = "0x3004C64", VA = "0x3004C64")]
		internal bool _003C_003Em__0(UIUGCHudWidgetHierarchyNodeItemController child)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002432")]
	private sealed class _003CFindChildIndex_003Ec__AnonStorey1
	{
		[Token(Token = "0x400E14C")]
		[FieldOffset(Offset = "0x8")]
		internal UIUGCHudWidgetHierarchyNodeItemController node;

		[Token(Token = "0x600CD4E")]
		[Address(RVA = "0x3003E1C", Offset = "0x3003E1C", VA = "0x3003E1C")]
		public _003CFindChildIndex_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x600CD4F")]
		[Address(RVA = "0x3004CBC", Offset = "0x3004CBC", VA = "0x3004CBC")]
		internal bool _003C_003Em__0(UIUGCHudWidgetHierarchyNodeItemController x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400E136")]
	[FieldOffset(Offset = "0x28")]
	private UIUGCHudWidgetHierarchyNodeItemView m_View;

	[Token(Token = "0x400E137")]
	[FieldOffset(Offset = "0x2C")]
	private UGCHudWidget m_Widget;

	[Token(Token = "0x400E138")]
	[FieldOffset(Offset = "0x30")]
	private UIUGCHudWidgetHierarchyController m_HierarchyController;

	[Token(Token = "0x400E139")]
	[FieldOffset(Offset = "0x34")]
	private UIUGCHudWidgetHierarchyNodeItemController m_Parent;

	[Token(Token = "0x400E13A")]
	[FieldOffset(Offset = "0x38")]
	private List<UIUGCHudWidgetHierarchyNodeItemController> m_Children;

	[Token(Token = "0x400E13B")]
	[FieldOffset(Offset = "0x3C")]
	private Action<UIUGCHudWidgetHierarchyNodeItemController> m_ItemSelectedCallback;

	[Token(Token = "0x400E13C")]
	[FieldOffset(Offset = "0x40")]
	private Action m_ExpandCallback;

	[Token(Token = "0x400E13D")]
	private const float m_OffsetX = 30f;

	[Token(Token = "0x400E13E")]
	private const float DRAG_TIME = 0.5f;

	[Token(Token = "0x400E13F")]
	public const float ITEM_HEIGHT = 62f;

	[Token(Token = "0x400E140")]
	public const float HALF_ITEM_HEIGHT = 31f;

	[Token(Token = "0x400E141")]
	[FieldOffset(Offset = "0x0")]
	private static uint s_MaxHierarchyLimit;

	[Token(Token = "0x400E142")]
	[FieldOffset(Offset = "0x44")]
	private int m_Index;

	[Token(Token = "0x400E143")]
	[FieldOffset(Offset = "0x48")]
	private float m_InitPosX;

	[Token(Token = "0x400E144")]
	[FieldOffset(Offset = "0x4C")]
	private float m_PressTime;

	[Token(Token = "0x400E145")]
	[FieldOffset(Offset = "0x50")]
	private bool m_IsPress;

	[Token(Token = "0x400E146")]
	[FieldOffset(Offset = "0x51")]
	private bool m_IsExpand;

	[Token(Token = "0x400E147")]
	[FieldOffset(Offset = "0x54")]
	private OperateStateEnum m_OperateState;

	[Token(Token = "0x17001107")]
	public uint Hierarchy
	{
		[Token(Token = "0x600CD25")]
		[Address(RVA = "0x3002EE4", Offset = "0x3002EE4", VA = "0x3002EE4")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17001108")]
	public int Index
	{
		[Token(Token = "0x600CD26")]
		[Address(RVA = "0x3002FE4", Offset = "0x3002FE4", VA = "0x3002FE4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600CD27")]
		[Address(RVA = "0x3003068", Offset = "0x3003068", VA = "0x3003068")]
		set
		{
		}
	}

	[Token(Token = "0x17001109")]
	public bool IsExpand
	{
		[Token(Token = "0x600CD28")]
		[Address(RVA = "0x3001CE4", Offset = "0x3001CE4", VA = "0x3001CE4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700110A")]
	public UGCHudWidget Widget
	{
		[Token(Token = "0x600CD29")]
		[Address(RVA = "0x2FFEDF0", Offset = "0x2FFEDF0", VA = "0x2FFEDF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700110B")]
	public UIUGCHudWidgetHierarchyNodeItemController ParentNode
	{
		[Token(Token = "0x600CD2A")]
		[Address(RVA = "0x3000204", Offset = "0x3000204", VA = "0x3000204")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700110C")]
	public List<UIUGCHudWidgetHierarchyNodeItemController> Children
	{
		[Token(Token = "0x600CD2B")]
		[Address(RVA = "0x3002278", Offset = "0x3002278", VA = "0x3002278")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700110D")]
	public int ChildCount
	{
		[Token(Token = "0x600CD2C")]
		[Address(RVA = "0x3003144", Offset = "0x3003144", VA = "0x3003144")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700110E")]
	public uint ChildMaxRelativeHierary
	{
		[Token(Token = "0x600CD2D")]
		[Address(RVA = "0x3003204", Offset = "0x3003204", VA = "0x3003204")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x1700110F")]
	public UIUGCHudWidgetHierarchyController HierarchyController
	{
		[Token(Token = "0x600CD2E")]
		[Address(RVA = "0x300358C", Offset = "0x300358C", VA = "0x300358C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001110")]
	public Vector3 RelativePosition
	{
		[Token(Token = "0x600CD2F")]
		[Address(RVA = "0x3000B7C", Offset = "0x3000B7C", VA = "0x3000B7C")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}
	}

	[Token(Token = "0x600CD22")]
	[Address(RVA = "0x3002B0C", Offset = "0x3002B0C", VA = "0x3002B0C")]
	public UIUGCHudWidgetHierarchyNodeItemController()
	{
	}

	[Token(Token = "0x600CD23")]
	[Address(RVA = "0x3002BCC", Offset = "0x3002BCC", VA = "0x3002BCC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CD24")]
	[Address(RVA = "0x3002C70", Offset = "0x3002C70", VA = "0x3002C70", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CD30")]
	[Address(RVA = "0x2FFF57C", Offset = "0x2FFF57C", VA = "0x2FFF57C")]
	public void BindWidget(UGCHudWidget widget)
	{
	}

	[Token(Token = "0x600CD31")]
	[Address(RVA = "0x2FFFAB4", Offset = "0x2FFFAB4", VA = "0x2FFFAB4")]
	public bool SetParent(UIUGCHudWidgetHierarchyNodeItemController node, bool syncWidget = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600CD32")]
	[Address(RVA = "0x30018C8", Offset = "0x30018C8", VA = "0x30018C8")]
	public bool Insert(UIUGCHudWidgetHierarchyNodeItemController node, bool insertBack)
	{
		return default(bool);
	}

	[Token(Token = "0x600CD33")]
	[Address(RVA = "0x3003CD8", Offset = "0x3003CD8", VA = "0x3003CD8")]
	public int FindChildIndex(UIUGCHudWidgetHierarchyNodeItemController node)
	{
		return default(int);
	}

	[Token(Token = "0x600CD34")]
	[Address(RVA = "0x30023A0", Offset = "0x30023A0", VA = "0x30023A0")]
	public void SetCallback(Action<UIUGCHudWidgetHierarchyNodeItemController> selectedCallback, Action expandCallback)
	{
	}

	[Token(Token = "0x600CD35")]
	[Address(RVA = "0x3003E24", Offset = "0x3003E24", VA = "0x3003E24")]
	public void SetChildrenActived(bool value, bool recursive)
	{
	}

	[Token(Token = "0x600CD36")]
	[Address(RVA = "0x300216C", Offset = "0x300216C", VA = "0x300216C")]
	public void OnRecycle()
	{
	}

	[Token(Token = "0x600CD37")]
	[Address(RVA = "0x30022D0", Offset = "0x30022D0", VA = "0x30022D0")]
	public void Clear()
	{
	}

	[Token(Token = "0x600CD38")]
	[Address(RVA = "0x3003AE4", Offset = "0x3003AE4", VA = "0x3003AE4")]
	public void UpdateLayout(bool upwards)
	{
	}

	[Token(Token = "0x600CD39")]
	[Address(RVA = "0x3001D3C", Offset = "0x3001D3C", VA = "0x3001D3C")]
	public void SetExpand(bool expand)
	{
	}

	[Token(Token = "0x600CD3A")]
	[Address(RVA = "0x300396C", Offset = "0x300396C", VA = "0x300396C")]
	protected void AddChildNode(UIUGCHudWidgetHierarchyNodeItemController node)
	{
	}

	[Token(Token = "0x600CD3B")]
	[Address(RVA = "0x300386C", Offset = "0x300386C", VA = "0x300386C")]
	protected void RemoveChildNode(UIUGCHudWidgetHierarchyNodeItemController node)
	{
	}

	[Token(Token = "0x600CD3C")]
	[Address(RVA = "0x30036C4", Offset = "0x30036C4", VA = "0x30036C4")]
	protected void OnHierarchyDirty()
	{
	}

	[Token(Token = "0x600CD3D")]
	[Address(RVA = "0x3004030", Offset = "0x3004030", VA = "0x3004030")]
	protected void OnChildCountDirty()
	{
	}

	[Token(Token = "0x600CD3E")]
	[Address(RVA = "0x300337C", Offset = "0x300337C", VA = "0x300337C")]
	private void ForeachChildren(List<UIUGCHudWidgetHierarchyNodeItemController> children, Func<UIUGCHudWidgetHierarchyNodeItemController, bool> func, bool recursive = true)
	{
	}

	[Token(Token = "0x600CD3F")]
	[Address(RVA = "0x3004150", Offset = "0x3004150", VA = "0x3004150")]
	private void SetRetract()
	{
	}

	[Token(Token = "0x600CD40")]
	[Address(RVA = "0x30042E0", Offset = "0x30042E0", VA = "0x30042E0")]
	private void OnWidgetNameChanged()
	{
	}

	[Token(Token = "0x600CD41")]
	[Address(RVA = "0x3004394", Offset = "0x3004394", VA = "0x3004394")]
	private void SwitchOperateState(OperateStateEnum state)
	{
	}

	[Token(Token = "0x600CD42")]
	[Address(RVA = "0x3004418", Offset = "0x3004418", VA = "0x3004418")]
	private void OnExitOperateState(OperateStateEnum state)
	{
	}

	[Token(Token = "0x600CD43")]
	[Address(RVA = "0x3004538", Offset = "0x3004538", VA = "0x3004538")]
	private void OnEnterOperateState(OperateStateEnum state)
	{
	}

	[Token(Token = "0x600CD44")]
	[Address(RVA = "0x30046D8", Offset = "0x30046D8", VA = "0x30046D8")]
	private void OnArrowClick()
	{
	}

	[Token(Token = "0x600CD45")]
	[Address(RVA = "0x3004758", Offset = "0x3004758", VA = "0x3004758")]
	private void OnActiveToggleClick()
	{
	}

	[Token(Token = "0x600CD46")]
	[Address(RVA = "0x30048A8", Offset = "0x30048A8", VA = "0x30048A8")]
	private void OnClick()
	{
	}

	[Token(Token = "0x600CD47")]
	[Address(RVA = "0x3004A00", Offset = "0x3004A00", VA = "0x3004A00")]
	private void OnPress(bool isPress)
	{
	}

	[Token(Token = "0x600CD48")]
	[Address(RVA = "0x3004A80", Offset = "0x3004A80", VA = "0x3004A80")]
	private void OnDrag(Vector2 delta)
	{
	}

	[Token(Token = "0x600CD49")]
	[Address(RVA = "0x3004B48", Offset = "0x3004B48", VA = "0x3004B48")]
	private void Update()
	{
	}

	[Token(Token = "0x600CD4B")]
	[Address(RVA = "0x3004C5C", Offset = "0x3004C5C", VA = "0x3004C5C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
