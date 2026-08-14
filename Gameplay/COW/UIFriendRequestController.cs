using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002626")]
public class UIFriendRequestController : UIPopupWindowController, _Attribute, IConvertible, IComparable<int>
{
	[Token(Token = "0x400EBA8")]
	[FieldOffset(Offset = "0x48")]
	private UIFriendRequestView m_View;

	[Token(Token = "0x400EBA9")]
	[FieldOffset(Offset = "0x4C")]
	private EFriendTabType m_CurrentType;

	[Token(Token = "0x400EBAA")]
	[FieldOffset(Offset = "0x50")]
	private bool m_currentPushType;

	[Token(Token = "0x400EBAB")]
	[FieldOffset(Offset = "0x0")]
	private static Action _003C_003Ef__am_0024cache0;

	[Token(Token = "0x1700116F")]
	public EFriendTabType CurrentTabType
	{
		[Token(Token = "0x600E26E")]
		[Address(RVA = "0x250EA64", Offset = "0x250EA64", VA = "0x250EA64")]
		get
		{
			return default(EFriendTabType);
		}
		[Token(Token = "0x600E26F")]
		[Address(RVA = "0x250EABC", Offset = "0x250EABC", VA = "0x250EABC")]
		private set
		{
		}
	}

	[Token(Token = "0x600E26C")]
	[Address(RVA = "0x250E9B0", Offset = "0x250E9B0", VA = "0x250E9B0")]
	public UIFriendRequestController()
	{
	}

	[Token(Token = "0x600E26D")]
	[Address(RVA = "0x250E9C0", Offset = "0x250E9C0", VA = "0x250E9C0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E270")]
	[Address(RVA = "0x250F074", Offset = "0x250F074", VA = "0x250F074", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E271")]
	[Address(RVA = "0x250F5A0", Offset = "0x250F5A0", VA = "0x250F5A0", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600E272")]
	[Address(RVA = "0x250F670", Offset = "0x250F670", VA = "0x250F670", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600E273")]
	[Address(RVA = "0x250F804", Offset = "0x250F804", VA = "0x250F804", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600E274")]
	[Address(RVA = "0x25102E0", Offset = "0x25102E0", VA = "0x25102E0", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600E275")]
	[Address(RVA = "0x2510374", Offset = "0x2510374", VA = "0x2510374", Slot = "48")]
	public void OnTipsDataChange(ETipsType type, int num)
	{
	}

	[Token(Token = "0x600E276")]
	[Address(RVA = "0x25103F4", Offset = "0x25103F4", VA = "0x25103F4", Slot = "49")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600E277")]
	[Address(RVA = "0x25104EC", Offset = "0x25104EC", VA = "0x25104EC", Slot = "50")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600E278")]
	[Address(RVA = "0x2510568", Offset = "0x2510568", VA = "0x2510568")]
	private void OnSelectFriendRequest()
	{
	}

	[Token(Token = "0x600E279")]
	[Address(RVA = "0x25106E8", Offset = "0x25106E8", VA = "0x25106E8")]
	private void OnSelectBlackList()
	{
	}

	[Token(Token = "0x600E27A")]
	[Address(RVA = "0x25107F8", Offset = "0x25107F8", VA = "0x25107F8")]
	private void ChangeToBlackList()
	{
	}

	[Token(Token = "0x600E27B")]
	[Address(RVA = "0x250ED8C", Offset = "0x250ED8C", VA = "0x250ED8C")]
	private void UpdateShareUI()
	{
	}

	[Token(Token = "0x600E27C")]
	[Address(RVA = "0x250FD68", Offset = "0x250FD68", VA = "0x250FD68")]
	private void RefreshViewInfo()
	{
	}

	[Token(Token = "0x600E27D")]
	[Address(RVA = "0x2510974", Offset = "0x2510974", VA = "0x2510974")]
	private void OnBtnRefuseAllClick()
	{
	}

	[Token(Token = "0x600E27E")]
	[Address(RVA = "0x250FA08", Offset = "0x250FA08", VA = "0x250FA08")]
	private void RefreshList(List<FriendAccountInfo> accountList, bool keep_page = false)
	{
	}

	[Token(Token = "0x600E27F")]
	[Address(RVA = "0x2510D30", Offset = "0x2510D30", VA = "0x2510D30")]
	private static void _003COnBtnRefuseAllClick_003Em__0()
	{
	}

	[Token(Token = "0x600E280")]
	[Address(RVA = "0x2510EDC", Offset = "0x2510EDC", VA = "0x2510EDC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E281")]
	[Address(RVA = "0x2510EE4", Offset = "0x2510EE4", VA = "0x2510EE4")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600E282")]
	[Address(RVA = "0x2510EEC", Offset = "0x2510EEC", VA = "0x2510EEC")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
