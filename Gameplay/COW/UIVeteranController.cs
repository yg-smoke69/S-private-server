using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002BCD")]
internal class UIVeteranController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x2002BCE")]
	public enum ETab
	{
		[Token(Token = "0x4010BB5")]
		Signin,
		[Token(Token = "0x4010BB6")]
		Task,
		[Token(Token = "0x4010BB7")]
		Bundle
	}

	[Token(Token = "0x2002BCF")]
	public class TabData
	{
		[Token(Token = "0x4010BB8")]
		[FieldOffset(Offset = "0x8")]
		public ETab m_Tab;

		[Token(Token = "0x4010BB9")]
		[FieldOffset(Offset = "0xC")]
		public string m_Title;

		[Token(Token = "0x4010BBA")]
		[FieldOffset(Offset = "0x10")]
		public ETipsType m_RedDot;

		[Token(Token = "0x4010BBB")]
		[FieldOffset(Offset = "0x14")]
		public Func<UIBaseController> m_OnSelect;

		[Token(Token = "0x6012208")]
		[Address(RVA = "0x28464DC", Offset = "0x28464DC", VA = "0x28464DC")]
		public TabData()
		{
		}
	}

	[Token(Token = "0x2002BD0")]
	private sealed class _003CCreateTabs_003Ec__AnonStorey0
	{
		[Token(Token = "0x4010BBC")]
		[FieldOffset(Offset = "0x8")]
		internal TabData data;

		[Token(Token = "0x4010BBD")]
		[FieldOffset(Offset = "0xC")]
		internal UIVeteranController _0024this;

		[Token(Token = "0x6012209")]
		[Address(RVA = "0x2846A20", Offset = "0x2846A20", VA = "0x2846A20")]
		public _003CCreateTabs_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x601220A")]
		[Address(RVA = "0x2847584", Offset = "0x2847584", VA = "0x2847584")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2002BD1")]
	private sealed class _003COnSelectTab_003Ec__AnonStorey1
	{
		[Token(Token = "0x4010BBE")]
		[FieldOffset(Offset = "0x8")]
		internal ETab tab;

		[Token(Token = "0x601220B")]
		[Address(RVA = "0x2846FD4", Offset = "0x2846FD4", VA = "0x2846FD4")]
		public _003COnSelectTab_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x601220C")]
		[Address(RVA = "0x28475C8", Offset = "0x28475C8", VA = "0x28475C8")]
		internal bool _003C_003Em__0(TabData temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4010BAE")]
	[FieldOffset(Offset = "0x48")]
	private UIVeteranView m_View;

	[Token(Token = "0x4010BAF")]
	[FieldOffset(Offset = "0x4C")]
	private List<TabData> m_TaskDatas;

	[Token(Token = "0x4010BB0")]
	[FieldOffset(Offset = "0x50")]
	private Dictionary<int, UIBaseController> m_CtrlDict;

	[Token(Token = "0x4010BB1")]
	[FieldOffset(Offset = "0x54")]
	private Dictionary<int, UIToggleButton> m_TabDict;

	[Token(Token = "0x4010BB2")]
	[FieldOffset(Offset = "0x58")]
	private UIModelVeteranSignin m_Model;

	[Token(Token = "0x4010BB3")]
	[FieldOffset(Offset = "0x5C")]
	private UIModelVeteranBundle m_BundleModel;

	[Token(Token = "0x60121F8")]
	[Address(RVA = "0x2845A04", Offset = "0x2845A04", VA = "0x2845A04")]
	public UIVeteranController()
	{
	}

	[Token(Token = "0x60121F9")]
	[Address(RVA = "0x2845AF8", Offset = "0x2845AF8", VA = "0x2845AF8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60121FA")]
	[Address(RVA = "0x2845B9C", Offset = "0x2845B9C", VA = "0x2845B9C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60121FB")]
	[Address(RVA = "0x2846934", Offset = "0x2846934", VA = "0x2846934", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60121FC")]
	[Address(RVA = "0x28469BC", Offset = "0x28469BC", VA = "0x28469BC")]
	private void OnClickClose()
	{
	}

	[Token(Token = "0x60121FD")]
	[Address(RVA = "0x28464E4", Offset = "0x28464E4", VA = "0x28464E4")]
	private void CreateTabs(TabData data)
	{
	}

	[Token(Token = "0x60121FE")]
	[Address(RVA = "0x2846A28", Offset = "0x2846A28", VA = "0x2846A28")]
	public void GotoTab(ETab tab)
	{
	}

	[Token(Token = "0x60121FF")]
	[Address(RVA = "0x2846B60", Offset = "0x2846B60", VA = "0x2846B60")]
	private void OnSelectTab(ETab tab)
	{
	}

	[Token(Token = "0x6012200")]
	[Address(RVA = "0x2846FDC", Offset = "0x2846FDC", VA = "0x2846FDC", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6012201")]
	[Address(RVA = "0x2847070", Offset = "0x2847070", VA = "0x2847070", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6012202")]
	[Address(RVA = "0x284713C", Offset = "0x284713C", VA = "0x284713C")]
	private void UpdateTime()
	{
	}

	[Token(Token = "0x6012203")]
	[Address(RVA = "0x28472E0", Offset = "0x28472E0", VA = "0x28472E0")]
	private UIBaseController _003COnUIInit_003Em__0()
	{
		return null;
	}

	[Token(Token = "0x6012204")]
	[Address(RVA = "0x2847394", Offset = "0x2847394", VA = "0x2847394")]
	private UIBaseController _003COnUIInit_003Em__1()
	{
		return null;
	}

	[Token(Token = "0x6012205")]
	[Address(RVA = "0x2847448", Offset = "0x2847448", VA = "0x2847448")]
	private void _003CUpdateTime_003Em__2()
	{
	}

	[Token(Token = "0x6012206")]
	[Address(RVA = "0x2847574", Offset = "0x2847574", VA = "0x2847574")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6012207")]
	[Address(RVA = "0x284757C", Offset = "0x284757C", VA = "0x284757C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
