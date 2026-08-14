using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200297B")]
public class UIManualMainTabController
{
	[Token(Token = "0x200297C")]
	public enum EMainTab
	{
		[Token(Token = "0x400FF97")]
		Map,
		[Token(Token = "0x400FF98")]
		Weapon,
		[Token(Token = "0x400FF99")]
		Grow
	}

	[Token(Token = "0x200297D")]
	private sealed class _003CCreateDrawerTab_003Ec__AnonStorey0
	{
		[Token(Token = "0x400FF9A")]
		[FieldOffset(Offset = "0x8")]
		internal StandardTabItemViewData tabItem;

		[Token(Token = "0x400FF9B")]
		[FieldOffset(Offset = "0xC")]
		internal UIManualMainTabController _0024this;

		[Token(Token = "0x6010A67")]
		[Address(RVA = "0x2C29288", Offset = "0x2C29288", VA = "0x2C29288")]
		public _003CCreateDrawerTab_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6010A68")]
		[Address(RVA = "0x2C2CFE8", Offset = "0x2C2CFE8", VA = "0x2C2CFE8")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x200297E")]
	private sealed class _003CCreateSubTabsData_003Ec__AnonStorey1
	{
		[Token(Token = "0x400FF9C")]
		[FieldOffset(Offset = "0x8")]
		internal StandardSubTabItemViewData tabItem;

		[Token(Token = "0x400FF9D")]
		[FieldOffset(Offset = "0xC")]
		internal UIManualMainTabController _0024this;

		[Token(Token = "0x6010A69")]
		[Address(RVA = "0x2C296D4", Offset = "0x2C296D4", VA = "0x2C296D4")]
		public _003CCreateSubTabsData_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6010A6A")]
		[Address(RVA = "0x2C2D0FC", Offset = "0x2C2D0FC", VA = "0x2C2D0FC")]
		internal void _003C_003Em__0()
		{
		}

		[Token(Token = "0x6010A6B")]
		[Address(RVA = "0x2C2D220", Offset = "0x2C2D220", VA = "0x2C2D220")]
		internal void _003C_003Em__1()
		{
		}
	}

	[Token(Token = "0x200297F")]
	private sealed class _003CPrepareGrowData_003Ec__AnonStorey3
	{
		[Token(Token = "0x400FF9E")]
		[FieldOffset(Offset = "0x8")]
		internal int tabCnt;

		[Token(Token = "0x400FF9F")]
		[FieldOffset(Offset = "0xC")]
		internal UIManualMainTabController _0024this;

		[Token(Token = "0x6010A6C")]
		[Address(RVA = "0x2C2B7F4", Offset = "0x2C2B7F4", VA = "0x2C2B7F4")]
		public _003CPrepareGrowData_003Ec__AnonStorey3()
		{
		}
	}

	[Token(Token = "0x2002980")]
	private sealed class _003CPrepareGrowData_003Ec__AnonStorey2
	{
		[Token(Token = "0x400FFA0")]
		[FieldOffset(Offset = "0x8")]
		internal int end;

		[Token(Token = "0x400FFA1")]
		[FieldOffset(Offset = "0xC")]
		internal int begin;

		[Token(Token = "0x400FFA2")]
		[FieldOffset(Offset = "0x10")]
		internal int tempIndex;

		[Token(Token = "0x400FFA3")]
		[FieldOffset(Offset = "0x14")]
		internal _003CPrepareGrowData_003Ec__AnonStorey3 _003C_003Ef__ref_00243;

		[Token(Token = "0x6010A6D")]
		[Address(RVA = "0x2C2B7FC", Offset = "0x2C2B7FC", VA = "0x2C2B7FC")]
		public _003CPrepareGrowData_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x6010A6E")]
		[Address(RVA = "0x2C2D250", Offset = "0x2C2D250", VA = "0x2C2D250")]
		internal bool _003C_003Em__0(LevelRewardData e)
		{
			return default(bool);
		}

		[Token(Token = "0x6010A6F")]
		[Address(RVA = "0x2C2D2A0", Offset = "0x2C2D2A0", VA = "0x2C2D2A0")]
		internal void _003C_003Em__1()
		{
		}

		[Token(Token = "0x6010A70")]
		[Address(RVA = "0x2C2D2E8", Offset = "0x2C2D2E8", VA = "0x2C2D2E8")]
		internal void _003C_003Em__2()
		{
		}

		[Token(Token = "0x6010A71")]
		[Address(RVA = "0x2C2D354", Offset = "0x2C2D354", VA = "0x2C2D354")]
		internal UIManualContentBaseController _003C_003Em__3()
		{
			return null;
		}
	}

	[Token(Token = "0x2002981")]
	private sealed class _003CPrepareMapData_003Ec__AnonStorey4
	{
		[Token(Token = "0x400FFA4")]
		[FieldOffset(Offset = "0x8")]
		internal int length;

		[Token(Token = "0x400FFA5")]
		[FieldOffset(Offset = "0xC")]
		internal UIManualMainTabController _0024this;

		[Token(Token = "0x6010A72")]
		[Address(RVA = "0x2C2B804", Offset = "0x2C2B804", VA = "0x2C2B804")]
		public _003CPrepareMapData_003Ec__AnonStorey4()
		{
		}

		[Token(Token = "0x6010A73")]
		[Address(RVA = "0x2C2D3AC", Offset = "0x2C2D3AC", VA = "0x2C2D3AC")]
		internal void _003C_003Em__0()
		{
		}

		[Token(Token = "0x6010A74")]
		[Address(RVA = "0x2C2D3D8", Offset = "0x2C2D3D8", VA = "0x2C2D3D8")]
		internal void _003C_003Em__1()
		{
		}

		[Token(Token = "0x6010A75")]
		[Address(RVA = "0x2C2D40C", Offset = "0x2C2D40C", VA = "0x2C2D40C")]
		internal UIManualContentBaseController _003C_003Em__2()
		{
			return null;
		}

		[Token(Token = "0x6010A76")]
		[Address(RVA = "0x2C2D450", Offset = "0x2C2D450", VA = "0x2C2D450")]
		internal void _003C_003Em__3()
		{
		}

		[Token(Token = "0x6010A77")]
		[Address(RVA = "0x2C2D47C", Offset = "0x2C2D47C", VA = "0x2C2D47C")]
		internal void _003C_003Em__4()
		{
		}

		[Token(Token = "0x6010A78")]
		[Address(RVA = "0x2C2D4B0", Offset = "0x2C2D4B0", VA = "0x2C2D4B0")]
		internal UIManualContentBaseController _003C_003Em__5()
		{
			return null;
		}

		[Token(Token = "0x6010A79")]
		[Address(RVA = "0x2C2D4F4", Offset = "0x2C2D4F4", VA = "0x2C2D4F4")]
		internal void _003C_003Em__6()
		{
		}

		[Token(Token = "0x6010A7A")]
		[Address(RVA = "0x2C2D520", Offset = "0x2C2D520", VA = "0x2C2D520")]
		internal void _003C_003Em__7()
		{
		}

		[Token(Token = "0x6010A7B")]
		[Address(RVA = "0x2C2D554", Offset = "0x2C2D554", VA = "0x2C2D554")]
		internal UIManualContentBaseController _003C_003Em__8()
		{
			return null;
		}

		[Token(Token = "0x6010A7C")]
		[Address(RVA = "0x2C2D598", Offset = "0x2C2D598", VA = "0x2C2D598")]
		internal void _003C_003Em__9()
		{
		}

		[Token(Token = "0x6010A7D")]
		[Address(RVA = "0x2C2D5C4", Offset = "0x2C2D5C4", VA = "0x2C2D5C4")]
		internal void _003C_003Em__A()
		{
		}

		[Token(Token = "0x6010A7E")]
		[Address(RVA = "0x2C2D5F8", Offset = "0x2C2D5F8", VA = "0x2C2D5F8")]
		internal UIManualContentBaseController _003C_003Em__B()
		{
			return null;
		}
	}

	[Token(Token = "0x2002982")]
	private sealed class _003CPrepareWeaponData_003Ec__AnonStorey6
	{
		[Token(Token = "0x400FFA6")]
		[FieldOffset(Offset = "0x8")]
		internal int length;

		[Token(Token = "0x400FFA7")]
		[FieldOffset(Offset = "0xC")]
		internal UIManualMainTabController _0024this;

		[Token(Token = "0x6010A7F")]
		[Address(RVA = "0x2C2B9DC", Offset = "0x2C2B9DC", VA = "0x2C2B9DC")]
		public _003CPrepareWeaponData_003Ec__AnonStorey6()
		{
		}
	}

	[Token(Token = "0x2002983")]
	private sealed class _003CPrepareWeaponData_003Ec__AnonStorey5
	{
		[Token(Token = "0x400FFA8")]
		[FieldOffset(Offset = "0x8")]
		internal int tempIndex;

		[Token(Token = "0x400FFA9")]
		[FieldOffset(Offset = "0xC")]
		internal _003CPrepareWeaponData_003Ec__AnonStorey6 _003C_003Ef__ref_00246;

		[Token(Token = "0x6010A80")]
		[Address(RVA = "0x2C2B9E4", Offset = "0x2C2B9E4", VA = "0x2C2B9E4")]
		public _003CPrepareWeaponData_003Ec__AnonStorey5()
		{
		}

		[Token(Token = "0x6010A81")]
		[Address(RVA = "0x2C2D63C", Offset = "0x2C2D63C", VA = "0x2C2D63C")]
		internal void _003C_003Em__0()
		{
		}

		[Token(Token = "0x6010A82")]
		[Address(RVA = "0x2C2D684", Offset = "0x2C2D684", VA = "0x2C2D684")]
		internal void _003C_003Em__1()
		{
		}

		[Token(Token = "0x6010A83")]
		[Address(RVA = "0x2C2D6F0", Offset = "0x2C2D6F0", VA = "0x2C2D6F0")]
		internal UIManualContentBaseController _003C_003Em__2()
		{
			return null;
		}
	}

	[Token(Token = "0x400FF8D")]
	[FieldOffset(Offset = "0x8")]
	private Dictionary<int, int> mainTabIndexDict;

	[Token(Token = "0x400FF8E")]
	[FieldOffset(Offset = "0xC")]
	private int curMainTab;

	[Token(Token = "0x400FF8F")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<int, List<StandardSubTabItemViewData>> subTabDataDict;

	[Token(Token = "0x400FF90")]
	[FieldOffset(Offset = "0x14")]
	private bool[] mainTabTagArray;

	[Token(Token = "0x400FF91")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<int, string> m_MainTabLabels;

	[Token(Token = "0x400FF92")]
	[FieldOffset(Offset = "0x18")]
	private List<StandardTabItemViewData> m_TabDataList;

	[Token(Token = "0x400FF93")]
	[FieldOffset(Offset = "0x1C")]
	private UIManualController m_ManualCtrl;

	[Token(Token = "0x400FF94")]
	[FieldOffset(Offset = "0x20")]
	private UIStandardDrawerTabController m_DrawerCtrl;

	[Token(Token = "0x400FF95")]
	[FieldOffset(Offset = "0x4")]
	private static Converter<CSVBaseData, LevelRewardData> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6010A55")]
	[Address(RVA = "0x2C28780", Offset = "0x2C28780", VA = "0x2C28780")]
	public UIManualMainTabController()
	{
	}

	[Token(Token = "0x6010A56")]
	[Address(RVA = "0x2C28898", Offset = "0x2C28898", VA = "0x2C28898")]
	private ETipsType GetTipsType(EMainTab tab)
	{
		return default(ETipsType);
	}

	[Token(Token = "0x6010A57")]
	[Address(RVA = "0x2C28914", Offset = "0x2C28914", VA = "0x2C28914")]
	private ETipsType GetNewTipsType(EMainTab tab)
	{
		return default(ETipsType);
	}

	[Token(Token = "0x6010A58")]
	[Address(RVA = "0x2C28990", Offset = "0x2C28990", VA = "0x2C28990")]
	public void CreateDrawerTab(UIStandardDrawerTabController drawerTabCtrl, UIManualController parentCtrl)
	{
	}

	[Token(Token = "0x6010A59")]
	[Address(RVA = "0x2C29290", Offset = "0x2C29290", VA = "0x2C29290")]
	private List<StandardSubTabItemViewData> CreateSubTabsData(EMainTab type)
	{
		return null;
	}

	[Token(Token = "0x6010A5A")]
	[Address(RVA = "0x2C296DC", Offset = "0x2C296DC", VA = "0x2C296DC")]
	public void OnSubTabClick(UIManualDataBase data)
	{
	}

	[Token(Token = "0x6010A5B")]
	[Address(RVA = "0x2C297BC", Offset = "0x2C297BC", VA = "0x2C297BC")]
	private void DoLog(UIManualDataBase data)
	{
	}

	[Token(Token = "0x6010A5C")]
	[Address(RVA = "0x2C29B54", Offset = "0x2C29B54", VA = "0x2C29B54")]
	private void DoLog(EMainTab tabType)
	{
	}

	[Token(Token = "0x6010A5D")]
	[Address(RVA = "0x2C295AC", Offset = "0x2C295AC", VA = "0x2C295AC")]
	private List<UIManualDataBase> GetSubTabData(EMainTab type)
	{
		return null;
	}

	[Token(Token = "0x6010A5E")]
	[Address(RVA = "0x2C29E24", Offset = "0x2C29E24", VA = "0x2C29E24")]
	private void PrepareGrowData(out List<UIManualDataBase> dataList)
	{
	}

	[Token(Token = "0x6010A5F")]
	[Address(RVA = "0x2C2A57C", Offset = "0x2C2A57C", VA = "0x2C2A57C")]
	private void PrepareMapData(out List<UIManualDataBase> dataList)
	{
	}

	[Token(Token = "0x6010A60")]
	[Address(RVA = "0x2C2AFB4", Offset = "0x2C2AFB4", VA = "0x2C2AFB4")]
	private void PrepareWeaponData(out List<UIManualDataBase> dataList)
	{
	}

	[Token(Token = "0x6010A61")]
	[Address(RVA = "0x2C2B9EC", Offset = "0x2C2B9EC", VA = "0x2C2B9EC")]
	private void OnPrevPageEnd(int i)
	{
	}

	[Token(Token = "0x6010A62")]
	[Address(RVA = "0x2C2C014", Offset = "0x2C2C014", VA = "0x2C2C014")]
	private void OnNextPageEnd(int i, int length)
	{
	}

	[Token(Token = "0x6010A63")]
	[Address(RVA = "0x2C2C60C", Offset = "0x2C2C60C", VA = "0x2C2C60C")]
	private void UpdateMainTabTipState()
	{
	}

	[Token(Token = "0x6010A64")]
	[Address(RVA = "0x2C2CA2C", Offset = "0x2C2CA2C", VA = "0x2C2CA2C")]
	private void UpdateSubTabTipState(StandardSubTabItemViewData data)
	{
	}

	[Token(Token = "0x6010A66")]
	[Address(RVA = "0x2C2CF54", Offset = "0x2C2CF54", VA = "0x2C2CF54")]
	private static LevelRewardData _003CPrepareGrowData_003Em__0(CSVBaseData temp)
	{
		return null;
	}
}
