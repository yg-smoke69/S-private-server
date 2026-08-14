using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW;

[Token(Token = "0x20022EC")]
public class UIRushingPetsCreateRoom : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x400D9FD")]
	protected const uint Const_PlyerCount = 20u;

	[Token(Token = "0x400D9FE")]
	protected const uint Const_MapID = 12u;

	[Token(Token = "0x400D9FF")]
	protected const uint Const_GameModeID = 44u;

	[Token(Token = "0x400DA00")]
	[FieldOffset(Offset = "0x48")]
	protected UIRushingPetsCreateRoomView m_View;

	[Token(Token = "0x400DA01")]
	[FieldOffset(Offset = "0x4C")]
	protected Dictionary<string, CSVBaseData> m_CsvDataMap;

	[Token(Token = "0x400DA02")]
	[FieldOffset(Offset = "0x50")]
	protected UIRoomCardListController m_RoomCardCtrl;

	[Token(Token = "0x400DA03")]
	protected const int ROOM_CODE_MAX_LENGTH = 10;

	[Token(Token = "0x400DA04")]
	[FieldOffset(Offset = "0x54")]
	protected UIStandardTabController m_TabCtrl;

	[Token(Token = "0x400DA05")]
	[FieldOffset(Offset = "0x58")]
	protected Dictionary<uint, uint> m_DefaultParamsMap;

	[Token(Token = "0x400DA06")]
	[FieldOffset(Offset = "0x5C")]
	protected Dictionary<uint, uint> m_CurParamsMap;

	[Token(Token = "0x400DA07")]
	[FieldOffset(Offset = "0x60")]
	protected string m_RoomName;

	[Token(Token = "0x400DA08")]
	[FieldOffset(Offset = "0x64")]
	protected string m_Code;

	[Token(Token = "0x400DA09")]
	[FieldOffset(Offset = "0x68")]
	protected uint m_GroupMode;

	[Token(Token = "0x400DA0A")]
	[FieldOffset(Offset = "0x6C")]
	protected List<PopMenuData> m_DataList;

	[Token(Token = "0x400DA0B")]
	[FieldOffset(Offset = "0x70")]
	protected UIRoomDropListTemplateController roundCountCtrl;

	[Token(Token = "0x400DA0C")]
	[FieldOffset(Offset = "0x74")]
	protected UIRoomDropListTemplateController roundTimeCtrl;

	[Token(Token = "0x400DA0D")]
	[FieldOffset(Offset = "0x78")]
	protected uint roundCount;

	[Token(Token = "0x400DA0E")]
	[FieldOffset(Offset = "0x7C")]
	protected uint roundTime;

	[Token(Token = "0x400DA0F")]
	[FieldOffset(Offset = "0x80")]
	protected uint selectRound;

	[Token(Token = "0x400DA10")]
	[FieldOffset(Offset = "0x84")]
	protected List<uint> m_GameSettingTypes;

	[Token(Token = "0x400DA11")]
	[FieldOffset(Offset = "0x88")]
	protected List<GameObject> m_GameParamList;

	[Token(Token = "0x400DA12")]
	[FieldOffset(Offset = "0x0")]
	private static Action<string> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600C076")]
	[Address(RVA = "0x142A504", Offset = "0x142A504", VA = "0x142A504")]
	public UIRushingPetsCreateRoom()
	{
	}

	[Token(Token = "0x600C077")]
	[Address(RVA = "0x142A7F8", Offset = "0x142A7F8", VA = "0x142A7F8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C078")]
	[Address(RVA = "0x142A8A0", Offset = "0x142A8A0", VA = "0x142A8A0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C079")]
	[Address(RVA = "0x142B068", Offset = "0x142B068", VA = "0x142B068")]
	private void InitStandardTabs()
	{
	}

	[Token(Token = "0x600C07A")]
	[Address(RVA = "0x142C288", Offset = "0x142C288", VA = "0x142C288")]
	private void OnRoomSettingClick()
	{
	}

	[Token(Token = "0x600C07B")]
	[Address(RVA = "0x142C390", Offset = "0x142C390", VA = "0x142C390")]
	private void OnGameSettingClick()
	{
	}

	[Token(Token = "0x600C07C")]
	[Address(RVA = "0x142C498", Offset = "0x142C498", VA = "0x142C498", Slot = "48")]
	protected virtual void InitDefaultParams()
	{
	}

	[Token(Token = "0x600C07D")]
	[Address(RVA = "0x142B494", Offset = "0x142B494", VA = "0x142B494")]
	private void InitRoomSetting()
	{
	}

	[Token(Token = "0x600C07E")]
	[Address(RVA = "0x142C9C0", Offset = "0x142C9C0", VA = "0x142C9C0")]
	private void InitModeSelectUIComponent()
	{
	}

	[Token(Token = "0x600C07F")]
	[Address(RVA = "0x142CA20", Offset = "0x142CA20", VA = "0x142CA20")]
	private void SetFirstValidGroupMode()
	{
	}

	[Token(Token = "0x600C080")]
	[Address(RVA = "0x142CEF8", Offset = "0x142CEF8", VA = "0x142CEF8")]
	protected void OnSoloToggleClick()
	{
	}

	[Token(Token = "0x600C081")]
	[Address(RVA = "0x142CFC8", Offset = "0x142CFC8", VA = "0x142CFC8")]
	protected void OnDuoToggleClick()
	{
	}

	[Token(Token = "0x600C082")]
	[Address(RVA = "0x142D02C", Offset = "0x142D02C", VA = "0x142D02C")]
	protected void OnQuadToggleClick()
	{
	}

	[Token(Token = "0x600C083")]
	[Address(RVA = "0x142CF5C", Offset = "0x142CF5C", VA = "0x142CF5C")]
	protected void OnGroupModeToggleClick(uint groupMode)
	{
	}

	[Token(Token = "0x600C084")]
	[Address(RVA = "0x142CE28", Offset = "0x142CE28", VA = "0x142CE28")]
	protected UIToggleButton GetGroupModeToggleBtn(uint groupMode)
	{
		return null;
	}

	[Token(Token = "0x600C085")]
	[Address(RVA = "0x142B840", Offset = "0x142B840", VA = "0x142B840")]
	private void InitGameSetting()
	{
	}

	[Token(Token = "0x600C086")]
	[Address(RVA = "0x142D090", Offset = "0x142D090", VA = "0x142D090")]
	protected RushingPetsRoomSettingData GetSettingDataByType(DCNOOCAGCKC settingType)
	{
		return null;
	}

	[Token(Token = "0x600C087")]
	[Address(RVA = "0x142D628", Offset = "0x142D628", VA = "0x142D628")]
	private List<PopMenuData> GenerateRoundCountMenuData()
	{
		return null;
	}

	[Token(Token = "0x600C088")]
	[Address(RVA = "0x142D940", Offset = "0x142D940", VA = "0x142D940")]
	private void OnRoundCountSelected(object obj)
	{
	}

	[Token(Token = "0x600C089")]
	[Address(RVA = "0x142DA40", Offset = "0x142DA40", VA = "0x142DA40")]
	private List<PopMenuData> GenerateRoundTimeMenuData()
	{
		return null;
	}

	[Token(Token = "0x600C08A")]
	[Address(RVA = "0x142DD58", Offset = "0x142DD58", VA = "0x142DD58")]
	private void OnGameTimeSelected(object obj)
	{
	}

	[Token(Token = "0x600C08B")]
	[Address(RVA = "0x142D4F0", Offset = "0x142D4F0", VA = "0x142D4F0")]
	private void ChangeParamByType(DCNOOCAGCKC paramType, uint paramValue)
	{
	}

	[Token(Token = "0x600C08C")]
	[Address(RVA = "0x142DE58", Offset = "0x142DE58", VA = "0x142DE58")]
	private void OnClose()
	{
	}

	[Token(Token = "0x600C08D")]
	[Address(RVA = "0x142DEBC", Offset = "0x142DEBC", VA = "0x142DEBC", Slot = "49")]
	protected virtual void OnConfirm()
	{
	}

	[Token(Token = "0x600C08E")]
	[Address(RVA = "0x142ED60", Offset = "0x142ED60", VA = "0x142ED60", Slot = "50")]
	protected virtual void ProcessConfirmRoomInfo()
	{
	}

	[Token(Token = "0x600C08F")]
	[Address(RVA = "0x142EDC0", Offset = "0x142EDC0", VA = "0x142EDC0")]
	protected void RequestCreateRoom()
	{
	}

	[Token(Token = "0x600C090")]
	[Address(RVA = "0x142F3E4", Offset = "0x142F3E4", VA = "0x142F3E4", Slot = "51")]
	protected virtual bool NeedCheckRoomCard()
	{
		return default(bool);
	}

	[Token(Token = "0x600C091")]
	[Address(RVA = "0x142F43C", Offset = "0x142F43C", VA = "0x142F43C", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600C092")]
	[Address(RVA = "0x142F654", Offset = "0x142F654", VA = "0x142F654", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600C093")]
	[Address(RVA = "0x142F6E8", Offset = "0x142F6E8", VA = "0x142F6E8")]
	private static void _003COnConfirm_003Em__0(string s)
	{
	}

	[Token(Token = "0x600C094")]
	[Address(RVA = "0x142F930", Offset = "0x142F930", VA = "0x142F930")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
