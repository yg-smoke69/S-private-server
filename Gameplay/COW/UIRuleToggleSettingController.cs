using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002316")]
public class UIRuleToggleSettingController : UIBaseController
{
	[Token(Token = "0x400DACE")]
	[FieldOffset(Offset = "0x28")]
	private UIRuleToggleSettingView m_View;

	[Token(Token = "0x400DACF")]
	[FieldOffset(Offset = "0x2C")]
	private UIToggleButtonGroup m_ToggleButtonGroup;

	[Token(Token = "0x400DAD0")]
	[FieldOffset(Offset = "0x30")]
	private UIToggleButton m_Left;

	[Token(Token = "0x400DAD1")]
	[FieldOffset(Offset = "0x34")]
	public ToggleRuleSetting Data;

	[Token(Token = "0x400DAD2")]
	[FieldOffset(Offset = "0x38")]
	public Action OnDataChanged;

	[Token(Token = "0x600C22A")]
	[Address(RVA = "0x1426FB0", Offset = "0x1426FB0", VA = "0x1426FB0")]
	public UIRuleToggleSettingController()
	{
	}

	[Token(Token = "0x600C22B")]
	[Address(RVA = "0x1427034", Offset = "0x1427034", VA = "0x1427034")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C22C")]
	[Address(RVA = "0x14270DC", Offset = "0x14270DC", VA = "0x14270DC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C22D")]
	[Address(RVA = "0x1427220", Offset = "0x1427220", VA = "0x1427220")]
	public void Init(ToggleRuleSetting data)
	{
	}

	[Token(Token = "0x600C22E")]
	[Address(RVA = "0x1427594", Offset = "0x1427594", VA = "0x1427594")]
	public void Reset()
	{
	}

	[Token(Token = "0x600C22F")]
	[Address(RVA = "0x1427724", Offset = "0x1427724", VA = "0x1427724")]
	public void ShowTip()
	{
	}

	[Token(Token = "0x600C230")]
	[Address(RVA = "0x142798C", Offset = "0x142798C", VA = "0x142798C")]
	private void OnToggle(UIToggleButton btn)
	{
	}

	[Token(Token = "0x600C231")]
	[Address(RVA = "0x142764C", Offset = "0x142764C", VA = "0x142764C")]
	private void SetValue(bool newValue)
	{
	}

	[Token(Token = "0x600C232")]
	[Address(RVA = "0x1427A74", Offset = "0x1427A74", VA = "0x1427A74")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
