using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200230F")]
public class UIRuleSmallToggleButtonGroupSettingController : UIBaseController, _Attribute
{
	[Token(Token = "0x400DAA9")]
	[FieldOffset(Offset = "0x28")]
	private UIRuleSmallToggleButtonGroupSettingView m_View;

	[Token(Token = "0x400DAAA")]
	[FieldOffset(Offset = "0x2C")]
	public ToggleButtonGroupRuleSetting Data;

	[Token(Token = "0x400DAAB")]
	[FieldOffset(Offset = "0x30")]
	public Action<int, int> ItemSelectCallback;

	[Token(Token = "0x400DAAC")]
	[FieldOffset(Offset = "0x34")]
	private UIToggleButtonGroup m_ToggleButtonGroup;

	[Token(Token = "0x400DAAD")]
	[FieldOffset(Offset = "0x38")]
	private List<UIRuleToggleButtonController> m_ToggleButtons;

	[Token(Token = "0x400DAAE")]
	[FieldOffset(Offset = "0x3C")]
	public Action OnDataChanged;

	[Token(Token = "0x600C1DD")]
	[Address(RVA = "0x141FD3C", Offset = "0x141FD3C", VA = "0x141FD3C")]
	public UIRuleSmallToggleButtonGroupSettingController()
	{
	}

	[Token(Token = "0x600C1DE")]
	[Address(RVA = "0x141FDC0", Offset = "0x141FDC0", VA = "0x141FDC0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C1DF")]
	[Address(RVA = "0x141FE68", Offset = "0x141FE68", VA = "0x141FE68", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C1E0")]
	[Address(RVA = "0x141FFB8", Offset = "0x141FFB8", VA = "0x141FFB8")]
	public void Init(ToggleButtonGroupRuleSetting data)
	{
	}

	[Token(Token = "0x600C1E1")]
	[Address(RVA = "0x1420934", Offset = "0x1420934", VA = "0x1420934", Slot = "31")]
	public void Reset()
	{
	}

	[Token(Token = "0x600C1E2")]
	[Address(RVA = "0x1420C28", Offset = "0x1420C28", VA = "0x1420C28")]
	private void OnItemSelectCallback(UIToggleButton btn)
	{
	}

	[Token(Token = "0x600C1E3")]
	[Address(RVA = "0x1420B64", Offset = "0x1420B64", VA = "0x1420B64")]
	private void SetValue(int newValue)
	{
	}

	[Token(Token = "0x600C1E4")]
	[Address(RVA = "0x1420D64", Offset = "0x1420D64", VA = "0x1420D64")]
	private bool _003CInit_003Em__0(ToggleButtonGroupRuleSetting.Item item)
	{
		return default(bool);
	}

	[Token(Token = "0x600C1E5")]
	[Address(RVA = "0x1420DB0", Offset = "0x1420DB0", VA = "0x1420DB0")]
	private bool _003CReset_003Em__1(ToggleButtonGroupRuleSetting.Item item)
	{
		return default(bool);
	}

	[Token(Token = "0x600C1E6")]
	[Address(RVA = "0x1420DFC", Offset = "0x1420DFC", VA = "0x1420DFC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
