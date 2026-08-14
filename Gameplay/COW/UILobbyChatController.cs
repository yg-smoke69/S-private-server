using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200291F")]
public class UILobbyChatController : UIBaseController, _Attribute
{
	[Token(Token = "0x400FD3C")]
	[FieldOffset(Offset = "0x28")]
	private UILobbyChatView m_View;

	[Token(Token = "0x400FD3D")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelChat m_ChatModel;

	[Token(Token = "0x400FD3E")]
	[FieldOffset(Offset = "0x30")]
	private UIModelGroup m_GroupModel;

	[Token(Token = "0x400FD3F")]
	[FieldOffset(Offset = "0x34")]
	private uint m_MessageDispearCallID;

	[Token(Token = "0x400FD40")]
	[FieldOffset(Offset = "0x38")]
	private int m_MessageLabelOrigWidth;

	[Token(Token = "0x400FD41")]
	[FieldOffset(Offset = "0x0")]
	public static Vector3 LOBBY_CHAT_POSITION;

	[Token(Token = "0x400FD42")]
	[FieldOffset(Offset = "0xC")]
	public static Vector3 LOBBY_CHAT_OFFSET_POSITION;

	[Token(Token = "0x400FD43")]
	[FieldOffset(Offset = "0x18")]
	public static Vector3 CUSTOMROOM_CHAT_POSITION;

	[Token(Token = "0x400FD44")]
	[FieldOffset(Offset = "0x24")]
	public static Vector3 CHAT_POSITION_WHEN_UPPERRIGHT;

	[Token(Token = "0x60104F9")]
	[Address(RVA = "0x216D834", Offset = "0x216D834", VA = "0x216D834")]
	public UILobbyChatController()
	{
	}

	[Token(Token = "0x60104FA")]
	[Address(RVA = "0x216D8B8", Offset = "0x216D8B8", VA = "0x216D8B8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60104FB")]
	[Address(RVA = "0x216D95C", Offset = "0x216D95C", VA = "0x216D95C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60104FC")]
	[Address(RVA = "0x216E184", Offset = "0x216E184", VA = "0x216E184")]
	private void OnRecruitBtnClick()
	{
	}

	[Token(Token = "0x60104FD")]
	[Address(RVA = "0x216E8B8", Offset = "0x216E8B8", VA = "0x216E8B8")]
	private void OnFastSendGiftBtnClick()
	{
	}

	[Token(Token = "0x60104FE")]
	[Address(RVA = "0x216E90C", Offset = "0x216E90C", VA = "0x216E90C")]
	private void OnChatMessageBtnClick()
	{
	}

	[Token(Token = "0x60104FF")]
	[Address(RVA = "0x216EC00", Offset = "0x216EC00", VA = "0x216EC00", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6010500")]
	[Address(RVA = "0x216EEE4", Offset = "0x216EEE4", VA = "0x216EEE4")]
	private void OnChatBtnClick()
	{
	}

	[Token(Token = "0x6010501")]
	[Address(RVA = "0x216F42C", Offset = "0x216F42C", VA = "0x216F42C", Slot = "31")]
	private void GCommon_002EIUIModelDataChangeObserver_002EOnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6010502")]
	[Address(RVA = "0x216F69C", Offset = "0x216F69C", VA = "0x216F69C")]
	private void RefreshLatestMessage()
	{
	}

	[Token(Token = "0x6010503")]
	[Address(RVA = "0x216FA1C", Offset = "0x216FA1C", VA = "0x216FA1C")]
	private void OnScrollFinish()
	{
	}

	[Token(Token = "0x6010504")]
	[Address(RVA = "0x216FB84", Offset = "0x216FB84", VA = "0x216FB84", Slot = "32")]
	private uint GCommon_002EIUIModelDataChangeObserver_002EGetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6010505")]
	[Address(RVA = "0x216DF4C", Offset = "0x216DF4C", VA = "0x216DF4C")]
	private void RefreshBtnState(object[] data)
	{
	}

	[Token(Token = "0x6010507")]
	[Address(RVA = "0x216FD7C", Offset = "0x216FD7C", VA = "0x216FD7C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010508")]
	[Address(RVA = "0x216FD84", Offset = "0x216FD84", VA = "0x216FD84")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
