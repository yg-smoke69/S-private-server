using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x200234C")]
public class UISceneEditHistoryInfoController : UIBaseController, _Attribute
{
	[Token(Token = "0x200234D")]
	private sealed class _003CRequestData_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400DBEE")]
		[FieldOffset(Offset = "0x8")]
		internal UISceneEditHistoryInfoController _0024this;

		[Token(Token = "0x400DBEF")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400DBF0")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400DBF1")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170010C6")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600C4AF")]
			[Address(RVA = "0x2D9C460", Offset = "0x2D9C460", VA = "0x2D9C460", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170010C7")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600C4B0")]
			[Address(RVA = "0x2D9C468", Offset = "0x2D9C468", VA = "0x2D9C468", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600C4AD")]
		[Address(RVA = "0x2D9A620", Offset = "0x2D9A620", VA = "0x2D9A620")]
		public _003CRequestData_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600C4AE")]
		[Address(RVA = "0x2D9C05C", Offset = "0x2D9C05C", VA = "0x2D9C05C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600C4B1")]
		[Address(RVA = "0x2D9C470", Offset = "0x2D9C470", VA = "0x2D9C470", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600C4B2")]
		[Address(RVA = "0x2D9C484", Offset = "0x2D9C484", VA = "0x2D9C484", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400DBE4")]
	[FieldOffset(Offset = "0x28")]
	private UISceneEditHistoryInfoView m_View;

	[Token(Token = "0x400DBE5")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelSceneEdit m_Model;

	[Token(Token = "0x400DBE6")]
	[FieldOffset(Offset = "0x30")]
	private bool m_HasLatestPlayerdRequested;

	[Token(Token = "0x400DBE7")]
	[FieldOffset(Offset = "0x34")]
	private List<WorkshopLatestInfo> m_WorkshopLatestInfoList;

	[Token(Token = "0x400DBE8")]
	[FieldOffset(Offset = "0x38")]
	private bool m_HasHistoryPlayerdRequested;

	[Token(Token = "0x400DBE9")]
	[FieldOffset(Offset = "0x3C")]
	private List<WorkshopHistoryInfo> m_WorkshopHistoryInfoList;

	[Token(Token = "0x400DBEA")]
	[FieldOffset(Offset = "0x40")]
	private List<UISceneEditHistoryTemplateView> m_CachedHistoryViewList;

	[Token(Token = "0x400DBEB")]
	[FieldOffset(Offset = "0x44")]
	private int m_ItemWidth;

	[Token(Token = "0x400DBEC")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<WorkshopLatestInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400DBED")]
	[FieldOffset(Offset = "0x4")]
	private static Comparison<WorkshopHistoryInfo> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x600C49E")]
	[Address(RVA = "0x2D9A048", Offset = "0x2D9A048", VA = "0x2D9A048")]
	public UISceneEditHistoryInfoController()
	{
	}

	[Token(Token = "0x600C49F")]
	[Address(RVA = "0x2D9A168", Offset = "0x2D9A168", VA = "0x2D9A168")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C4A0")]
	[Address(RVA = "0x2D9A20C", Offset = "0x2D9A20C", VA = "0x2D9A20C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C4A1")]
	[Address(RVA = "0x2D9A4C8", Offset = "0x2D9A4C8", VA = "0x2D9A4C8", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600C4A2")]
	[Address(RVA = "0x2D9A554", Offset = "0x2D9A554", VA = "0x2D9A554")]
	private IEnumerator RequestData()
	{
		return null;
	}

	[Token(Token = "0x600C4A3")]
	[Address(RVA = "0x2D9A628", Offset = "0x2D9A628", VA = "0x2D9A628")]
	private void OnLatestPlayedBtnClick()
	{
	}

	[Token(Token = "0x600C4A4")]
	[Address(RVA = "0x2D9A6B8", Offset = "0x2D9A6B8", VA = "0x2D9A6B8")]
	private void RefreshLatestInfo()
	{
	}

	[Token(Token = "0x600C4A5")]
	[Address(RVA = "0x2D9B098", Offset = "0x2D9B098", VA = "0x2D9B098")]
	private void OnHistoryPlayedBtnClick()
	{
	}

	[Token(Token = "0x600C4A6")]
	[Address(RVA = "0x2D9B128", Offset = "0x2D9B128", VA = "0x2D9B128")]
	private void RefreshHistoryInfo()
	{
	}

	[Token(Token = "0x600C4A7")]
	[Address(RVA = "0x2D9BA70", Offset = "0x2D9BA70", VA = "0x2D9BA70", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600C4A8")]
	[Address(RVA = "0x2D9BF14", Offset = "0x2D9BF14", VA = "0x2D9BF14", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600C4A9")]
	[Address(RVA = "0x2D9BFA8", Offset = "0x2D9BFA8", VA = "0x2D9BFA8")]
	private static int _003COnDataChanged_003Em__0(WorkshopLatestInfo a, WorkshopLatestInfo b)
	{
		return default(int);
	}

	[Token(Token = "0x600C4AA")]
	[Address(RVA = "0x2D9C000", Offset = "0x2D9C000", VA = "0x2D9C000")]
	private static int _003COnDataChanged_003Em__1(WorkshopHistoryInfo a, WorkshopHistoryInfo b)
	{
		return default(int);
	}

	[Token(Token = "0x600C4AB")]
	[Address(RVA = "0x2D9C04C", Offset = "0x2D9C04C", VA = "0x2D9C04C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C4AC")]
	[Address(RVA = "0x2D9C054", Offset = "0x2D9C054", VA = "0x2D9C054")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
