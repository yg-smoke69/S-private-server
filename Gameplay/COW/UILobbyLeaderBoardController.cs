using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002929")]
internal class UILobbyLeaderBoardController : UIBaseController, _Attribute
{
	[Token(Token = "0x400FD79")]
	[FieldOffset(Offset = "0x28")]
	private UILobbyLeaderBoardView m_View;

	[Token(Token = "0x400FD7A")]
	[FieldOffset(Offset = "0x2C")]
	private List<LeaderBoardInfo> m_TopRankList;

	[Token(Token = "0x60105A2")]
	[Address(RVA = "0xDBAD1C", Offset = "0xDBAD1C", VA = "0xDBAD1C")]
	public UILobbyLeaderBoardController()
	{
	}

	[Token(Token = "0x60105A3")]
	[Address(RVA = "0xDBADD4", Offset = "0xDBADD4", VA = "0xDBADD4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60105A4")]
	[Address(RVA = "0xDBAE78", Offset = "0xDBAE78", VA = "0xDBAE78", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60105A5")]
	[Address(RVA = "0xDBB1B4", Offset = "0xDBB1B4", VA = "0xDBB1B4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60105A6")]
	[Address(RVA = "0xDBB2E4", Offset = "0xDBB2E4", VA = "0xDBB2E4")]
	private void SetUIData()
	{
	}

	[Token(Token = "0x60105A7")]
	[Address(RVA = "0xDBB6CC", Offset = "0xDBB6CC", VA = "0xDBB6CC")]
	private void OnInitContent(GameObject go, int wrapIndex, int realIndex)
	{
	}

	[Token(Token = "0x60105A8")]
	[Address(RVA = "0xDBB7F4", Offset = "0xDBB7F4", VA = "0xDBB7F4")]
	private void OnMoreClick()
	{
	}

	[Token(Token = "0x60105A9")]
	[Address(RVA = "0xDBB848", Offset = "0xDBB848", VA = "0xDBB848", Slot = "31")]
	private void GCommon_002EIUIModelDataChangeObserver_002EOnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x60105AA")]
	[Address(RVA = "0xDBBA94", Offset = "0xDBBA94", VA = "0xDBBA94", Slot = "32")]
	private uint GCommon_002EIUIModelDataChangeObserver_002EGetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x60105AB")]
	[Address(RVA = "0xDBBB28", Offset = "0xDBBB28", VA = "0xDBBB28")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60105AC")]
	[Address(RVA = "0xDBBB30", Offset = "0xDBBB30", VA = "0xDBBB30")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
