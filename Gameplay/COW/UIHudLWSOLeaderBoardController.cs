using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x200219F")]
public class UIHudLWSOLeaderBoardController : UIBaseController
{
	[Token(Token = "0x20021A0")]
	private sealed class _003CShowLeaderBoard_003Ec__AnonStorey1
	{
		[Token(Token = "0x400D2AF")]
		[FieldOffset(Offset = "0x8")]
		internal bool canWaitMatchEnd;

		[Token(Token = "0x400D2B0")]
		[FieldOffset(Offset = "0xC")]
		internal UIHudLWSOLeaderBoardController _0024this;

		[Token(Token = "0x600B2B0")]
		[Address(RVA = "0x1BC1248", Offset = "0x1BC1248", VA = "0x1BC1248")]
		public _003CShowLeaderBoard_003Ec__AnonStorey1()
		{
		}
	}

	[Token(Token = "0x20021A1")]
	private sealed class _003CShowLeaderBoard_003Ec__AnonStorey0
	{
		[Token(Token = "0x400D2B1")]
		[FieldOffset(Offset = "0x8")]
		internal int delayTime;

		[Token(Token = "0x400D2B2")]
		[FieldOffset(Offset = "0xC")]
		internal int phaseEndTime;

		[Token(Token = "0x400D2B3")]
		[FieldOffset(Offset = "0x10")]
		internal _003CShowLeaderBoard_003Ec__AnonStorey1 _003C_003Ef__ref_00241;

		[Token(Token = "0x600B2B1")]
		[Address(RVA = "0x1BC16C4", Offset = "0x1BC16C4", VA = "0x1BC16C4")]
		public _003CShowLeaderBoard_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600B2B2")]
		[Address(RVA = "0x1BC4F78", Offset = "0x1BC4F78", VA = "0x1BC4F78")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x20021A2")]
	private sealed class _003CRefreshSelfInfo_003Ec__AnonStorey3
	{
		[Token(Token = "0x400D2B4")]
		[FieldOffset(Offset = "0x8")]
		internal NBJFOKDNNBK m_Data;

		[Token(Token = "0x400D2B5")]
		[FieldOffset(Offset = "0xC")]
		internal UIHudLWSOLeaderBoardController _0024this;

		[Token(Token = "0x600B2B3")]
		[Address(RVA = "0x1BC488C", Offset = "0x1BC488C", VA = "0x1BC488C")]
		public _003CRefreshSelfInfo_003Ec__AnonStorey3()
		{
		}
	}

	[Token(Token = "0x20021A3")]
	private sealed class _003CRefreshSelfInfo_003Ec__AnonStorey2
	{
		[Token(Token = "0x400D2B6")]
		[FieldOffset(Offset = "0x8")]
		internal int randomCount;

		[Token(Token = "0x400D2B7")]
		[FieldOffset(Offset = "0xC")]
		internal _003CRefreshSelfInfo_003Ec__AnonStorey3 _003C_003Ef__ref_00243;

		[Token(Token = "0x600B2B4")]
		[Address(RVA = "0x1BC4894", Offset = "0x1BC4894", VA = "0x1BC4894")]
		public _003CRefreshSelfInfo_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x600B2B5")]
		[Address(RVA = "0x1BC4E0C", Offset = "0x1BC4E0C", VA = "0x1BC4E0C")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400D2A1")]
	[FieldOffset(Offset = "0x28")]
	private UIHudLWSOLeaderBoardView m_View;

	[Token(Token = "0x400D2A2")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelMatch m_ModelMatch;

	[Token(Token = "0x400D2A3")]
	[FieldOffset(Offset = "0x30")]
	private ANBHLMNFJMP m_Game;

	[Token(Token = "0x400D2A4")]
	[FieldOffset(Offset = "0x34")]
	private uint m_CloseUIDelayCallID;

	[Token(Token = "0x400D2A5")]
	[FieldOffset(Offset = "0x38")]
	private uint m_RandomIconDelayCallID;

	[Token(Token = "0x400D2A6")]
	[FieldOffset(Offset = "0x3C")]
	private int m_CurrRound;

	[Token(Token = "0x400D2A7")]
	[FieldOffset(Offset = "0x40")]
	private UIHudLWSOLeaderBoardItemController m_SelfItemCtrl;

	[Token(Token = "0x400D2A8")]
	[FieldOffset(Offset = "0x44")]
	private List<UIHudLWSOLeaderBoardItemController> m_ItemCtrlList;

	[Token(Token = "0x400D2A9")]
	[FieldOffset(Offset = "0x48")]
	private UIHudLWSOLeaderBoardItemController m_TempCtrl;

	[Token(Token = "0x400D2AA")]
	[FieldOffset(Offset = "0x4C")]
	private List<NBJFOKDNNBK> m_LWSOTeamInfoList;

	[Token(Token = "0x400D2AB")]
	[FieldOffset(Offset = "0x50")]
	private List<UISprite> m_SelfInfoHPList;

	[Token(Token = "0x400D2AC")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<NBJFOKDNNBK> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400D2AD")]
	[FieldOffset(Offset = "0x4")]
	private static Comparison<NBJFOKDNNBK> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x400D2AE")]
	[FieldOffset(Offset = "0x8")]
	private static Comparison<NBJFOKDNNBK> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x600B2A1")]
	[Address(RVA = "0x1BC0294", Offset = "0x1BC0294", VA = "0x1BC0294")]
	public UIHudLWSOLeaderBoardController()
	{
	}

	[Token(Token = "0x600B2A2")]
	[Address(RVA = "0x1BC03B4", Offset = "0x1BC03B4", VA = "0x1BC03B4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B2A3")]
	[Address(RVA = "0x1BC045C", Offset = "0x1BC045C", VA = "0x1BC045C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B2A4")]
	[Address(RVA = "0x1BC0978", Offset = "0x1BC0978", VA = "0x1BC0978")]
	public void ShowLeaderBoard(bool matchMaking, bool canWaitMatchEnd)
	{
	}

	[Token(Token = "0x600B2A5")]
	[Address(RVA = "0x1BC1250", Offset = "0x1BC1250", VA = "0x1BC1250")]
	private void RefreshItem(bool matchMaking)
	{
	}

	[Token(Token = "0x600B2A6")]
	[Address(RVA = "0x1BC4388", Offset = "0x1BC4388", VA = "0x1BC4388")]
	private void ChangeItemData()
	{
	}

	[Token(Token = "0x600B2A7")]
	[Address(RVA = "0x1BC2D30", Offset = "0x1BC2D30", VA = "0x1BC2D30")]
	private void RefreshSelfInfo(NBJFOKDNNBK m_Data, bool matchMaking, bool changeData)
	{
	}

	[Token(Token = "0x600B2A8")]
	[Address(RVA = "0x1BC489C", Offset = "0x1BC489C", VA = "0x1BC489C")]
	private void ShowZoneIconInfo(int zone, int Identity)
	{
	}

	[Token(Token = "0x600B2A9")]
	[Address(RVA = "0x1BC4028", Offset = "0x1BC4028", VA = "0x1BC4028")]
	private void ScrollViewOnDarg()
	{
	}

	[Token(Token = "0x600B2AA")]
	[Address(RVA = "0x1BC4BA4", Offset = "0x1BC4BA4", VA = "0x1BC4BA4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600B2AB")]
	[Address(RVA = "0x1BC4D3C", Offset = "0x1BC4D3C", VA = "0x1BC4D3C")]
	private static int _003CRefreshItem_003Em__0(NBJFOKDNNBK a, NBJFOKDNNBK b)
	{
		return default(int);
	}

	[Token(Token = "0x600B2AC")]
	[Address(RVA = "0x1BC4D7C", Offset = "0x1BC4D7C", VA = "0x1BC4D7C")]
	private static int _003CRefreshItem_003Em__1(NBJFOKDNNBK a, NBJFOKDNNBK b)
	{
		return default(int);
	}

	[Token(Token = "0x600B2AD")]
	[Address(RVA = "0x1BC4DBC", Offset = "0x1BC4DBC", VA = "0x1BC4DBC")]
	private static int _003CChangeItemData_003Em__2(NBJFOKDNNBK a, NBJFOKDNNBK b)
	{
		return default(int);
	}

	[Token(Token = "0x600B2AE")]
	[Address(RVA = "0x1BC4DFC", Offset = "0x1BC4DFC", VA = "0x1BC4DFC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B2AF")]
	[Address(RVA = "0x1BC4E04", Offset = "0x1BC4E04", VA = "0x1BC4E04")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
