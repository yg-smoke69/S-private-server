using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20020DA")]
public class UIEPTaskMainController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x20020DB")]
	public enum TaskTab
	{
		[Token(Token = "0x400CDA3")]
		None,
		[Token(Token = "0x400CDA4")]
		Daily,
		[Token(Token = "0x400CDA5")]
		Weekly,
		[Token(Token = "0x400CDA6")]
		Challenge
	}

	[Token(Token = "0x20020DC")]
	public class TaskData
	{
		[Token(Token = "0x400CDA7")]
		[FieldOffset(Offset = "0x8")]
		public TaskTab m_Tab;

		[Token(Token = "0x400CDA8")]
		[FieldOffset(Offset = "0xC")]
		public string m_Title;

		[Token(Token = "0x400CDA9")]
		[FieldOffset(Offset = "0x10")]
		public ETipsType m_RedDot;

		[Token(Token = "0x400CDAA")]
		[FieldOffset(Offset = "0x14")]
		public Func<UIBaseController> m_OnSelect;

		[Token(Token = "0x400CDAB")]
		[FieldOffset(Offset = "0x18")]
		public bool m_SpecialRedDot;

		[Token(Token = "0x600AA31")]
		[Address(RVA = "0x2BB2B90", Offset = "0x2BB2B90", VA = "0x2BB2B90")]
		public TaskData()
		{
		}
	}

	[Token(Token = "0x20020DD")]
	private sealed class _003CCreateTabs_003Ec__AnonStorey0
	{
		[Token(Token = "0x400CDAC")]
		[FieldOffset(Offset = "0x8")]
		internal TaskData data;

		[Token(Token = "0x400CDAD")]
		[FieldOffset(Offset = "0xC")]
		internal int index;

		[Token(Token = "0x400CDAE")]
		[FieldOffset(Offset = "0x10")]
		internal UIEPTaskMainController _0024this;

		[Token(Token = "0x600AA32")]
		[Address(RVA = "0x2BB313C", Offset = "0x2BB313C", VA = "0x2BB313C")]
		public _003CCreateTabs_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600AA33")]
		[Address(RVA = "0x2BB42B8", Offset = "0x2BB42B8", VA = "0x2BB42B8")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x20020DE")]
	private sealed class _003COnSelectTab_003Ec__AnonStorey1
	{
		[Token(Token = "0x400CDAF")]
		[FieldOffset(Offset = "0x8")]
		internal TaskTab tab;

		[Token(Token = "0x600AA34")]
		[Address(RVA = "0x2BB383C", Offset = "0x2BB383C", VA = "0x2BB383C")]
		public _003COnSelectTab_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x600AA35")]
		[Address(RVA = "0x2BB440C", Offset = "0x2BB440C", VA = "0x2BB440C")]
		internal bool _003C_003Em__0(TaskData temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20020DF")]
	private sealed class _003CGotoTab_003Ec__AnonStorey2
	{
		[Token(Token = "0x400CDB0")]
		[FieldOffset(Offset = "0x8")]
		internal TaskTab tab;

		[Token(Token = "0x600AA36")]
		[Address(RVA = "0x2BB3A8C", Offset = "0x2BB3A8C", VA = "0x2BB3A8C")]
		public _003CGotoTab_003Ec__AnonStorey2()
		{
		}
	}

	[Token(Token = "0x20020E0")]
	private sealed class _003CGotoTab_003Ec__AnonStorey3
	{
		[Token(Token = "0x400CDB1")]
		[FieldOffset(Offset = "0x8")]
		internal TaskData data;

		[Token(Token = "0x400CDB2")]
		[FieldOffset(Offset = "0xC")]
		internal _003CGotoTab_003Ec__AnonStorey2 _003C_003Ef__ref_00242;

		[Token(Token = "0x600AA37")]
		[Address(RVA = "0x2BB3A94", Offset = "0x2BB3A94", VA = "0x2BB3A94")]
		public _003CGotoTab_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x600AA38")]
		[Address(RVA = "0x2BB4308", Offset = "0x2BB4308", VA = "0x2BB4308")]
		internal bool _003C_003Em__0(TaskData e)
		{
			return default(bool);
		}

		[Token(Token = "0x600AA39")]
		[Address(RVA = "0x2BB4354", Offset = "0x2BB4354", VA = "0x2BB4354")]
		internal bool _003C_003Em__1(StandardTopTabItemViewData e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400CD9A")]
	[FieldOffset(Offset = "0x48")]
	private UIModelElitePass m_ModelEP;

	[Token(Token = "0x400CD9B")]
	[FieldOffset(Offset = "0x4C")]
	private UIEPTaskMainView m_View;

	[Token(Token = "0x400CD9C")]
	[FieldOffset(Offset = "0x50")]
	private TaskTab m_CurrentTab;

	[Token(Token = "0x400CD9D")]
	[FieldOffset(Offset = "0x54")]
	private List<TaskData> m_TaskDatas;

	[Token(Token = "0x400CD9E")]
	[FieldOffset(Offset = "0x58")]
	private Dictionary<int, UIBaseController> m_CtrlDic;

	[Token(Token = "0x400CD9F")]
	[FieldOffset(Offset = "0x5C")]
	private List<StandardTopTabItemViewData> m_TabDataList;

	[Token(Token = "0x400CDA0")]
	[FieldOffset(Offset = "0x60")]
	private UIStandardTopTabController m_TabCtrl;

	[Token(Token = "0x400CDA1")]
	private const string Default_Icon_Name = "SG_UI_Icon_DailyRewards";

	[Token(Token = "0x600AA1D")]
	[Address(RVA = "0x2BB1FFC", Offset = "0x2BB1FFC", VA = "0x2BB1FFC")]
	public UIEPTaskMainController()
	{
	}

	[Token(Token = "0x600AA1E")]
	[Address(RVA = "0x2BB20F0", Offset = "0x2BB20F0", VA = "0x2BB20F0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600AA1F")]
	[Address(RVA = "0x2BB2194", Offset = "0x2BB2194", VA = "0x2BB2194", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600AA20")]
	[Address(RVA = "0x2BB29F8", Offset = "0x2BB29F8", VA = "0x2BB29F8", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600AA21")]
	[Address(RVA = "0x2BB2A5C", Offset = "0x2BB2A5C", VA = "0x2BB2A5C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600AA22")]
	[Address(RVA = "0x2BB2384", Offset = "0x2BB2384", VA = "0x2BB2384")]
	private void InitTab()
	{
	}

	[Token(Token = "0x600AA23")]
	[Address(RVA = "0x2BB2E3C", Offset = "0x2BB2E3C", VA = "0x2BB2E3C")]
	private void UpdateTabTip(object[] data)
	{
	}

	[Token(Token = "0x600AA24")]
	[Address(RVA = "0x2BB2B98", Offset = "0x2BB2B98", VA = "0x2BB2B98")]
	private void CreateTabs(TaskData data)
	{
	}

	[Token(Token = "0x600AA25")]
	[Address(RVA = "0x2BB3144", Offset = "0x2BB3144", VA = "0x2BB3144")]
	private void OnSelectTab(TaskTab tab, int index = 0)
	{
	}

	[Token(Token = "0x600AA26")]
	[Address(RVA = "0x2BB3844", Offset = "0x2BB3844", VA = "0x2BB3844")]
	public void GotoTab(TaskTab tab)
	{
	}

	[Token(Token = "0x600AA27")]
	[Address(RVA = "0x2BB3A9C", Offset = "0x2BB3A9C", VA = "0x2BB3A9C")]
	public void ShowSignIn()
	{
	}

	[Token(Token = "0x600AA28")]
	[Address(RVA = "0x2BB3DD8", Offset = "0x2BB3DD8", VA = "0x2BB3DD8")]
	private void OnCloseClick()
	{
	}

	[Token(Token = "0x600AA29")]
	[Address(RVA = "0x2BB3E3C", Offset = "0x2BB3E3C", VA = "0x2BB3E3C", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600AA2A")]
	[Address(RVA = "0x2BB3F30", Offset = "0x2BB3F30", VA = "0x2BB3F30", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600AA2B")]
	[Address(RVA = "0x2BB400C", Offset = "0x2BB400C", VA = "0x2BB400C")]
	private UIBaseController _003CInitTab_003Em__0()
	{
		return null;
	}

	[Token(Token = "0x600AA2C")]
	[Address(RVA = "0x2BB40E8", Offset = "0x2BB40E8", VA = "0x2BB40E8")]
	private UIBaseController _003CInitTab_003Em__1()
	{
		return null;
	}

	[Token(Token = "0x600AA2D")]
	[Address(RVA = "0x2BB41C4", Offset = "0x2BB41C4", VA = "0x2BB41C4")]
	private UIBaseController _003CInitTab_003Em__2()
	{
		return null;
	}

	[Token(Token = "0x600AA2E")]
	[Address(RVA = "0x2BB42A0", Offset = "0x2BB42A0", VA = "0x2BB42A0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600AA2F")]
	[Address(RVA = "0x2BB42A8", Offset = "0x2BB42A8", VA = "0x2BB42A8")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600AA30")]
	[Address(RVA = "0x2BB42B0", Offset = "0x2BB42B0", VA = "0x2BB42B0")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
