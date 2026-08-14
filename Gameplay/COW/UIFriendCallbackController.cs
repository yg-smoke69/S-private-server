using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200261C")]
public class UIFriendCallbackController : UIPopupWindowController, _Attribute, IConvertible
{
	[Token(Token = "0x400EB47")]
	[FieldOffset(Offset = "0x48")]
	private UIFriendCallbackView m_View;

	[Token(Token = "0x400EB48")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelShare m_ModelShare;

	[Token(Token = "0x400EB49")]
	[FieldOffset(Offset = "0x50")]
	private ActivityGroupDesc m_Data;

	[Token(Token = "0x600E1C9")]
	[Address(RVA = "0x1B6D280", Offset = "0x1B6D280", VA = "0x1B6D280")]
	public UIFriendCallbackController()
	{
	}

	[Token(Token = "0x600E1CA")]
	[Address(RVA = "0x1B6D288", Offset = "0x1B6D288", VA = "0x1B6D288")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E1CB")]
	[Address(RVA = "0x1B6D32C", Offset = "0x1B6D32C", VA = "0x1B6D32C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E1CC")]
	[Address(RVA = "0x1B6D8F4", Offset = "0x1B6D8F4", VA = "0x1B6D8F4", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600E1CD")]
	[Address(RVA = "0x1B6D5AC", Offset = "0x1B6D5AC", VA = "0x1B6D5AC")]
	private void SetData()
	{
	}

	[Token(Token = "0x600E1CE")]
	[Address(RVA = "0x1B6DE60", Offset = "0x1B6DE60", VA = "0x1B6DE60")]
	private void RefreshList(List<FriendAccountInfo> accountList, bool keep_page = false)
	{
	}

	[Token(Token = "0x600E1CF")]
	[Address(RVA = "0x1B6E1C0", Offset = "0x1B6E1C0", VA = "0x1B6E1C0", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600E1D0")]
	[Address(RVA = "0x1B6E254", Offset = "0x1B6E254", VA = "0x1B6E254")]
	private void OnInviteButtonClick()
	{
	}

	[Token(Token = "0x600E1D1")]
	[Address(RVA = "0x1B6E760", Offset = "0x1B6E760", VA = "0x1B6E760", Slot = "48")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600E1D2")]
	[Address(RVA = "0x1B6E858", Offset = "0x1B6E858", VA = "0x1B6E858", Slot = "49")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600E1D3")]
	[Address(RVA = "0x1B6D9AC", Offset = "0x1B6D9AC", VA = "0x1B6D9AC")]
	private List<FriendAccountInfo> GetCallbackData()
	{
		return null;
	}

	[Token(Token = "0x600E1D4")]
	[Address(RVA = "0x1B6E8D4", Offset = "0x1B6E8D4", VA = "0x1B6E8D4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
