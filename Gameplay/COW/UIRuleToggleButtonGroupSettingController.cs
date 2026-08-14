using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002313")]
public class UIRuleToggleButtonGroupSettingController : UIBaseController, _Attribute
{
	[Token(Token = "0x400DAC1")]
	[FieldOffset(Offset = "0x28")]
	private UIRuleToggleButtonGroupSettingView m_View;

	[Token(Token = "0x400DAC2")]
	[FieldOffset(Offset = "0x2C")]
	public ToggleButtonGroupRuleSetting Data;

	[Token(Token = "0x400DAC3")]
	[FieldOffset(Offset = "0x30")]
	public Action<int, int> ItemSelectCallback;

	[Token(Token = "0x400DAC4")]
	[FieldOffset(Offset = "0x34")]
	private UIToggleButtonGroup m_ToggleButtonGroup;

	[Token(Token = "0x400DAC5")]
	[FieldOffset(Offset = "0x38")]
	private List<UIRuleToggleButtonController> m_ToggleButtons;

	[Token(Token = "0x400DAC6")]
	[FieldOffset(Offset = "0x3C")]
	public Action OnDataChanged;

	[Token(Token = "0x600C20A")]
	[Address(RVA = "0x142511C", Offset = "0x142511C", VA = "0x142511C")]
	public UIRuleToggleButtonGroupSettingController()
	{
	}

	[Token(Token = "0x600C20B")]
	[Address(RVA = "0x14251A0", Offset = "0x14251A0", VA = "0x14251A0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C20C")]
	[Address(RVA = "0x1425248", Offset = "0x1425248", VA = "0x1425248", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C20D")]
	[Address(RVA = "0x1425398", Offset = "0x1425398", VA = "0x1425398")]
	public void Init(ToggleButtonGroupRuleSetting data)
	{
	}

	[Token(Token = "0x600C20E")]
	[Address(RVA = "0x1425AEC", Offset = "0x1425AEC", VA = "0x1425AEC", Slot = "31")]
	public void Reset()
	{
	}

	[Token(Token = "0x600C20F")]
	[Address(RVA = "0x1425DE0", Offset = "0x1425DE0", VA = "0x1425DE0")]
	private void OnItemSelectCallback(UIToggleButton btn)
	{
	}

	[Token(Token = "0x600C210")]
	[Address(RVA = "0x1425D1C", Offset = "0x1425D1C", VA = "0x1425D1C")]
	private void SetValue(int newValue)
	{
	}

	[Token(Token = "0x600C211")]
	[Address(RVA = "0x1425F1C", Offset = "0x1425F1C", VA = "0x1425F1C")]
	private bool _003CInit_003Em__0(ToggleButtonGroupRuleSetting.Item item)
	{
		return default(bool);
	}

	[Token(Token = "0x600C212")]
	[Address(RVA = "0x1425F68", Offset = "0x1425F68", VA = "0x1425F68")]
	private bool _003CReset_003Em__1(ToggleButtonGroupRuleSetting.Item item)
	{
		return default(bool);
	}

	[Token(Token = "0x600C213")]
	[Address(RVA = "0x1425FB4", Offset = "0x1425FB4", VA = "0x1425FB4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
