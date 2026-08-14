using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002B6B")]
public class UITopButtonGroupController : UIBaseController, _Attribute
{
	[Token(Token = "0x40109FB")]
	[FieldOffset(Offset = "0x28")]
	private UITopButtonGroupView m_View;

	[Token(Token = "0x40109FC")]
	[FieldOffset(Offset = "0x2C")]
	private UIWidget m_FriendWidget;

	[Token(Token = "0x40109FD")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<int, UISprite> m_TokenSpriteDic;

	[Token(Token = "0x40109FE")]
	[FieldOffset(Offset = "0x34")]
	private Dictionary<int, UILabel> m_TokenCountLebelDic;

	[Token(Token = "0x40109FF")]
	[FieldOffset(Offset = "0x38")]
	private Dictionary<int, GameObject> m_TokenTimeLimitDic;

	[Token(Token = "0x4010A00")]
	[FieldOffset(Offset = "0x3C")]
	private Dictionary<int, UIButton> m_TokenButtonDic;

	[Token(Token = "0x4010A01")]
	[FieldOffset(Offset = "0x40")]
	private bool m_ShowManualBtn;

	[Token(Token = "0x4010A02")]
	[FieldOffset(Offset = "0x44")]
	private UIModelUser m_ModelUser;

	[Token(Token = "0x4010A03")]
	[FieldOffset(Offset = "0x48")]
	private readonly List<UITopButtonGotoTokenController> m_GotoTokenControllerList;

	[Token(Token = "0x4010A04")]
	private const float BATTERY_EMPTY_DISPLAY_SCALE = 0.1f;

	[Token(Token = "0x4010A05")]
	private const float BATTERY_LEVEL_THRESHOLD_LOW_MEDIUM = 0.2f;

	[Token(Token = "0x4010A06")]
	private const float BATTERY_LEVEL_THRESHOLD_MEDIUM_HIGH = 0.5f;

	[Token(Token = "0x4010A07")]
	[FieldOffset(Offset = "0x4C")]
	private readonly Color BATTERY_LEVEL_COLOR_LOW;

	[Token(Token = "0x4010A08")]
	[FieldOffset(Offset = "0x5C")]
	private readonly Color BATTERY_LEVEL_COLOR_MEDIUM;

	[Token(Token = "0x4010A09")]
	[FieldOffset(Offset = "0x6C")]
	private readonly Color BATTERY_LEVEL_COLOR_HIGH;

	[Token(Token = "0x4010A0A")]
	[FieldOffset(Offset = "0x7C")]
	private readonly Color BATTERY_LEVEL_COLOR_CHARGING;

	[Token(Token = "0x4010A0B")]
	[FieldOffset(Offset = "0x8C")]
	private Vector3 batteryLevelScale;

	[Token(Token = "0x4010A0C")]
	private const string NEW_SETTING_TIPS = "NEW_SETTING_TIPS";

	[Token(Token = "0x4010A0D")]
	private const string NEW_SETTING_TIPS_MAX_LOBBY = "NEW_SETTING_TIPS_MAX_LOBBY";

	[Token(Token = "0x6011E3E")]
	[Address(RVA = "0x2AE8CCC", Offset = "0x2AE8CCC", VA = "0x2AE8CCC")]
	public UITopButtonGroupController()
	{
	}

	[Token(Token = "0x6011E3F")]
	[Address(RVA = "0x2AE8EA0", Offset = "0x2AE8EA0", VA = "0x2AE8EA0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011E40")]
	[Address(RVA = "0x2AE8F44", Offset = "0x2AE8F44", VA = "0x2AE8F44", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011E41")]
	[Address(RVA = "0x2AEAEB4", Offset = "0x2AEAEB4", VA = "0x2AEAEB4", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x6011E42")]
	[Address(RVA = "0x2AEAF70", Offset = "0x2AEAF70", VA = "0x2AEAF70")]
	public Vector3 GetTitleLeftPos()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6011E43")]
	[Address(RVA = "0x2AEB008", Offset = "0x2AEB008", VA = "0x2AEB008")]
	public Transform GetCustomizedCtrlTrans()
	{
		return null;
	}

	[Token(Token = "0x6011E44")]
	[Address(RVA = "0x2AEB078", Offset = "0x2AEB078", VA = "0x2AEB078")]
	public void SetViewState(bool isLobby)
	{
	}

	[Token(Token = "0x6011E45")]
	[Address(RVA = "0x2AEB168", Offset = "0x2AEB168", VA = "0x2AEB168")]
	public void ShowNaviPage(bool show)
	{
	}

	[Token(Token = "0x6011E46")]
	[Address(RVA = "0x2AEB220", Offset = "0x2AEB220", VA = "0x2AEB220")]
	public void ShowHelpBtn(bool show)
	{
	}

	[Token(Token = "0x6011E47")]
	[Address(RVA = "0x2AEB314", Offset = "0x2AEB314", VA = "0x2AEB314")]
	public GameObject GetHelpBtn()
	{
		return null;
	}

	[Token(Token = "0x6011E48")]
	[Address(RVA = "0x2AEB3A0", Offset = "0x2AEB3A0", VA = "0x2AEB3A0")]
	public void NaviPageReposition()
	{
	}

	[Token(Token = "0x6011E49")]
	[Address(RVA = "0x2AEB434", Offset = "0x2AEB434", VA = "0x2AEB434")]
	public void ShowVoiceBtn(bool show)
	{
	}

	[Token(Token = "0x6011E4A")]
	[Address(RVA = "0x2AEB96C", Offset = "0x2AEB96C", VA = "0x2AEB96C")]
	public bool IsVoiceBtnShow()
	{
		return default(bool);
	}

	[Token(Token = "0x6011E4B")]
	[Address(RVA = "0x2AEB9F8", Offset = "0x2AEB9F8", VA = "0x2AEB9F8")]
	private void OnHelpBtnClick()
	{
	}

	[Token(Token = "0x6011E4C")]
	[Address(RVA = "0x2AEBB04", Offset = "0x2AEBB04", VA = "0x2AEBB04", Slot = "33")]
	protected virtual void OnBackButtonClick()
	{
	}

	[Token(Token = "0x6011E4D")]
	[Address(RVA = "0x2AEBC10", Offset = "0x2AEBC10", VA = "0x2AEBC10")]
	public void SetBackButton(Callback action)
	{
	}

	[Token(Token = "0x6011E4E")]
	[Address(RVA = "0x2AEBD68", Offset = "0x2AEBD68", VA = "0x2AEBD68")]
	private void OnMicBtnClick()
	{
	}

	[Token(Token = "0x6011E4F")]
	[Address(RVA = "0x2AEBE98", Offset = "0x2AEBE98", VA = "0x2AEBE98")]
	private void OnSpeackerBtnClick()
	{
	}

	[Token(Token = "0x6011E50")]
	[Address(RVA = "0x2AEC060", Offset = "0x2AEC060", VA = "0x2AEC060")]
	private void OnMicrophoneChanged(object[] data)
	{
	}

	[Token(Token = "0x6011E51")]
	[Address(RVA = "0x2AEB5B4", Offset = "0x2AEB5B4", VA = "0x2AEB5B4")]
	private void RefreshGameVoiceBtnView()
	{
	}

	[Token(Token = "0x6011E52")]
	[Address(RVA = "0x2AEC22C", Offset = "0x2AEC22C", VA = "0x2AEC22C")]
	private void OnMailBtnClick()
	{
	}

	[Token(Token = "0x6011E53")]
	[Address(RVA = "0x2AEC314", Offset = "0x2AEC314", VA = "0x2AEC314", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011E54")]
	[Address(RVA = "0x2AEC694", Offset = "0x2AEC694", VA = "0x2AEC694")]
	private void OnFriendBtnClick()
	{
	}

	[Token(Token = "0x6011E55")]
	[Address(RVA = "0x2AEC7A0", Offset = "0x2AEC7A0", VA = "0x2AEC7A0")]
	private void OnSettingBtnClick()
	{
	}

	[Token(Token = "0x6011E56")]
	[Address(RVA = "0x2AECDE4", Offset = "0x2AECDE4", VA = "0x2AECDE4")]
	private void OnSettingBtnInRoomClick()
	{
	}

	[Token(Token = "0x6011E57")]
	[Address(RVA = "0x2AECF18", Offset = "0x2AECF18", VA = "0x2AECF18")]
	public void ShowSettingBtnInNaviPage(bool show)
	{
	}

	[Token(Token = "0x6011E58")]
	[Address(RVA = "0x2AED00C", Offset = "0x2AED00C", VA = "0x2AED00C")]
	public void MailButtonEnabled(bool v)
	{
	}

	[Token(Token = "0x6011E59")]
	[Address(RVA = "0x2AED0A4", Offset = "0x2AED0A4", VA = "0x2AED0A4")]
	public void FriendButtonEnabled(bool v)
	{
	}

	[Token(Token = "0x6011E5A")]
	[Address(RVA = "0x2AED240", Offset = "0x2AED240", VA = "0x2AED240")]
	public UIWidget GetFriendWidget()
	{
		return null;
	}

	[Token(Token = "0x6011E5B")]
	[Address(RVA = "0x2AED298", Offset = "0x2AED298", VA = "0x2AED298")]
	public void SettingButtonEnabled(bool v)
	{
	}

	[Token(Token = "0x6011E5C")]
	[Address(RVA = "0x2AED330", Offset = "0x2AED330", VA = "0x2AED330", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6011E5D")]
	[Address(RVA = "0x2AEA0F0", Offset = "0x2AEA0F0", VA = "0x2AEA0F0")]
	private void UpdateMailTips()
	{
	}

	[Token(Token = "0x6011E5E")]
	[Address(RVA = "0x2AEA378", Offset = "0x2AEA378", VA = "0x2AEA378")]
	private void UpdateLobbySettingTips()
	{
	}

	[Token(Token = "0x6011E5F")]
	[Address(RVA = "0x2AED6A8", Offset = "0x2AED6A8", VA = "0x2AED6A8")]
	private void UpdateLobbyMailBtnTips(object[] data)
	{
	}

	[Token(Token = "0x6011E60")]
	[Address(RVA = "0x2AED8E0", Offset = "0x2AED8E0", VA = "0x2AED8E0", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6011E61")]
	[Address(RVA = "0x2AEA4C8", Offset = "0x2AEA4C8", VA = "0x2AEA4C8")]
	private void UpdateBattery(object[] parameters)
	{
	}

	[Token(Token = "0x6011E62")]
	[Address(RVA = "0x2AED9E0", Offset = "0x2AED9E0", VA = "0x2AED9E0")]
	public void UpdateTitle(string title)
	{
	}

	[Token(Token = "0x6011E63")]
	[Address(RVA = "0x2AEA818", Offset = "0x2AEA818", VA = "0x2AEA818")]
	public void CheckTips()
	{
	}

	[Token(Token = "0x6011E64")]
	[Address(RVA = "0x2AEC964", Offset = "0x2AEC964", VA = "0x2AEC964")]
	public void SetTips()
	{
	}

	[Token(Token = "0x6011E65")]
	[Address(RVA = "0x2AEDB4C", Offset = "0x2AEDB4C", VA = "0x2AEDB4C")]
	private int GetNewMAXLobbySetingTips()
	{
		return default(int);
	}

	[Token(Token = "0x6011E66")]
	[Address(RVA = "0x2AEDCC8", Offset = "0x2AEDCC8", VA = "0x2AEDCC8")]
	private void SetNewMAXLobbySettingTips(int value)
	{
	}

	[Token(Token = "0x6011E67")]
	[Address(RVA = "0x2AE9E8C", Offset = "0x2AE9E8C", VA = "0x2AE9E8C")]
	public void ResetTopItemState()
	{
	}

	[Token(Token = "0x6011E68")]
	[Address(RVA = "0x2AEDDB0", Offset = "0x2AEDDB0", VA = "0x2AEDDB0")]
	public void SetToken1Visibility(bool flag = false)
	{
	}

	[Token(Token = "0x6011E69")]
	[Address(RVA = "0x2AEDEA4", Offset = "0x2AEDEA4", VA = "0x2AEDEA4")]
	public void SetToken2Visibility(bool flag = false)
	{
	}

	[Token(Token = "0x6011E6A")]
	[Address(RVA = "0x2AEDF98", Offset = "0x2AEDF98", VA = "0x2AEDF98")]
	public void HideGotoBtnVisibility(bool flag = false)
	{
	}

	[Token(Token = "0x6011E6B")]
	[Address(RVA = "0x2AEE0E4", Offset = "0x2AEE0E4", VA = "0x2AEE0E4")]
	public void UpdateCustomizedBtn(string key, Callback callBack)
	{
	}

	[Token(Token = "0x6011E6C")]
	[Address(RVA = "0x2AEE378", Offset = "0x2AEE378", VA = "0x2AEE378")]
	public void UpdateGotoBtnShow(ResourceID GotoSpriteID, ResourceID GotoTagID, string label)
	{
	}

	[Token(Token = "0x6011E6D")]
	[Address(RVA = "0x2AEE8B8", Offset = "0x2AEE8B8", VA = "0x2AEE8B8")]
	public void UpdateGotoBtnShow(string GotoSpriteName, string GototagSpriteName, string label)
	{
	}

	[Token(Token = "0x6011E6E")]
	[Address(RVA = "0x2AEEAA8", Offset = "0x2AEEAA8", VA = "0x2AEEAA8")]
	public void UpdateTokenByIndex(int index, ResourceID id, int num, bool timeLimit = false)
	{
	}

	[Token(Token = "0x6011E6F")]
	[Address(RVA = "0x2AEEDE0", Offset = "0x2AEEDE0", VA = "0x2AEEDE0")]
	public void UpdateTokenByIndex(int index, string spriteName, int num, bool timeLimit = false)
	{
	}

	[Token(Token = "0x6011E70")]
	[Address(RVA = "0x2AEEF78", Offset = "0x2AEEF78", VA = "0x2AEEF78")]
	internal void AddGotoToken(EInventory.AwardType tokenType, uint tokenID, [Optional] Callback onGotoBtnClick, [Optional] string customizedSprite, UIUtils.SpriteScaleType scaleType = UIUtils.SpriteScaleType.Fit, bool makePixelPerfect = false)
	{
	}

	[Token(Token = "0x6011E71")]
	[Address(RVA = "0x2AEF158", Offset = "0x2AEF158", VA = "0x2AEF158")]
	public void CloseAllGotoToken(bool reposition = true)
	{
	}

	[Token(Token = "0x6011E72")]
	[Address(RVA = "0x2AEF368", Offset = "0x2AEF368", VA = "0x2AEF368")]
	public Transform GetTokenTransformByIndex(int index)
	{
		return null;
	}

	[Token(Token = "0x6011E73")]
	[Address(RVA = "0x2AEF490", Offset = "0x2AEF490", VA = "0x2AEF490")]
	public UIButton GetTokenBtnByIndex(int index)
	{
		return null;
	}

	[Token(Token = "0x6011E74")]
	[Address(RVA = "0x2AEF598", Offset = "0x2AEF598", VA = "0x2AEF598")]
	public Transform GetExchangeTransform()
	{
		return null;
	}

	[Token(Token = "0x6011E75")]
	[Address(RVA = "0x2AEF624", Offset = "0x2AEF624", VA = "0x2AEF624")]
	private void OnToken1Click()
	{
	}

	[Token(Token = "0x6011E76")]
	[Address(RVA = "0x2AEF84C", Offset = "0x2AEF84C", VA = "0x2AEF84C")]
	private void OnToken2Click()
	{
	}

	[Token(Token = "0x6011E77")]
	[Address(RVA = "0x2AEFA74", Offset = "0x2AEFA74", VA = "0x2AEFA74")]
	private void OnExchangeStoreClick()
	{
	}

	[Token(Token = "0x6011E78")]
	[Address(RVA = "0x2AEFBAC", Offset = "0x2AEFBAC", VA = "0x2AEFBAC")]
	private void OnLeaderBoardClick()
	{
	}

	[Token(Token = "0x6011E79")]
	[Address(RVA = "0x2AEFD8C", Offset = "0x2AEFD8C", VA = "0x2AEFD8C")]
	private void OnManualBtnClick()
	{
	}

	[Token(Token = "0x6011E7A")]
	[Address(RVA = "0x2AEFE98", Offset = "0x2AEFE98", VA = "0x2AEFE98")]
	private void OnArrowBtnClick()
	{
	}

	[Token(Token = "0x6011E7B")]
	[Address(RVA = "0x2AEA09C", Offset = "0x2AEA09C", VA = "0x2AEA09C")]
	private void InitManual()
	{
	}

	[Token(Token = "0x6011E7C")]
	[Address(RVA = "0x2AED488", Offset = "0x2AED488", VA = "0x2AED488")]
	private void SetManualTips()
	{
	}

	[Token(Token = "0x6011E7D")]
	[Address(RVA = "0x2AEABA8", Offset = "0x2AEABA8", VA = "0x2AEABA8")]
	private bool SetButtonManualShow()
	{
		return default(bool);
	}

	[Token(Token = "0x6011E7E")]
	[Address(RVA = "0x2AF0190", Offset = "0x2AF0190", VA = "0x2AF0190")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011E7F")]
	[Address(RVA = "0x2AF0198", Offset = "0x2AF0198", VA = "0x2AF0198")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x6011E80")]
	[Address(RVA = "0x2AF01A0", Offset = "0x2AF01A0", VA = "0x2AF01A0")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
