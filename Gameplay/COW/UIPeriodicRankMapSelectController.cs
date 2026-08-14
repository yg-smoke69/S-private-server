using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002A4A")]
public class UIPeriodicRankMapSelectController : UIBaseController, _Attribute
{
	[Token(Token = "0x2002A4B")]
	private sealed class _003CShowMapItemAnim_003Ec__AnonStorey0
	{
		[Token(Token = "0x40103F7")]
		[FieldOffset(Offset = "0x8")]
		internal UIPeriodicRankMapSelectItemController item;

		[Token(Token = "0x60112B2")]
		[Address(RVA = "0x23E15B0", Offset = "0x23E15B0", VA = "0x23E15B0")]
		public _003CShowMapItemAnim_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60112B3")]
		[Address(RVA = "0x23E26FC", Offset = "0x23E26FC", VA = "0x23E26FC")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x40103EC")]
	[FieldOffset(Offset = "0x28")]
	private UIRankMapSelectView m_View;

	[Token(Token = "0x40103ED")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelPeriodicLadderMatch m_Model;

	[Token(Token = "0x40103EE")]
	[FieldOffset(Offset = "0x30")]
	private UIModelMapOpeningInfo m_ModelMapOpeningInfo;

	[Token(Token = "0x40103EF")]
	[FieldOffset(Offset = "0x34")]
	private uint m_CurrentSelectConfigID;

	[Token(Token = "0x40103F0")]
	[FieldOffset(Offset = "0x38")]
	private bool m_IsForceRandom;

	[Token(Token = "0x40103F1")]
	[FieldOffset(Offset = "0x3C")]
	private uint m_CurrentSeasonGameMode;

	[Token(Token = "0x40103F2")]
	[FieldOffset(Offset = "0x40")]
	private string m_RankKey;

	[Token(Token = "0x40103F3")]
	[FieldOffset(Offset = "0x44")]
	private List<UICommonGuideController> m_GuideController;

	[Token(Token = "0x40103F4")]
	[FieldOffset(Offset = "0x48")]
	private Dictionary<uint, bool> m_PeriodicMapSelectDict;

	[Token(Token = "0x40103F5")]
	[FieldOffset(Offset = "0x4C")]
	private List<uint> m_AnimDelayCalls;

	[Token(Token = "0x40103F6")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<UIPeriodicRankMapSelectItemController> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x601129D")]
	[Address(RVA = "0x23DF7BC", Offset = "0x23DF7BC", VA = "0x23DF7BC")]
	public UIPeriodicRankMapSelectController()
	{
	}

	[Token(Token = "0x601129E")]
	[Address(RVA = "0x23DF8DC", Offset = "0x23DF8DC", VA = "0x23DF8DC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601129F")]
	[Address(RVA = "0x23DF984", Offset = "0x23DF984", VA = "0x23DF984", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60112A0")]
	[Address(RVA = "0x23DFD30", Offset = "0x23DFD30", VA = "0x23DFD30", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60112A1")]
	[Address(RVA = "0x23DFECC", Offset = "0x23DFECC", VA = "0x23DFECC")]
	public void SetViewData()
	{
	}

	[Token(Token = "0x60112A2")]
	[Address(RVA = "0x23E0F1C", Offset = "0x23E0F1C", VA = "0x23E0F1C")]
	private void ShowMapItemAnim()
	{
	}

	[Token(Token = "0x60112A3")]
	[Address(RVA = "0x23E15B8", Offset = "0x23E15B8", VA = "0x23E15B8")]
	private void ClearDelayCalls()
	{
	}

	[Token(Token = "0x60112A4")]
	[Address(RVA = "0x23E17A0", Offset = "0x23E17A0", VA = "0x23E17A0", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x60112A5")]
	[Address(RVA = "0x23E1AC8", Offset = "0x23E1AC8", VA = "0x23E1AC8")]
	private void OnPeriodicLadderMapSelectChanged(object[] param)
	{
	}

	[Token(Token = "0x60112A6")]
	[Address(RVA = "0x23E1C68", Offset = "0x23E1C68", VA = "0x23E1C68")]
	private void OnPeriodicLadderMapSelectRefresh(object[] param)
	{
	}

	[Token(Token = "0x60112A7")]
	[Address(RVA = "0x23E0810", Offset = "0x23E0810", VA = "0x23E0810")]
	private void DataChanged()
	{
	}

	[Token(Token = "0x60112A8")]
	[Address(RVA = "0x23E04B0", Offset = "0x23E04B0", VA = "0x23E04B0")]
	private void RefreshList(List<MapOpeningInfo> mapList, bool keep_page = false)
	{
	}

	[Token(Token = "0x60112A9")]
	[Address(RVA = "0x23E1EA0", Offset = "0x23E1EA0", VA = "0x23E1EA0", Slot = "31")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x60112AA")]
	[Address(RVA = "0x23E1F98", Offset = "0x23E1F98", VA = "0x23E1F98", Slot = "32")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x60112AB")]
	[Address(RVA = "0x23E2014", Offset = "0x23E2014", VA = "0x23E2014")]
	private void OnConfirmButtonClick()
	{
	}

	[Token(Token = "0x60112AC")]
	[Address(RVA = "0x23E2580", Offset = "0x23E2580", VA = "0x23E2580")]
	private static int _003CShowMapItemAnim_003Em__0(UIPeriodicRankMapSelectItemController x, UIPeriodicRankMapSelectItemController y)
	{
		return default(int);
	}

	[Token(Token = "0x60112AD")]
	[Address(RVA = "0x23E25F0", Offset = "0x23E25F0", VA = "0x23E25F0")]
	private void _003CShowMapItemAnim_003Em__1()
	{
	}

	[Token(Token = "0x60112AE")]
	[Address(RVA = "0x23E2634", Offset = "0x23E2634", VA = "0x23E2634")]
	private void _003COnVisibilityChanged_003Em__2()
	{
	}

	[Token(Token = "0x60112AF")]
	[Address(RVA = "0x23E26E4", Offset = "0x23E26E4", VA = "0x23E26E4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60112B0")]
	[Address(RVA = "0x23E26EC", Offset = "0x23E26EC", VA = "0x23E26EC")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x60112B1")]
	[Address(RVA = "0x23E26F4", Offset = "0x23E26F4", VA = "0x23E26F4")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
