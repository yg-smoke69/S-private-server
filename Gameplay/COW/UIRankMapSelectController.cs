using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002AB4")]
public class UIRankMapSelectController : UIBaseController, _Attribute
{
	[Token(Token = "0x2002AB5")]
	private sealed class _003CSetViewData_003Ec__AnonStorey0
	{
		[Token(Token = "0x4010691")]
		[FieldOffset(Offset = "0x8")]
		internal List<uint> keys;

		[Token(Token = "0x60117BB")]
		[Address(RVA = "0x1ACA790", Offset = "0x1ACA790", VA = "0x1ACA790")]
		public _003CSetViewData_003Ec__AnonStorey0()
		{
		}
	}

	[Token(Token = "0x2002AB6")]
	private sealed class _003CSetViewData_003Ec__AnonStorey1
	{
		[Token(Token = "0x4010692")]
		[FieldOffset(Offset = "0x8")]
		internal int i;

		[Token(Token = "0x4010693")]
		[FieldOffset(Offset = "0xC")]
		internal _003CSetViewData_003Ec__AnonStorey0 _003C_003Ef__ref_00240;

		[Token(Token = "0x60117BC")]
		[Address(RVA = "0x1ACA798", Offset = "0x1ACA798", VA = "0x1ACA798")]
		public _003CSetViewData_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x60117BD")]
		[Address(RVA = "0x1ACCB90", Offset = "0x1ACCB90", VA = "0x1ACCB90")]
		internal bool _003C_003Em__0(MapOpeningInfo x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002AB7")]
	private sealed class _003CShowMapItemAnim_003Ec__AnonStorey2
	{
		[Token(Token = "0x4010694")]
		[FieldOffset(Offset = "0x8")]
		internal UIRankMapSelectItemController item;

		[Token(Token = "0x60117BE")]
		[Address(RVA = "0x1ACB8D8", Offset = "0x1ACB8D8", VA = "0x1ACB8D8")]
		public _003CShowMapItemAnim_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x60117BF")]
		[Address(RVA = "0x1ACCC60", Offset = "0x1ACCC60", VA = "0x1ACCC60")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x4010689")]
	[FieldOffset(Offset = "0x28")]
	private UIRankMapSelectView m_View;

	[Token(Token = "0x401068A")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelLadderMatch m_Model;

	[Token(Token = "0x401068B")]
	[FieldOffset(Offset = "0x30")]
	private string m_RankKey;

	[Token(Token = "0x401068C")]
	[FieldOffset(Offset = "0x34")]
	private List<UICommonGuideController> m_GuideController;

	[Token(Token = "0x401068D")]
	[FieldOffset(Offset = "0x38")]
	private Dictionary<uint, bool> m_MapSelectDictory;

	[Token(Token = "0x401068E")]
	[FieldOffset(Offset = "0x3C")]
	private List<uint> m_AnimDelayCalls;

	[Token(Token = "0x401068F")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<MapOpeningInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4010690")]
	[FieldOffset(Offset = "0x4")]
	private static Comparison<UIRankMapSelectItemController> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x60117A4")]
	[Address(RVA = "0x1AC9234", Offset = "0x1AC9234", VA = "0x1AC9234")]
	public UIRankMapSelectController()
	{
	}

	[Token(Token = "0x60117A5")]
	[Address(RVA = "0x1AC9354", Offset = "0x1AC9354", VA = "0x1AC9354")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60117A6")]
	[Address(RVA = "0x1AC93FC", Offset = "0x1AC93FC", VA = "0x1AC93FC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60117A7")]
	[Address(RVA = "0x1AC9768", Offset = "0x1AC9768", VA = "0x1AC9768", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60117A8")]
	[Address(RVA = "0x1AC996C", Offset = "0x1AC996C", VA = "0x1AC996C")]
	public void SetViewData()
	{
	}

	[Token(Token = "0x60117A9")]
	[Address(RVA = "0x1ACB248", Offset = "0x1ACB248", VA = "0x1ACB248")]
	private void ShowMapItemAnim()
	{
	}

	[Token(Token = "0x60117AA")]
	[Address(RVA = "0x1ACB8E0", Offset = "0x1ACB8E0", VA = "0x1ACB8E0")]
	private void ClearDelayCalls()
	{
	}

	[Token(Token = "0x60117AB")]
	[Address(RVA = "0x1ACBAC8", Offset = "0x1ACBAC8", VA = "0x1ACBAC8", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x60117AC")]
	[Address(RVA = "0x1ACBDF0", Offset = "0x1ACBDF0", VA = "0x1ACBDF0")]
	private void OnLadderMapSelectChanged(object[] param)
	{
	}

	[Token(Token = "0x60117AD")]
	[Address(RVA = "0x1ACBF88", Offset = "0x1ACBF88", VA = "0x1ACBF88")]
	private void OnLadderMapSelectRefresh(object[] param)
	{
	}

	[Token(Token = "0x60117AE")]
	[Address(RVA = "0x1ACAB00", Offset = "0x1ACAB00", VA = "0x1ACAB00")]
	private void DataChanged()
	{
	}

	[Token(Token = "0x60117AF")]
	[Address(RVA = "0x1ACA7A0", Offset = "0x1ACA7A0", VA = "0x1ACA7A0")]
	private void RefreshList(List<MapOpeningInfo> mapList, bool keep_page = false)
	{
	}

	[Token(Token = "0x60117B0")]
	[Address(RVA = "0x1ACC23C", Offset = "0x1ACC23C", VA = "0x1ACC23C", Slot = "31")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x60117B1")]
	[Address(RVA = "0x1ACC334", Offset = "0x1ACC334", VA = "0x1ACC334", Slot = "32")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x60117B2")]
	[Address(RVA = "0x1ACC3B0", Offset = "0x1ACC3B0", VA = "0x1ACC3B0")]
	private void OnConfirmButtonClick()
	{
	}

	[Token(Token = "0x60117B3")]
	[Address(RVA = "0x1ACC85C", Offset = "0x1ACC85C", VA = "0x1ACC85C")]
	private void OnCommonGuideChanged(object[] data)
	{
	}

	[Token(Token = "0x60117B4")]
	[Address(RVA = "0x1ACC9E4", Offset = "0x1ACC9E4", VA = "0x1ACC9E4")]
	private static bool _003CSetViewData_003Em__0(MapOpeningInfo x)
	{
		return default(bool);
	}

	[Token(Token = "0x60117B5")]
	[Address(RVA = "0x1ACCA14", Offset = "0x1ACCA14", VA = "0x1ACCA14")]
	private static int _003CShowMapItemAnim_003Em__1(UIRankMapSelectItemController x, UIRankMapSelectItemController y)
	{
		return default(int);
	}

	[Token(Token = "0x60117B6")]
	[Address(RVA = "0x1ACCA84", Offset = "0x1ACCA84", VA = "0x1ACCA84")]
	private void _003CShowMapItemAnim_003Em__2()
	{
	}

	[Token(Token = "0x60117B7")]
	[Address(RVA = "0x1ACCAC8", Offset = "0x1ACCAC8", VA = "0x1ACCAC8")]
	private void _003COnVisibilityChanged_003Em__3()
	{
	}

	[Token(Token = "0x60117B8")]
	[Address(RVA = "0x1ACCB78", Offset = "0x1ACCB78", VA = "0x1ACCB78")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60117B9")]
	[Address(RVA = "0x1ACCB80", Offset = "0x1ACCB80", VA = "0x1ACCB80")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x60117BA")]
	[Address(RVA = "0x1ACCB88", Offset = "0x1ACCB88", VA = "0x1ACCB88")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
