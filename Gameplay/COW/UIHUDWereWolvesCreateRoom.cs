using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using message;
using proto;

namespace COW;

[Token(Token = "0x2002C41")]
internal class UIHUDWereWolvesCreateRoom : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x4010DFF")]
	private const int TOGGLE_GROUP_ID = 117;

	[Token(Token = "0x4010E00")]
	protected const int ROOM_CODE_MAX_LENGTH = 10;

	[Token(Token = "0x4010E01")]
	protected const uint Const_GameModeID = 37u;

	[Token(Token = "0x4010E02")]
	protected const uint Const_MapID = 8u;

	[Token(Token = "0x4010E03")]
	[FieldOffset(Offset = "0x48")]
	protected UIWereWolvesCreateRoomView m_View;

	[Token(Token = "0x4010E04")]
	[FieldOffset(Offset = "0x4C")]
	protected UIModelCustomRoom m_CustomRoomModel;

	[Token(Token = "0x4010E05")]
	[FieldOffset(Offset = "0x50")]
	protected Dictionary<string, CSVBaseData> m_CsvDataMap;

	[Token(Token = "0x4010E06")]
	[FieldOffset(Offset = "0x54")]
	protected Dictionary<string, CSVBaseData> m_CsvDefaultParamsMap;

	[Token(Token = "0x4010E07")]
	[FieldOffset(Offset = "0x58")]
	protected Dictionary<uint, UIWereWolvesRoomParamItemController> m_GameParamControllerList;

	[Token(Token = "0x4010E08")]
	[FieldOffset(Offset = "0x5C")]
	protected Dictionary<uint, uint> m_DefaultParamsMap;

	[Token(Token = "0x4010E09")]
	[FieldOffset(Offset = "0x60")]
	protected Dictionary<uint, uint> m_CurParamsMap;

	[Token(Token = "0x4010E0A")]
	[FieldOffset(Offset = "0x64")]
	protected List<uint> m_GameSettingTypes;

	[Token(Token = "0x4010E0B")]
	[FieldOffset(Offset = "0x68")]
	protected UIRoomCardListController m_RoomCardCtrl;

	[Token(Token = "0x4010E0C")]
	[FieldOffset(Offset = "0x6C")]
	protected UIStandardTabController m_TabCtrl;

	[Token(Token = "0x4010E0D")]
	[FieldOffset(Offset = "0x70")]
	protected UIPopMenuSmallControler m_PlayerCountPopMenuSmallCtrl;

	[Token(Token = "0x4010E0E")]
	[FieldOffset(Offset = "0x74")]
	protected UIPopMenuSmallControler m_WolfCountPopMenuSmallCtrl;

	[Token(Token = "0x4010E0F")]
	[FieldOffset(Offset = "0x78")]
	protected List<PopMenuData> m_DataList;

	[Token(Token = "0x4010E10")]
	[FieldOffset(Offset = "0x7C")]
	private List<PopMenuData> m_LanguageDataList;

	[Token(Token = "0x4010E11")]
	[FieldOffset(Offset = "0x80")]
	protected ESocial.Language m_SelectedLanguage;

	[Token(Token = "0x4010E12")]
	[FieldOffset(Offset = "0x84")]
	protected string m_RoomName;

	[Token(Token = "0x4010E13")]
	[FieldOffset(Offset = "0x88")]
	protected string m_Code;

	[Token(Token = "0x4010E14")]
	[FieldOffset(Offset = "0x8C")]
	private UISelectLanguageController m_CurLanguagePage;

	[Token(Token = "0x4010E15")]
	[FieldOffset(Offset = "0x0")]
	private static Action<string> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x601272F")]
	[Address(RVA = "0x29364B0", Offset = "0x29364B0", VA = "0x29364B0")]
	public UIHUDWereWolvesCreateRoom()
	{
	}

	[Token(Token = "0x6012730")]
	[Address(RVA = "0x293676C", Offset = "0x293676C", VA = "0x293676C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012731")]
	[Address(RVA = "0x2936814", Offset = "0x2936814", VA = "0x2936814", Slot = "9")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6012732")]
	[Address(RVA = "0x2936884", Offset = "0x2936884", VA = "0x2936884", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6012733")]
	[Address(RVA = "0x29382A0", Offset = "0x29382A0", VA = "0x29382A0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6012734")]
	[Address(RVA = "0x29383D0", Offset = "0x29383D0", VA = "0x29383D0")]
	protected WereWolvesRoomSettingData GetSettingDataByType(IANLBOJBCIO settingType)
	{
		return null;
	}

	[Token(Token = "0x6012735")]
	[Address(RVA = "0x293851C", Offset = "0x293851C", VA = "0x293851C")]
	protected WereWolvesRoomDefaultParams GetDefaultParmasDataByPlayerCount(uint playerCount)
	{
		return null;
	}

	[Token(Token = "0x6012736")]
	[Address(RVA = "0x2938664", Offset = "0x2938664", VA = "0x2938664", Slot = "39")]
	protected override void OnInitDepth()
	{
	}

	[Token(Token = "0x6012737")]
	[Address(RVA = "0x29374D0", Offset = "0x29374D0", VA = "0x29374D0")]
	private void InitStandardTabs()
	{
	}

	[Token(Token = "0x6012738")]
	[Address(RVA = "0x29387E0", Offset = "0x29387E0", VA = "0x29387E0")]
	private void OnRoomSettingClick()
	{
	}

	[Token(Token = "0x6012739")]
	[Address(RVA = "0x29388E8", Offset = "0x29388E8", VA = "0x29388E8")]
	private void OnGameSettingClick()
	{
	}

	[Token(Token = "0x601273A")]
	[Address(RVA = "0x29389F0", Offset = "0x29389F0", VA = "0x29389F0", Slot = "48")]
	protected virtual void InitDefaultParams()
	{
	}

	[Token(Token = "0x601273B")]
	[Address(RVA = "0x2938FAC", Offset = "0x2938FAC", VA = "0x2938FAC")]
	private void RefreshDefaultParams(uint playerCount)
	{
	}

	[Token(Token = "0x601273C")]
	[Address(RVA = "0x29378FC", Offset = "0x29378FC", VA = "0x29378FC")]
	private void InitRoomSetting()
	{
	}

	[Token(Token = "0x601273D")]
	[Address(RVA = "0x2939B50", Offset = "0x2939B50", VA = "0x2939B50", Slot = "49")]
	protected virtual void InitLanguageUIComponent()
	{
	}

	[Token(Token = "0x601273E")]
	[Address(RVA = "0x29398A4", Offset = "0x29398A4", VA = "0x29398A4")]
	private void InitWolfCountUIComponent()
	{
	}

	[Token(Token = "0x601273F")]
	[Address(RVA = "0x2939C94", Offset = "0x2939C94", VA = "0x2939C94")]
	protected void GenerateWolfCountMenuData()
	{
	}

	[Token(Token = "0x6012740")]
	[Address(RVA = "0x2939FC8", Offset = "0x2939FC8", VA = "0x2939FC8", Slot = "50")]
	protected virtual void InitPlayerCountUIComponent()
	{
	}

	[Token(Token = "0x6012741")]
	[Address(RVA = "0x293A324", Offset = "0x293A324", VA = "0x293A324")]
	protected void GeneratePlayerCountMenuData()
	{
	}

	[Token(Token = "0x6012742")]
	[Address(RVA = "0x293A658", Offset = "0x293A658", VA = "0x293A658")]
	private void OnPlayerCountMenuSelected(object value)
	{
	}

	[Token(Token = "0x6012743")]
	[Address(RVA = "0x293A8E8", Offset = "0x293A8E8", VA = "0x293A8E8")]
	private void OnWolfCountMenuSelecte(object value)
	{
	}

	[Token(Token = "0x6012744")]
	[Address(RVA = "0x293A9AC", Offset = "0x293A9AC", VA = "0x293A9AC")]
	private void InitLanguageList()
	{
	}

	[Token(Token = "0x6012745")]
	[Address(RVA = "0x293AD10", Offset = "0x293AD10", VA = "0x293AD10", Slot = "51")]
	protected virtual void OnLanguageBtnClick()
	{
	}

	[Token(Token = "0x6012746")]
	[Address(RVA = "0x293AE58", Offset = "0x293AE58", VA = "0x293AE58")]
	private void OnLocLanguageSelect(object obj)
	{
	}

	[Token(Token = "0x6012747")]
	[Address(RVA = "0x2937CD0", Offset = "0x2937CD0", VA = "0x2937CD0")]
	private void InitGameSetting()
	{
	}

	[Token(Token = "0x6012748")]
	[Address(RVA = "0x293A72C", Offset = "0x293A72C", VA = "0x293A72C")]
	private void ChangeParamByType(IANLBOJBCIO paramType, uint paramValue)
	{
	}

	[Token(Token = "0x6012749")]
	[Address(RVA = "0x293954C", Offset = "0x293954C", VA = "0x293954C")]
	private void OnResetGameSetting()
	{
	}

	[Token(Token = "0x601274A")]
	[Address(RVA = "0x293B034", Offset = "0x293B034", VA = "0x293B034", Slot = "52")]
	protected virtual bool NeedCheckRoomCard()
	{
		return default(bool);
	}

	[Token(Token = "0x601274B")]
	[Address(RVA = "0x293B08C", Offset = "0x293B08C", VA = "0x293B08C", Slot = "53")]
	protected virtual void OnConfirm()
	{
	}

	[Token(Token = "0x601274C")]
	[Address(RVA = "0x293C160", Offset = "0x293C160", VA = "0x293C160", Slot = "54")]
	protected virtual void ProcessConfirmRoomInfo()
	{
	}

	[Token(Token = "0x601274D")]
	[Address(RVA = "0x293C1C0", Offset = "0x293C1C0", VA = "0x293C1C0")]
	protected void RequestCreateRoom()
	{
	}

	[Token(Token = "0x601274E")]
	[Address(RVA = "0x293C904", Offset = "0x293C904", VA = "0x293C904")]
	private void OnClose()
	{
	}

	[Token(Token = "0x601274F")]
	[Address(RVA = "0x293C968", Offset = "0x293C968", VA = "0x293C968")]
	private void OnTrapOn(UIToggleButton btn)
	{
	}

	[Token(Token = "0x6012750")]
	[Address(RVA = "0x293CA48", Offset = "0x293CA48", VA = "0x293CA48")]
	private void OnTrapOff(UIToggleButton btn)
	{
	}

	[Token(Token = "0x6012751")]
	[Address(RVA = "0x293CAB8", Offset = "0x293CAB8", VA = "0x293CAB8")]
	private void OnPredictOn(UIToggleButton btn)
	{
	}

	[Token(Token = "0x6012752")]
	[Address(RVA = "0x293CB28", Offset = "0x293CB28", VA = "0x293CB28")]
	private void OnPredictOff(UIToggleButton btn)
	{
	}

	[Token(Token = "0x6012753")]
	[Address(RVA = "0x293CB98", Offset = "0x293CB98", VA = "0x293CB98", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6012754")]
	[Address(RVA = "0x293CDB0", Offset = "0x293CDB0", VA = "0x293CDB0", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6012755")]
	[Address(RVA = "0x293CE44", Offset = "0x293CE44", VA = "0x293CE44")]
	private static void _003COnConfirm_003Em__0(string s)
	{
	}

	[Token(Token = "0x6012756")]
	[Address(RVA = "0x293D08C", Offset = "0x293D08C", VA = "0x293D08C")]
	public void _003C_003EiFixBaseProxy_Awake()
	{
	}

	[Token(Token = "0x6012757")]
	[Address(RVA = "0x293D094", Offset = "0x293D094", VA = "0x293D094")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6012758")]
	[Address(RVA = "0x293D09C", Offset = "0x293D09C", VA = "0x293D09C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x6012759")]
	[Address(RVA = "0x293D0A4", Offset = "0x293D0A4", VA = "0x293D0A4")]
	public void _003C_003EiFixBaseProxy_OnInitDepth()
	{
	}
}
