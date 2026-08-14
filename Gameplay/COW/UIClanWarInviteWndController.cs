using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002559")]
public class UIClanWarInviteWndController : UIPopupWindowController, _Attribute, IConvertible
{
	[Token(Token = "0x200255A")]
	private sealed class _003COnSearchBtnClick_003Ec__AnonStorey0
	{
		[Token(Token = "0x400E756")]
		[FieldOffset(Offset = "0x8")]
		internal string name;

		[Token(Token = "0x400E757")]
		[FieldOffset(Offset = "0xC")]
		internal UIClanWarInviteWndController _0024this;

		[Token(Token = "0x600D9E3")]
		[Address(RVA = "0x2B521C0", Offset = "0x2B521C0", VA = "0x2B521C0")]
		public _003COnSearchBtnClick_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600D9E4")]
		[Address(RVA = "0x2B5288C", Offset = "0x2B5288C", VA = "0x2B5288C")]
		internal void _003C_003Em__0()
		{
		}

		[Token(Token = "0x600D9E5")]
		[Address(RVA = "0x2B52900", Offset = "0x2B52900", VA = "0x2B52900")]
		internal bool _003C_003Em__1(ClanMember a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400E750")]
	[FieldOffset(Offset = "0x48")]
	private UIClanWarInviteWndView m_View;

	[Token(Token = "0x400E751")]
	[FieldOffset(Offset = "0x4C")]
	private bool m_HasSearch;

	[Token(Token = "0x400E752")]
	[FieldOffset(Offset = "0x50")]
	private uint m_WinkCall;

	[Token(Token = "0x400E753")]
	[FieldOffset(Offset = "0x54")]
	private List<ClanMember> m_OnlineClanMemberList;

	[Token(Token = "0x400E754")]
	[FieldOffset(Offset = "0x58")]
	private ulong m_LastRefreshTime;

	[Token(Token = "0x400E755")]
	[FieldOffset(Offset = "0x60")]
	private UIModelClan m_ModelClan;

	[Token(Token = "0x600D9D0")]
	[Address(RVA = "0x2B50C68", Offset = "0x2B50C68", VA = "0x2B50C68")]
	public UIClanWarInviteWndController()
	{
	}

	[Token(Token = "0x600D9D1")]
	[Address(RVA = "0x2B50CF4", Offset = "0x2B50CF4", VA = "0x2B50CF4", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600D9D2")]
	[Address(RVA = "0x2B50E7C", Offset = "0x2B50E7C", VA = "0x2B50E7C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D9D3")]
	[Address(RVA = "0x2B512C4", Offset = "0x2B512C4", VA = "0x2B512C4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D9D4")]
	[Address(RVA = "0x2B51368", Offset = "0x2B51368", VA = "0x2B51368", Slot = "47")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600D9D5")]
	[Address(RVA = "0x2B513E4", Offset = "0x2B513E4", VA = "0x2B513E4", Slot = "46")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600D9D6")]
	[Address(RVA = "0x2B514DC", Offset = "0x2B514DC", VA = "0x2B514DC")]
	private void ResetSearchInput()
	{
	}

	[Token(Token = "0x600D9D7")]
	[Address(RVA = "0x2B5168C", Offset = "0x2B5168C", VA = "0x2B5168C")]
	private void RefreshScrollView()
	{
	}

	[Token(Token = "0x600D9D8")]
	[Address(RVA = "0x2B51794", Offset = "0x2B51794", VA = "0x2B51794")]
	private void SetClanUIData()
	{
	}

	[Token(Token = "0x600D9D9")]
	[Address(RVA = "0x2B51990", Offset = "0x2B51990", VA = "0x2B51990")]
	private void OnSearchInputGetFocus()
	{
	}

	[Token(Token = "0x600D9DA")]
	[Address(RVA = "0x2B51A8C", Offset = "0x2B51A8C", VA = "0x2B51A8C")]
	private void OnSearchInputChange()
	{
	}

	[Token(Token = "0x600D9DB")]
	[Address(RVA = "0x2B51BA0", Offset = "0x2B51BA0", VA = "0x2B51BA0")]
	private void OnSearchBtnClick()
	{
	}

	[Token(Token = "0x600D9DC")]
	[Address(RVA = "0x2B521C8", Offset = "0x2B521C8", VA = "0x2B521C8")]
	private void UpdateRefreshState(bool inCD = false)
	{
	}

	[Token(Token = "0x600D9DD")]
	[Address(RVA = "0x2B52298", Offset = "0x2B52298", VA = "0x2B52298")]
	private void OnRefreshBtnClick()
	{
	}

	[Token(Token = "0x600D9DE")]
	[Address(RVA = "0x2B52714", Offset = "0x2B52714", VA = "0x2B52714", Slot = "48")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600D9DF")]
	[Address(RVA = "0x2B527E0", Offset = "0x2B527E0", VA = "0x2B527E0", Slot = "49")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600D9E0")]
	[Address(RVA = "0x2B52874", Offset = "0x2B52874", VA = "0x2B52874")]
	private void _003COnRefreshBtnClick_003Em__0()
	{
	}

	[Token(Token = "0x600D9E1")]
	[Address(RVA = "0x2B5287C", Offset = "0x2B5287C", VA = "0x2B5287C")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600D9E2")]
	[Address(RVA = "0x2B52884", Offset = "0x2B52884", VA = "0x2B52884")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
