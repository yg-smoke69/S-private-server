using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002BB1")]
public class UIUGCRecommendationController : UIBaseController, _Attribute
{
	[Token(Token = "0x2002BB2")]
	public class SideRecItem
	{
		[Token(Token = "0x4010B36")]
		[FieldOffset(Offset = "0x8")]
		public int Index;

		[Token(Token = "0x4010B37")]
		[FieldOffset(Offset = "0xC")]
		public GameObject CDNGo;

		[Token(Token = "0x4010B38")]
		[FieldOffset(Offset = "0x10")]
		public UINetworkTexture CDN;

		[Token(Token = "0x4010B39")]
		[FieldOffset(Offset = "0x14")]
		public UIButton Button;

		[Token(Token = "0x4010B3A")]
		[FieldOffset(Offset = "0x18")]
		public UILabel Title;

		[Token(Token = "0x4010B3B")]
		[FieldOffset(Offset = "0x1C")]
		public GameObject DotGo;

		[Token(Token = "0x4010B3C")]
		[FieldOffset(Offset = "0x20")]
		public UISprite DotSprite;

		[Token(Token = "0x6012124")]
		[Address(RVA = "0x279355C", Offset = "0x279355C", VA = "0x279355C")]
		public SideRecItem()
		{
		}
	}

	[Token(Token = "0x2002BB3")]
	private sealed class _003CRequestData_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4010B3D")]
		[FieldOffset(Offset = "0x8")]
		internal UIUGCRecommendationController _0024this;

		[Token(Token = "0x4010B3E")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4010B3F")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x4010B40")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170012FB")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6012127")]
			[Address(RVA = "0x2795CC8", Offset = "0x2795CC8", VA = "0x2795CC8", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170012FC")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6012128")]
			[Address(RVA = "0x2795CD0", Offset = "0x2795CD0", VA = "0x2795CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6012125")]
		[Address(RVA = "0x2791D4C", Offset = "0x2791D4C", VA = "0x2791D4C")]
		public _003CRequestData_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6012126")]
		[Address(RVA = "0x2795B2C", Offset = "0x2795B2C", VA = "0x2795B2C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6012129")]
		[Address(RVA = "0x2795CD8", Offset = "0x2795CD8", VA = "0x2795CD8", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x601212A")]
		[Address(RVA = "0x2795CEC", Offset = "0x2795CEC", VA = "0x2795CEC", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2002BB4")]
	private sealed class _003COnCenterChild_003Ec__AnonStorey2
	{
		[Token(Token = "0x4010B41")]
		[FieldOffset(Offset = "0x8")]
		internal GameObject centerGo;

		[Token(Token = "0x601212B")]
		[Address(RVA = "0x27920F8", Offset = "0x27920F8", VA = "0x27920F8")]
		public _003COnCenterChild_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x601212C")]
		[Address(RVA = "0x27951B0", Offset = "0x27951B0", VA = "0x27951B0")]
		internal bool _003C_003Em__0(SideRecItem e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002BB5")]
	private sealed class _003CProcessSideRecItem_003Ec__AnonStorey3
	{
		[Token(Token = "0x4010B42")]
		[FieldOffset(Offset = "0x8")]
		internal SideRecItem item;

		[Token(Token = "0x4010B43")]
		[FieldOffset(Offset = "0xC")]
		internal WorkshopEditorChoiceDesc data;

		[Token(Token = "0x601212D")]
		[Address(RVA = "0x27938F0", Offset = "0x27938F0", VA = "0x27938F0")]
		public _003CProcessSideRecItem_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x601212E")]
		[Address(RVA = "0x2795254", Offset = "0x2795254", VA = "0x2795254")]
		internal void _003C_003Em__0()
		{
		}

		[Token(Token = "0x601212F")]
		[Address(RVA = "0x279534C", Offset = "0x279534C", VA = "0x279534C")]
		internal void _003C_003Em__1()
		{
		}
	}

	[Token(Token = "0x2002BB6")]
	private sealed class _003CReposition_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4010B44")]
		[FieldOffset(Offset = "0x8")]
		internal UIUGCRecommendationController _0024this;

		[Token(Token = "0x4010B45")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4010B46")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x4010B47")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170012FD")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6012132")]
			[Address(RVA = "0x2795A80", Offset = "0x2795A80", VA = "0x2795A80", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170012FE")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6012133")]
			[Address(RVA = "0x2795A88", Offset = "0x2795A88", VA = "0x2795A88", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6012130")]
		[Address(RVA = "0x2793D78", Offset = "0x2793D78", VA = "0x2793D78")]
		public _003CReposition_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x6012131")]
		[Address(RVA = "0x2795914", Offset = "0x2795914", VA = "0x2795914", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6012134")]
		[Address(RVA = "0x2795A90", Offset = "0x2795A90", VA = "0x2795A90", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6012135")]
		[Address(RVA = "0x2795AA4", Offset = "0x2795AA4", VA = "0x2795AA4", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4010B29")]
	[FieldOffset(Offset = "0x28")]
	private UIUGCRecommendationView m_View;

	[Token(Token = "0x4010B2A")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelSceneEdit m_Model;

	[Token(Token = "0x4010B2B")]
	[FieldOffset(Offset = "0x30")]
	private bool m_HasInited;

	[Token(Token = "0x4010B2C")]
	[FieldOffset(Offset = "0x31")]
	private bool m_SelfdomMapSwitch;

	[Token(Token = "0x4010B2D")]
	[FieldOffset(Offset = "0x32")]
	private bool m_HasEditorRec;

	[Token(Token = "0x4010B2E")]
	[FieldOffset(Offset = "0x34")]
	private List<UISceneEditRecommendMapItemController> m_CachedSelfdomMapItemList;

	[Token(Token = "0x4010B2F")]
	[FieldOffset(Offset = "0x38")]
	private List<UIUGCHotMapController> m_CachedHotMapItemList;

	[Token(Token = "0x4010B30")]
	[FieldOffset(Offset = "0x3C")]
	private WorkshopEditorChoiceDesc m_MainEditorChoiceDesc;

	[Token(Token = "0x4010B31")]
	[FieldOffset(Offset = "0x40")]
	private List<WorkshopEditorChoiceDesc> m_SideEditorChiceDescList;

	[Token(Token = "0x4010B32")]
	[FieldOffset(Offset = "0x44")]
	private int m_CurSideItemIndex;

	[Token(Token = "0x4010B33")]
	[FieldOffset(Offset = "0x48")]
	private List<SideRecItem> m_CachedSideRecItemList;

	[Token(Token = "0x4010B34")]
	[FieldOffset(Offset = "0x4C")]
	private float m_TimeElapsed;

	[Token(Token = "0x4010B35")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<WorkshopEditorChoiceDesc> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x601210C")]
	[Address(RVA = "0x279100C", Offset = "0x279100C", VA = "0x279100C")]
	public UIUGCRecommendationController()
	{
	}

	[Token(Token = "0x601210D")]
	[Address(RVA = "0x2791160", Offset = "0x2791160", VA = "0x2791160")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601210E")]
	[Address(RVA = "0x2791208", Offset = "0x2791208", VA = "0x2791208", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601210F")]
	[Address(RVA = "0x2791C80", Offset = "0x2791C80", VA = "0x2791C80")]
	private IEnumerator RequestData()
	{
		return null;
	}

	[Token(Token = "0x6012110")]
	[Address(RVA = "0x2791D54", Offset = "0x2791D54", VA = "0x2791D54", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x6012111")]
	[Address(RVA = "0x2791F3C", Offset = "0x2791F3C", VA = "0x2791F3C")]
	private void OnCenterChild(GameObject centerGo)
	{
	}

	[Token(Token = "0x6012112")]
	[Address(RVA = "0x2792100", Offset = "0x2792100", VA = "0x2792100")]
	private void RefreshDot()
	{
	}

	[Token(Token = "0x6012113")]
	[Address(RVA = "0x27922F4", Offset = "0x27922F4", VA = "0x27922F4")]
	private void RefreshRecommendationInfo()
	{
	}

	[Token(Token = "0x6012114")]
	[Address(RVA = "0x2793564", Offset = "0x2793564", VA = "0x2793564")]
	private void ProcessSideRecItem(SideRecItem item, WorkshopEditorChoiceDesc data)
	{
	}

	[Token(Token = "0x6012115")]
	[Address(RVA = "0x27938F8", Offset = "0x27938F8", VA = "0x27938F8")]
	private void RefreshSelfdomRecommendMapItems(List<WorkshopPersonalRecommendationInfo> mapDataList)
	{
	}

	[Token(Token = "0x6012116")]
	[Address(RVA = "0x2791E70", Offset = "0x2791E70", VA = "0x2791E70")]
	private IEnumerator Reposition()
	{
		return null;
	}

	[Token(Token = "0x6012117")]
	[Address(RVA = "0x279187C", Offset = "0x279187C", VA = "0x279187C")]
	private bool CheckRecommendMapSwitch()
	{
		return default(bool);
	}

	[Token(Token = "0x6012118")]
	[Address(RVA = "0x2793D80", Offset = "0x2793D80", VA = "0x2793D80")]
	private void Update()
	{
	}

	[Token(Token = "0x6012119")]
	[Address(RVA = "0x2793FB8", Offset = "0x2793FB8", VA = "0x2793FB8")]
	private void OnMainRecMoreBtnClick()
	{
	}

	[Token(Token = "0x601211A")]
	[Address(RVA = "0x2794600", Offset = "0x2794600", VA = "0x2794600")]
	private void OnHotMoreBtnClick()
	{
	}

	[Token(Token = "0x601211B")]
	[Address(RVA = "0x2794874", Offset = "0x2794874", VA = "0x2794874")]
	private void OnRecomRefreshBtnClick()
	{
	}

	[Token(Token = "0x601211C")]
	[Address(RVA = "0x2794950", Offset = "0x2794950", VA = "0x2794950")]
	private void OnSelfdomMoreBtnClick()
	{
	}

	[Token(Token = "0x601211D")]
	[Address(RVA = "0x2794BC4", Offset = "0x2794BC4", VA = "0x2794BC4", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x601211E")]
	[Address(RVA = "0x2794FA0", Offset = "0x2794FA0", VA = "0x2794FA0", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x601211F")]
	[Address(RVA = "0x2795034", Offset = "0x2795034", VA = "0x2795034")]
	private void _003COnUIInit_003Em__0()
	{
	}

	[Token(Token = "0x6012120")]
	[Address(RVA = "0x2795078", Offset = "0x2795078", VA = "0x2795078")]
	private static int _003CRefreshRecommendationInfo_003Em__1(WorkshopEditorChoiceDesc a, WorkshopEditorChoiceDesc b)
	{
		return default(int);
	}

	[Token(Token = "0x6012121")]
	[Address(RVA = "0x27950C0", Offset = "0x27950C0", VA = "0x27950C0")]
	private void _003CRefreshRecommendationInfo_003Em__2()
	{
	}

	[Token(Token = "0x6012122")]
	[Address(RVA = "0x27951A0", Offset = "0x27951A0", VA = "0x27951A0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6012123")]
	[Address(RVA = "0x27951A8", Offset = "0x27951A8", VA = "0x27951A8")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
