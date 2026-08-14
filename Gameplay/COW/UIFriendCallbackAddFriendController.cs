using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200261B")]
public class UIFriendCallbackAddFriendController : UIPopupWindowController
{
	[Token(Token = "0x400EB43")]
	[FieldOffset(Offset = "0x48")]
	private UIFriendCallbackAddFriendView m_View;

	[Token(Token = "0x400EB44")]
	[FieldOffset(Offset = "0x4C")]
	private FriendAccountInfo m_Data;

	[Token(Token = "0x400EB45")]
	[FieldOffset(Offset = "0x50")]
	private UIBaseProfileInfoController m_BaseProfile;

	[Token(Token = "0x400EB46")]
	[FieldOffset(Offset = "0x54")]
	private Action m_afterAddAction;

	[Token(Token = "0x600E1C0")]
	[Address(RVA = "0x1B6C490", Offset = "0x1B6C490", VA = "0x1B6C490")]
	public UIFriendCallbackAddFriendController()
	{
	}

	[Token(Token = "0x600E1C1")]
	[Address(RVA = "0x1B6C498", Offset = "0x1B6C498", VA = "0x1B6C498")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E1C2")]
	[Address(RVA = "0x1B6C53C", Offset = "0x1B6C53C", VA = "0x1B6C53C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E1C3")]
	[Address(RVA = "0x1B6C7C4", Offset = "0x1B6C7C4", VA = "0x1B6C7C4", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600E1C4")]
	[Address(RVA = "0x1B6C8DC", Offset = "0x1B6C8DC", VA = "0x1B6C8DC")]
	public void SetData(FriendAccountInfo data, Action action)
	{
	}

	[Token(Token = "0x600E1C5")]
	[Address(RVA = "0x1B6CC64", Offset = "0x1B6CC64", VA = "0x1B6CC64")]
	private void OnBtnReWriteClicked()
	{
	}

	[Token(Token = "0x600E1C6")]
	[Address(RVA = "0x1B6CD7C", Offset = "0x1B6CD7C", VA = "0x1B6CD7C")]
	private void OnBtnAddFriendClicked()
	{
	}

	[Token(Token = "0x600E1C7")]
	[Address(RVA = "0x1B6CF44", Offset = "0x1B6CF44", VA = "0x1B6CF44")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E1C8")]
	[Address(RVA = "0x1B6CF4C", Offset = "0x1B6CF4C", VA = "0x1B6CF4C")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
