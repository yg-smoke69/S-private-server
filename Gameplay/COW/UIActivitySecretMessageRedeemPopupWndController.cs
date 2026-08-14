using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001F76")]
public class UIActivitySecretMessageRedeemPopupWndController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x400C58A")]
	private const string DEFAULT_INPUT_TEXT_KEY = "T_35_FH_SECRETMISSION_INPUTNOLIMIT";

	[Token(Token = "0x400C58B")]
	private const string DISABLE_INPUT_TEXT_KEY = "T_35_FH_SECRETMISSION_INPUTLIMIT";

	[Token(Token = "0x400C58C")]
	private const string SECRET_MESSAGE_REDEEM_RULE_KEY = "T_35_FH_SECRETMISSION_INPUTRULE";

	[Token(Token = "0x400C58D")]
	private const string ILLEGAL_INPUT_VALUE_TIPS_KEY = "T_35_FH_SECRETMISSION_UNKOWNINPUT";

	[Token(Token = "0x400C58E")]
	private const string PREFIX_CODE_NOT_FOUND_TIPS_KEY = "BR_SECRET_MISSION_FRONT_KEY_ERR";

	[Token(Token = "0x400C58F")]
	private const string EXCHANGE_SUCCESS_KEY = "T_35_FH_SECRETMISSION_INPUTSUCCESS";

	[Token(Token = "0x400C590")]
	private const string GUIDE_STEP1_KEY = "SecretMessage_RedeemGuide_Step1_Account{0}";

	[Token(Token = "0x400C591")]
	[FieldOffset(Offset = "0x48")]
	private uint m_ActivityID;

	[Token(Token = "0x400C592")]
	[FieldOffset(Offset = "0x4C")]
	private uint m_SecretMessageID;

	[Token(Token = "0x400C593")]
	[FieldOffset(Offset = "0x50")]
	private uint m_DelayExecuteGuidePeek;

	[Token(Token = "0x400C594")]
	[FieldOffset(Offset = "0x54")]
	private UIActivitySecretMessageRedeemPopupWndView m_View;

	[Token(Token = "0x400C595")]
	[FieldOffset(Offset = "0x58")]
	private readonly Queue<UICommonGuideData> m_GuideDataQueue;

	[Token(Token = "0x6009C18")]
	[Address(RVA = "0x2FC4AC8", Offset = "0x2FC4AC8", VA = "0x2FC4AC8")]
	public UIActivitySecretMessageRedeemPopupWndController()
	{
	}

	[Token(Token = "0x6009C19")]
	[Address(RVA = "0x2FC4B54", Offset = "0x2FC4B54", VA = "0x2FC4B54")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009C1A")]
	[Address(RVA = "0x2FC4BFC", Offset = "0x2FC4BFC", VA = "0x2FC4BFC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009C1B")]
	[Address(RVA = "0x2FC52B8", Offset = "0x2FC52B8", VA = "0x2FC52B8", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6009C1C")]
	[Address(RVA = "0x2FC5460", Offset = "0x2FC5460", VA = "0x2FC5460", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6009C1D")]
	[Address(RVA = "0x2FC6340", Offset = "0x2FC6340", VA = "0x2FC6340", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6009C1E")]
	[Address(RVA = "0x2FC5E7C", Offset = "0x2FC5E7C", VA = "0x2FC5E7C")]
	private void OnSecretMessageExchanged(bool success)
	{
	}

	[Token(Token = "0x6009C1F")]
	[Address(RVA = "0x2FC63F8", Offset = "0x2FC63F8", VA = "0x2FC63F8")]
	private string GetSecondRule()
	{
		return null;
	}

	[Token(Token = "0x6009C20")]
	[Address(RVA = "0x2FC4FB8", Offset = "0x2FC4FB8", VA = "0x2FC4FB8")]
	private void SetupDefaultState()
	{
	}

	[Token(Token = "0x6009C21")]
	[Address(RVA = "0x2FC5664", Offset = "0x2FC5664", VA = "0x2FC5664")]
	private void RefreshHelpTipsLabel()
	{
	}

	[Token(Token = "0x6009C22")]
	[Address(RVA = "0x2FC5910", Offset = "0x2FC5910", VA = "0x2FC5910")]
	private void RefreshPopupWndTitle()
	{
	}

	[Token(Token = "0x6009C23")]
	[Address(RVA = "0x2FC5A48", Offset = "0x2FC5A48", VA = "0x2FC5A48")]
	private void RefreshConfirmBtn()
	{
	}

	[Token(Token = "0x6009C24")]
	[Address(RVA = "0x2FC6028", Offset = "0x2FC6028", VA = "0x2FC6028")]
	private void RefreshSecretMessageInput(bool clearInputValue)
	{
	}

	[Token(Token = "0x6009C25")]
	[Address(RVA = "0x2FC66F0", Offset = "0x2FC66F0", VA = "0x2FC66F0")]
	private void ClearSecretMessageInput()
	{
	}

	[Token(Token = "0x6009C26")]
	[Address(RVA = "0x2FC6800", Offset = "0x2FC6800", VA = "0x2FC6800")]
	private void OnConfirmBtnClick()
	{
	}

	[Token(Token = "0x6009C27")]
	[Address(RVA = "0x2FC6D4C", Offset = "0x2FC6D4C", VA = "0x2FC6D4C")]
	private void OnPasteBtnClick()
	{
	}

	[Token(Token = "0x6009C28")]
	[Address(RVA = "0x2FC6E64", Offset = "0x2FC6E64", VA = "0x2FC6E64")]
	private void OnSecretMessageInputChanged()
	{
	}

	[Token(Token = "0x6009C29")]
	[Address(RVA = "0x2FC4D9C", Offset = "0x2FC4D9C", VA = "0x2FC4D9C")]
	private void AddEventDelegate()
	{
	}

	[Token(Token = "0x6009C2A")]
	[Address(RVA = "0x2FC5324", Offset = "0x2FC5324", VA = "0x2FC5324")]
	private void StopGuideQueue()
	{
	}

	[Token(Token = "0x6009C2B")]
	[Address(RVA = "0x2FC6EC4", Offset = "0x2FC6EC4", VA = "0x2FC6EC4")]
	private void PrepareGuideQueueData()
	{
	}

	[Token(Token = "0x6009C2C")]
	[Address(RVA = "0x2FC5CB0", Offset = "0x2FC5CB0", VA = "0x2FC5CB0")]
	private void StartDelayExecuteGuidePeek()
	{
	}

	[Token(Token = "0x6009C2D")]
	[Address(RVA = "0x2FC7258", Offset = "0x2FC7258", VA = "0x2FC7258")]
	private void DelayExecuteGuidePeek()
	{
	}

	[Token(Token = "0x6009C2E")]
	[Address(RVA = "0x2FC7648", Offset = "0x2FC7648", VA = "0x2FC7648")]
	private void PopAndExecuteNext()
	{
	}

	[Token(Token = "0x6009C2F")]
	[Address(RVA = "0x2FC7918", Offset = "0x2FC7918", VA = "0x2FC7918")]
	public void SetViewData(uint activityID)
	{
	}

	[Token(Token = "0x6009C30")]
	[Address(RVA = "0x2FC7AEC", Offset = "0x2FC7AEC", VA = "0x2FC7AEC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009C31")]
	[Address(RVA = "0x2FC7AF4", Offset = "0x2FC7AF4", VA = "0x2FC7AF4")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
