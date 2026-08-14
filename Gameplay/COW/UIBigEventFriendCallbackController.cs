using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2001E87")]
public class UIBigEventFriendCallbackController : UIPopupWindowController, _Attribute, IConvertible
{
	[Token(Token = "0x400C003")]
	[FieldOffset(Offset = "0x48")]
	private UIBigEventFriendCallbackView m_View;

	[Token(Token = "0x400C004")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelShare m_ModelShare;

	[Token(Token = "0x60092E3")]
	[Address(RVA = "0x1415B9C", Offset = "0x1415B9C", VA = "0x1415B9C")]
	public UIBigEventFriendCallbackController()
	{
	}

	[Token(Token = "0x60092E4")]
	[Address(RVA = "0x1415BA4", Offset = "0x1415BA4", VA = "0x1415BA4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60092E5")]
	[Address(RVA = "0x1415C4C", Offset = "0x1415C4C", VA = "0x1415C4C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60092E6")]
	[Address(RVA = "0x1416214", Offset = "0x1416214", VA = "0x1416214", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x60092E7")]
	[Address(RVA = "0x1415ECC", Offset = "0x1415ECC", VA = "0x1415ECC")]
	private void SetData()
	{
	}

	[Token(Token = "0x60092E8")]
	[Address(RVA = "0x1416780", Offset = "0x1416780", VA = "0x1416780")]
	private void RefreshList(List<FriendAccountInfo> accountList, bool keep_page = false)
	{
	}

	[Token(Token = "0x60092E9")]
	[Address(RVA = "0x1416AE0", Offset = "0x1416AE0", VA = "0x1416AE0", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x60092EA")]
	[Address(RVA = "0x1416B74", Offset = "0x1416B74", VA = "0x1416B74")]
	private void OnInviteButtonClick()
	{
	}

	[Token(Token = "0x60092EB")]
	[Address(RVA = "0x1417080", Offset = "0x1417080", VA = "0x1417080", Slot = "48")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x60092EC")]
	[Address(RVA = "0x141719C", Offset = "0x141719C", VA = "0x141719C", Slot = "49")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x60092ED")]
	[Address(RVA = "0x14162CC", Offset = "0x14162CC", VA = "0x14162CC")]
	private List<FriendAccountInfo> GetCallbackData()
	{
		return null;
	}

	[Token(Token = "0x60092EE")]
	[Address(RVA = "0x1417218", Offset = "0x1417218", VA = "0x1417218")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
