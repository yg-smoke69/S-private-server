using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200233A")]
public class UIHudSceneEditModeEditWndController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x400DB72")]
	[FieldOffset(Offset = "0x48")]
	private UIHudSceneEditModeEditWndView m_View;

	[Token(Token = "0x400DB73")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelUGCModeEdit m_Model;

	[Token(Token = "0x400DB74")]
	[FieldOffset(Offset = "0x50")]
	private List<ModeEditTabData> m_ModeEditTabData;

	[Token(Token = "0x400DB75")]
	[FieldOffset(Offset = "0x54")]
	private ModeEditTabType m_CurrentModeEditTabType;

	[Token(Token = "0x400DB76")]
	[FieldOffset(Offset = "0x58")]
	private UIRuleToggleButtonGroupSettingController m_GameMode;

	[Token(Token = "0x400DB77")]
	[FieldOffset(Offset = "0x5C")]
	private List<UIBaseController> m_RuleList;

	[Token(Token = "0x400DB78")]
	[FieldOffset(Offset = "0x60")]
	private UIRuleEndConditionSettingController m_CurrentEndCondition;

	[Token(Token = "0x400DB79")]
	[FieldOffset(Offset = "0x64")]
	private UIRuleSafeZoneSettingController m_SafeZoneSettingController;

	[Token(Token = "0x400DB7A")]
	[FieldOffset(Offset = "0x68")]
	private UIRuleNumericSettingController m_MaxHP;

	[Token(Token = "0x400DB7B")]
	[FieldOffset(Offset = "0x6C")]
	private UIRuleNumericSettingController m_MaxEP;

	[Token(Token = "0x400DB7C")]
	[FieldOffset(Offset = "0x70")]
	private UIRuleNumericSettingController m_StartEP;

	[Token(Token = "0x400DB7D")]
	[FieldOffset(Offset = "0x74")]
	private UIRuleToggleSettingController m_AutoHealing;

	[Token(Token = "0x400DB7E")]
	[FieldOffset(Offset = "0x78")]
	private UIRuleToggleSettingController m_LimitedAmmo;

	[Token(Token = "0x400DB7F")]
	[FieldOffset(Offset = "0x7C")]
	private UIRuleNumericSettingController m_Damage;

	[Token(Token = "0x400DB80")]
	[FieldOffset(Offset = "0x80")]
	private UIRuleNumericSettingController m_Damaged;

	[Token(Token = "0x400DB81")]
	[FieldOffset(Offset = "0x84")]
	private UIRuleNumericSettingController m_MoveSpeed;

	[Token(Token = "0x400DB82")]
	[FieldOffset(Offset = "0x88")]
	private UIRuleNumericSettingController m_JumpHeight;

	[Token(Token = "0x600C3A4")]
	[Address(RVA = "0x24DFB94", Offset = "0x24DFB94", VA = "0x24DFB94")]
	public UIHudSceneEditModeEditWndController()
	{
	}

	[Token(Token = "0x600C3A5")]
	[Address(RVA = "0x24DFC20", Offset = "0x24DFC20", VA = "0x24DFC20")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C3A6")]
	[Address(RVA = "0x24DFCC8", Offset = "0x24DFCC8", VA = "0x24DFCC8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C3A7")]
	[Address(RVA = "0x24E1FFC", Offset = "0x24E1FFC", VA = "0x24E1FFC", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600C3A8")]
	[Address(RVA = "0x24E2130", Offset = "0x24E2130", VA = "0x24E2130")]
	public void SetTitleKey()
	{
	}

	[Token(Token = "0x600C3A9")]
	[Address(RVA = "0x24E21E0", Offset = "0x24E21E0", VA = "0x24E21E0")]
	private void OnSelectTab(object[] param)
	{
	}

	[Token(Token = "0x600C3AA")]
	[Address(RVA = "0x24E23E4", Offset = "0x24E23E4", VA = "0x24E23E4")]
	private void OnGameModeSelected(int index, int newValue)
	{
	}

	[Token(Token = "0x600C3AB")]
	[Address(RVA = "0x24E24A0", Offset = "0x24E24A0", VA = "0x24E24A0")]
	private void ResetModeSettings()
	{
	}

	[Token(Token = "0x600C3AC")]
	[Address(RVA = "0x24E0FF4", Offset = "0x24E0FF4", VA = "0x24E0FF4")]
	private void ChangeGameMode(uint mode)
	{
	}

	[Token(Token = "0x600C3AD")]
	[Address(RVA = "0x24E26B0", Offset = "0x24E26B0", VA = "0x24E26B0")]
	private void ChangeGroupModeSelected(int index, int newValue)
	{
	}

	[Token(Token = "0x600C3AE")]
	[Address(RVA = "0x24E279C", Offset = "0x24E279C", VA = "0x24E279C")]
	private void MarkDataChanged()
	{
	}

	[Token(Token = "0x600C3AF")]
	[Address(RVA = "0x24E2824", Offset = "0x24E2824", VA = "0x24E2824")]
	private void OnBthReset()
	{
	}

	[Token(Token = "0x600C3B0")]
	[Address(RVA = "0x24E2C8C", Offset = "0x24E2C8C", VA = "0x24E2C8C", Slot = "21")]
	public override void Show()
	{
	}

	[Token(Token = "0x600C3B1")]
	[Address(RVA = "0x24E2D94", Offset = "0x24E2D94", VA = "0x24E2D94", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600C3B2")]
	[Address(RVA = "0x24E2E94", Offset = "0x24E2E94", VA = "0x24E2E94", Slot = "46")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600C3B3")]
	[Address(RVA = "0x24E2F8C", Offset = "0x24E2F8C", VA = "0x24E2F8C", Slot = "47")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600C3B4")]
	[Address(RVA = "0x24E3008", Offset = "0x24E3008", VA = "0x24E3008")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C3B5")]
	[Address(RVA = "0x24E3010", Offset = "0x24E3010", VA = "0x24E3010")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600C3B6")]
	[Address(RVA = "0x24E3018", Offset = "0x24E3018", VA = "0x24E3018")]
	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	[Token(Token = "0x600C3B7")]
	[Address(RVA = "0x24E3020", Offset = "0x24E3020", VA = "0x24E3020")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
