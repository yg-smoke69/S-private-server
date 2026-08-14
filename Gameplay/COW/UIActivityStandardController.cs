using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2001F79")]
public class UIActivityStandardController : UIActivityBaseController, _Attribute
{
	[Token(Token = "0x2001F7A")]
	private sealed class _003CSelectItem_003Ec__AnonStorey0
	{
		[Token(Token = "0x400C5B1")]
		[FieldOffset(Offset = "0x8")]
		internal uint id;

		[Token(Token = "0x6009C77")]
		[Address(RVA = "0x1F266D4", Offset = "0x1F266D4", VA = "0x1F266D4")]
		public _003CSelectItem_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6009C78")]
		[Address(RVA = "0x1F28744", Offset = "0x1F28744", VA = "0x1F28744")]
		internal bool _003C_003Em__0(ActivityGroupDesc e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2001F7B")]
	private sealed class _003CCreateThirdTabs_003Ec__AnonStorey1
	{
		[Token(Token = "0x400C5B2")]
		[FieldOffset(Offset = "0x8")]
		internal int tempIndex;

		[Token(Token = "0x400C5B3")]
		[FieldOffset(Offset = "0xC")]
		internal UIActivityStandardController _0024this;

		[Token(Token = "0x6009C79")]
		[Address(RVA = "0x1F2776C", Offset = "0x1F2776C", VA = "0x1F2776C")]
		public _003CCreateThirdTabs_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6009C7A")]
		[Address(RVA = "0x1F284F0", Offset = "0x1F284F0", VA = "0x1F284F0")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2001F7C")]
	private sealed class _003COpenLargeContent_003Ec__AnonStorey2
	{
		[Token(Token = "0x400C5B4")]
		[FieldOffset(Offset = "0x8")]
		internal ActivityGroupDesc desc;

		[Token(Token = "0x6009C7B")]
		[Address(RVA = "0x1F27D54", Offset = "0x1F27D54", VA = "0x1F27D54")]
		public _003COpenLargeContent_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x6009C7C")]
		[Address(RVA = "0x1F28558", Offset = "0x1F28558", VA = "0x1F28558")]
		internal bool _003C_003Em__0(AdvertDesc e)
		{
			return default(bool);
		}

		[Token(Token = "0x6009C7D")]
		[Address(RVA = "0x1F28628", Offset = "0x1F28628", VA = "0x1F28628")]
		internal bool _003C_003Em__1(AdvertDesc e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2001F7D")]
	private sealed class _003COpenLargeContent_003Ec__AnonStorey3
	{
		[Token(Token = "0x400C5B5")]
		[FieldOffset(Offset = "0x8")]
		internal ClientActivityDesc act;

		[Token(Token = "0x6009C7E")]
		[Address(RVA = "0x1F27D5C", Offset = "0x1F27D5C", VA = "0x1F27D5C")]
		public _003COpenLargeContent_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x6009C7F")]
		[Address(RVA = "0x1F286F8", Offset = "0x1F286F8", VA = "0x1F286F8")]
		internal bool _003C_003Em__0(AdvertDesc e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2001F7E")]
	private sealed class _003COnDataChanged_003Ec__AnonStorey4
	{
		[Token(Token = "0x400C5B6")]
		[FieldOffset(Offset = "0x8")]
		internal uint activityId;

		[Token(Token = "0x6009C80")]
		[Address(RVA = "0x1F280AC", Offset = "0x1F280AC", VA = "0x1F280AC")]
		public _003COnDataChanged_003Ec__AnonStorey4()
		{
		}

		[Token(Token = "0x6009C81")]
		[Address(RVA = "0x1F28520", Offset = "0x1F28520", VA = "0x1F28520")]
		internal bool _003C_003Em__0(ClientActivityDesc temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400C5A3")]
	[FieldOffset(Offset = "0x28")]
	private UIActivityStandardView m_View;

	[Token(Token = "0x400C5A4")]
	[FieldOffset(Offset = "0x2C")]
	private List<ActivityGroupDesc> m_GroupDescs;

	[Token(Token = "0x400C5A5")]
	[FieldOffset(Offset = "0x30")]
	private ActivityGroupDesc m_SelectedGroup;

	[Token(Token = "0x400C5A6")]
	[FieldOffset(Offset = "0x34")]
	private ActivityGroupDesc m_LastEaterGroup;

	[Token(Token = "0x400C5A7")]
	[FieldOffset(Offset = "0x38")]
	private UIActivityCollectionEventController m_LastEasterContent;

	[Token(Token = "0x400C5A8")]
	[FieldOffset(Offset = "0x3C")]
	private UIActivityContentController m_Content;

	[Token(Token = "0x400C5A9")]
	[FieldOffset(Offset = "0x40")]
	private UIModelActivity m_ModelActivity;

	[Token(Token = "0x400C5AA")]
	[FieldOffset(Offset = "0x44")]
	private ActivityGroupDesc m_GroupDesc;

	[Token(Token = "0x400C5AB")]
	[FieldOffset(Offset = "0x48")]
	private List<UIToggleButton> m_ThirdToggles;

	[Token(Token = "0x400C5AC")]
	[FieldOffset(Offset = "0x4C")]
	private UIGrid m_ThirdTabsGrid;

	[Token(Token = "0x400C5AD")]
	[FieldOffset(Offset = "0x50")]
	private Dictionary<uint, GameObject> m_ThirdTabTipsDict;

	[Token(Token = "0x400C5AE")]
	[FieldOffset(Offset = "0x54")]
	private int m_ADWidth;

	[Token(Token = "0x400C5AF")]
	[FieldOffset(Offset = "0x58")]
	private List<StandardTabItemViewData> m_TabDataList;

	[Token(Token = "0x400C5B0")]
	[FieldOffset(Offset = "0x5C")]
	private UIStandardTabController m_TabCtrl;

	[Token(Token = "0x6009C50")]
	[Address(RVA = "0x1F22C14", Offset = "0x1F22C14", VA = "0x1F22C14")]
	public UIActivityStandardController()
	{
	}

	[Token(Token = "0x6009C51")]
	[Address(RVA = "0x1F22D3C", Offset = "0x1F22D3C", VA = "0x1F22D3C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009C52")]
	[Address(RVA = "0x1F22DE0", Offset = "0x1F22DE0", VA = "0x1F22DE0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009C53")]
	[Address(RVA = "0x1F23018", Offset = "0x1F23018", VA = "0x1F23018", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6009C54")]
	[Address(RVA = "0x1F230A0", Offset = "0x1F230A0", VA = "0x1F230A0", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x6009C55")]
	[Address(RVA = "0x1F23104", Offset = "0x1F23104", VA = "0x1F23104")]
	public void ActivityGroupSelected(int descIndex)
	{
	}

	[Token(Token = "0x6009C56")]
	[Address(RVA = "0x1F259E0", Offset = "0x1F259E0", VA = "0x1F259E0", Slot = "31")]
	public override void SetData(object data)
	{
	}

	[Token(Token = "0x6009C57")]
	[Address(RVA = "0x1F2639C", Offset = "0x1F2639C", VA = "0x1F2639C")]
	public void UpdateTabData(int tabIndex)
	{
	}

	[Token(Token = "0x6009C58")]
	[Address(RVA = "0x1F26560", Offset = "0x1F26560", VA = "0x1F26560", Slot = "32")]
	public override void SelectItem(uint id)
	{
	}

	[Token(Token = "0x6009C59")]
	[Address(RVA = "0x1F266DC", Offset = "0x1F266DC", VA = "0x1F266DC", Slot = "33")]
	public override void OnPanelDepthChanged()
	{
	}

	[Token(Token = "0x6009C5A")]
	[Address(RVA = "0x1F267EC", Offset = "0x1F267EC", VA = "0x1F267EC")]
	public void SetAD(string url)
	{
	}

	[Token(Token = "0x6009C5B")]
	[Address(RVA = "0x1F26918", Offset = "0x1F26918", VA = "0x1F26918")]
	private void OnDownloadFinish()
	{
	}

	[Token(Token = "0x6009C5C")]
	[Address(RVA = "0x1F26B10", Offset = "0x1F26B10", VA = "0x1F26B10", Slot = "34")]
	public override void Reload()
	{
	}

	[Token(Token = "0x6009C5D")]
	[Address(RVA = "0x1F27198", Offset = "0x1F27198", VA = "0x1F27198")]
	public void UpdateSideGroup(uint groupId)
	{
	}

	[Token(Token = "0x6009C5E")]
	[Address(RVA = "0x1F23764", Offset = "0x1F23764", VA = "0x1F23764")]
	private void UpdateIntroData(ActivityGroupDesc data)
	{
	}

	[Token(Token = "0x6009C5F")]
	[Address(RVA = "0x1F26DF4", Offset = "0x1F26DF4", VA = "0x1F26DF4")]
	private void UpdateActivityInfo()
	{
	}

	[Token(Token = "0x6009C60")]
	[Address(RVA = "0x1F24B6C", Offset = "0x1F24B6C", VA = "0x1F24B6C")]
	private void CreateThirdTabs()
	{
	}

	[Token(Token = "0x6009C61")]
	[Address(RVA = "0x1F27470", Offset = "0x1F27470", VA = "0x1F27470")]
	private void UpdateThirdTabsTips()
	{
	}

	[Token(Token = "0x6009C62")]
	[Address(RVA = "0x1F25878", Offset = "0x1F25878", VA = "0x1F25878")]
	private void OnThirdTabSelected(int index)
	{
	}

	[Token(Token = "0x6009C63")]
	[Address(RVA = "0x1F27774", Offset = "0x1F27774", VA = "0x1F27774")]
	private UIActivityContentController OpenThirdTabContent(int index, out object data)
	{
		return null;
	}

	[Token(Token = "0x6009C64")]
	[Address(RVA = "0x1F23E78", Offset = "0x1F23E78", VA = "0x1F23E78")]
	private UIActivityContentController OpenLargeContent(ActivityGroupDesc desc, out object data)
	{
		return null;
	}

	[Token(Token = "0x6009C65")]
	[Address(RVA = "0x1F27D64", Offset = "0x1F27D64", VA = "0x1F27D64", Slot = "37")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6009C66")]
	[Address(RVA = "0x1F280B4", Offset = "0x1F280B4", VA = "0x1F280B4", Slot = "38")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6009C67")]
	[Address(RVA = "0x1F235A0", Offset = "0x1F235A0", VA = "0x1F235A0")]
	private void CloseOldContent()
	{
	}

	[Token(Token = "0x6009C68")]
	[Address(RVA = "0x1F28148", Offset = "0x1F28148", VA = "0x1F28148", Slot = "36")]
	public override void OnVisibilityChange(bool isVisible)
	{
	}

	[Token(Token = "0x6009C69")]
	[Address(RVA = "0x1F281B8", Offset = "0x1F281B8", VA = "0x1F281B8", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x6009C6A")]
	[Address(RVA = "0x1F282E8", Offset = "0x1F282E8", VA = "0x1F282E8", Slot = "35")]
	public override void OnPopUpWindowListChange(bool isCovered)
	{
	}

	[Token(Token = "0x6009C6B")]
	[Address(RVA = "0x1F28408", Offset = "0x1F28408", VA = "0x1F28408")]
	private bool _003CReload_003Em__0(ActivityGroupDesc e)
	{
		return default(bool);
	}

	[Token(Token = "0x6009C6C")]
	[Address(RVA = "0x1F28454", Offset = "0x1F28454", VA = "0x1F28454")]
	private bool _003CUpdateSideGroup_003Em__1(ActivityGroupDesc e)
	{
		return default(bool);
	}

	[Token(Token = "0x6009C6D")]
	[Address(RVA = "0x1F284A0", Offset = "0x1F284A0", VA = "0x1F284A0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009C6E")]
	[Address(RVA = "0x1F284A8", Offset = "0x1F284A8", VA = "0x1F284A8")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x6009C6F")]
	[Address(RVA = "0x1F284B0", Offset = "0x1F284B0", VA = "0x1F284B0")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x6009C70")]
	[Address(RVA = "0x1F284B8", Offset = "0x1F284B8", VA = "0x1F284B8")]
	public void _003C_003EiFixBaseProxy_SetData(object P0)
	{
	}

	[Token(Token = "0x6009C71")]
	[Address(RVA = "0x1F284C0", Offset = "0x1F284C0", VA = "0x1F284C0")]
	public void _003C_003EiFixBaseProxy_SelectItem(uint P0)
	{
	}

	[Token(Token = "0x6009C72")]
	[Address(RVA = "0x1F284C8", Offset = "0x1F284C8", VA = "0x1F284C8")]
	public void _003C_003EiFixBaseProxy_OnPanelDepthChanged()
	{
	}

	[Token(Token = "0x6009C73")]
	[Address(RVA = "0x1F284D0", Offset = "0x1F284D0", VA = "0x1F284D0")]
	public void _003C_003EiFixBaseProxy_Reload()
	{
	}

	[Token(Token = "0x6009C74")]
	[Address(RVA = "0x1F284D8", Offset = "0x1F284D8", VA = "0x1F284D8")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChange(bool P0)
	{
	}

	[Token(Token = "0x6009C75")]
	[Address(RVA = "0x1F284E0", Offset = "0x1F284E0", VA = "0x1F284E0")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x6009C76")]
	[Address(RVA = "0x1F284E8", Offset = "0x1F284E8", VA = "0x1F284E8")]
	public void _003C_003EiFixBaseProxy_OnPopUpWindowListChange(bool P0)
	{
	}
}
