using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using tcp;

namespace COW;

[Token(Token = "0x2002354")]
public class UISceneEditRoomListController : UIBaseController, _Attribute, IConvertible
{
	[Token(Token = "0x400DC15")]
	private const int COOLDOWN_SECONDS = 30;

	[Token(Token = "0x400DC16")]
	[FieldOffset(Offset = "0x28")]
	private CountDownConfig config;

	[Token(Token = "0x400DC17")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelMall m_ModelMall;

	[Token(Token = "0x400DC18")]
	[FieldOffset(Offset = "0x30")]
	private UIModelCustomRoom m_ModelCustomRoom;

	[Token(Token = "0x400DC19")]
	[FieldOffset(Offset = "0x34")]
	private UISceneEditRoomListView m_View;

	[Token(Token = "0x400DC1A")]
	[FieldOffset(Offset = "0x38")]
	private ERoom.TabType m_RoomTabType;

	[Token(Token = "0x400DC1B")]
	[FieldOffset(Offset = "0x3C")]
	private bool m_HasRequested;

	[Token(Token = "0x400DC1C")]
	[FieldOffset(Offset = "0x3D")]
	private bool m_IsRefreshCountDown;

	[Token(Token = "0x400DC1D")]
	[FieldOffset(Offset = "0x3E")]
	private bool m_PlayedItemTweenAnim;

	[Token(Token = "0x600C4D4")]
	[Address(RVA = "0x2DA89CC", Offset = "0x2DA89CC", VA = "0x2DA89CC")]
	public UISceneEditRoomListController()
	{
	}

	[Token(Token = "0x600C4D5")]
	[Address(RVA = "0x2DA8A7C", Offset = "0x2DA8A7C", VA = "0x2DA8A7C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C4D6")]
	[Address(RVA = "0x2DA8B20", Offset = "0x2DA8B20", VA = "0x2DA8B20", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C4D7")]
	[Address(RVA = "0x2DA8FE0", Offset = "0x2DA8FE0", VA = "0x2DA8FE0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600C4D8")]
	[Address(RVA = "0x2DA9068", Offset = "0x2DA9068", VA = "0x2DA9068", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600C4D9")]
	[Address(RVA = "0x2DA9470", Offset = "0x2DA9470", VA = "0x2DA9470")]
	private void OnInputChanged()
	{
	}

	[Token(Token = "0x600C4DA")]
	[Address(RVA = "0x2DA9580", Offset = "0x2DA9580", VA = "0x2DA9580")]
	private void OnBtnInputClear()
	{
	}

	[Token(Token = "0x600C4DB")]
	[Address(RVA = "0x2DA9690", Offset = "0x2DA9690", VA = "0x2DA9690")]
	public void SearchRoomById(ERoom.Type roomType, string roomId)
	{
	}

	[Token(Token = "0x600C4DC")]
	[Address(RVA = "0x2DA9750", Offset = "0x2DA9750", VA = "0x2DA9750")]
	private void OnBtnRoomSearch()
	{
	}

	[Token(Token = "0x600C4DD")]
	[Address(RVA = "0x2DA9A54", Offset = "0x2DA9A54", VA = "0x2DA9A54")]
	private void OnBtnRoomRefresh()
	{
	}

	[Token(Token = "0x600C4DE")]
	[Address(RVA = "0x2DA9DCC", Offset = "0x2DA9DCC", VA = "0x2DA9DCC")]
	private void OnBtnRoomCreate()
	{
	}

	[Token(Token = "0x600C4DF")]
	[Address(RVA = "0x2DAA78C", Offset = "0x2DAA78C", VA = "0x2DAA78C")]
	private void RefreshRoomList(List<RoomBasicInfo> roomList)
	{
	}

	[Token(Token = "0x600C4E0")]
	[Address(RVA = "0x2DAAAF0", Offset = "0x2DAAAF0", VA = "0x2DAAAF0")]
	private void OnCountDownStarted()
	{
	}

	[Token(Token = "0x600C4E1")]
	[Address(RVA = "0x2DA9340", Offset = "0x2DA9340", VA = "0x2DA9340")]
	private void OnCountDownFinished()
	{
	}

	[Token(Token = "0x600C4E2")]
	[Address(RVA = "0x2DAAB88", Offset = "0x2DAAB88", VA = "0x2DAAB88", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600C4E3")]
	[Address(RVA = "0x2DAAC80", Offset = "0x2DAAC80", VA = "0x2DAAC80", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600C4E4")]
	[Address(RVA = "0x2DAAD14", Offset = "0x2DAAD14", VA = "0x2DAAD14", Slot = "33")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600C4E5")]
	[Address(RVA = "0x2DAAE98", Offset = "0x2DAAE98", VA = "0x2DAAE98", Slot = "34")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600C4E6")]
	[Address(RVA = "0x2DAAF14", Offset = "0x2DAAF14", VA = "0x2DAAF14")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C4E7")]
	[Address(RVA = "0x2DAAF1C", Offset = "0x2DAAF1C", VA = "0x2DAAF1C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600C4E8")]
	[Address(RVA = "0x2DAAF24", Offset = "0x2DAAF24", VA = "0x2DAAF24")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
