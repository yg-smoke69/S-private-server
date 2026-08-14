using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E86")]
public class UIBigEventFriendCallbackAddFriendController : UIPopupWindowController
{
	[Token(Token = "0x400BFFD")]
	[FieldOffset(Offset = "0x48")]
	private UIBigEventFriendCallbackAddFriendView m_View;

	[Token(Token = "0x400BFFE")]
	[FieldOffset(Offset = "0x4C")]
	private FriendAccountInfo m_Data;

	[Token(Token = "0x400BFFF")]
	[FieldOffset(Offset = "0x50")]
	private UIBaseProfileInfoController m_BaseProfile;

	[Token(Token = "0x400C000")]
	[FieldOffset(Offset = "0x54")]
	private Action m_afterAddAction;

	[Token(Token = "0x400C001")]
	[FieldOffset(Offset = "0x58")]
	protected new UIPopupGlassBG m_Glass;

	[Token(Token = "0x400C002")]
	[FieldOffset(Offset = "0x5C")]
	public new UIGlassBGController GlassCtrl;

	[Token(Token = "0x60092DB")]
	[Address(RVA = "0x1414A80", Offset = "0x1414A80", VA = "0x1414A80")]
	public UIBigEventFriendCallbackAddFriendController()
	{
	}

	[Token(Token = "0x60092DC")]
	[Address(RVA = "0x1414A88", Offset = "0x1414A88", VA = "0x1414A88")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60092DD")]
	[Address(RVA = "0x1414B30", Offset = "0x1414B30", VA = "0x1414B30", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60092DE")]
	[Address(RVA = "0x1414FCC", Offset = "0x1414FCC", VA = "0x1414FCC")]
	protected void OnBtnCloseClicked()
	{
	}

	[Token(Token = "0x60092DF")]
	[Address(RVA = "0x14150E4", Offset = "0x14150E4", VA = "0x14150E4")]
	public void SetData(FriendAccountInfo data, Action action)
	{
	}

	[Token(Token = "0x60092E0")]
	[Address(RVA = "0x1415468", Offset = "0x1415468", VA = "0x1415468")]
	private void OnBtnReWriteClicked()
	{
	}

	[Token(Token = "0x60092E1")]
	[Address(RVA = "0x1415580", Offset = "0x1415580", VA = "0x1415580")]
	private void OnBtnAddFriendClicked()
	{
	}

	[Token(Token = "0x60092E2")]
	[Address(RVA = "0x1415748", Offset = "0x1415748", VA = "0x1415748")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
